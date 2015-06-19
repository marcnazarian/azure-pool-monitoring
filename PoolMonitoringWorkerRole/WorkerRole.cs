// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Company" file="WorkerRole.cs">
//   The worker role
// </copyright>
// <summary>
//   The worker role.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace PoolMonitoringWorkerRole
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Threading;

    using Microsoft.ServiceBus;
    using Microsoft.ServiceBus.Messaging;
    using Microsoft.WindowsAzure;
    using Microsoft.WindowsAzure.ServiceRuntime;

    using PoolMonitoringWebRole.Models;

    /// <summary>
    /// The worker role.
    /// </summary>
    public class WorkerRole : RoleEntryPoint
    {
        /// <summary>
        /// The queue name.
        /// </summary>
        private const string QueueName = "ProcessingQueue";
  
        /// <summary>
        /// The client.
        /// </summary>
        private QueueClient client;

        /// <summary>
        /// The completed event.
        /// </summary>
        private ManualResetEvent completedEvent = new ManualResetEvent(false);

        /// <summary>
        /// The run.
        /// </summary>
        public override void Run()
        {
            Console.WriteLine("Starting processing of messages");

            OnMessageOptions options = new OnMessageOptions();
            options.AutoComplete = false;
            options.AutoRenewTimeout = TimeSpan.FromMinutes(1);

            // Initiates the message pump and callback is invoked for each message that is received, calling close on the client will stop the pump.
            this.client.OnMessage(
                receivedMessage =>
                    {
                        try
                        {
                            // Process the message
                            Console.WriteLine("Processing Service Bus message: " + receivedMessage.SequenceNumber.ToString());

                            PoolSensorData poolSensorData = new PoolSensorData
                                                                {
                                                                    PoolId = (int)receivedMessage.Properties["pool_id"],
                                                                    Ph = (double)receivedMessage.Properties["ph"],
                                                                    Temperature = (double)receivedMessage.Properties["temperature"]
                                                                };
                            PoolMonitoringContext databaseContext = new PoolMonitoringContext();
                            var sensorData = databaseContext.PoolSensorDatas.SingleOrDefault(d => d.PoolId.Equals(poolSensorData.PoolId));
                            if (sensorData == null)
                            {
                                databaseContext.PoolSensorDatas.Add(poolSensorData);
                            }
                            else
                            {
                                sensorData.Ph = poolSensorData.Ph;
                                sensorData.Temperature = poolSensorData.Temperature;
                            }

                            databaseContext.SaveChanges();

                            receivedMessage.Complete();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);

                            // Handle any message processing specific exceptions here
                            receivedMessage.Abandon();
                        }
                    },
                options);

            this.completedEvent.WaitOne();
        }

        /// <summary>
        /// The on start.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections 
            ServicePointManager.DefaultConnectionLimit = 12;

            // Create the queue if it does not exist already
            string connectionString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");
            var namespaceManager = NamespaceManager.CreateFromConnectionString(connectionString);
            if (!namespaceManager.QueueExists(QueueName))
            {
                namespaceManager.CreateQueue(QueueName);
            }

            // Initialize the connection to Service Bus Queue
            this.client = QueueClient.CreateFromConnectionString(connectionString, QueueName);
            return base.OnStart();
        }

        /// <summary>
        /// The on stop.
        /// </summary>
        public override void OnStop()
        {
            // Close the connection to Service Bus Queue
            this.client.Close();
            this.completedEvent.Set();
            base.OnStop();
        }
    }
}
