// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Company" file="PoolSensorEmulator.cs">
//   Pool sensor emulator
// </copyright>
// <summary>
//   The pool sensor emulator.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace PoolSensorEmulator
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Windows.Forms;

    using Microsoft.Azure;
    using Microsoft.ServiceBus.Messaging;

    /// <summary>
    /// The pool sensor emulator.
    /// </summary>
    public partial class PoolSensorEmulator : Form
    {
        /// <summary>
        /// The queue client.
        /// </summary>
        private readonly QueueClient queueClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolSensorEmulator"/> class.
        /// </summary>
        public PoolSensorEmulator()
        {
            this.InitializeComponent();

            string connectionString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");
            this.queueClient = QueueClient.CreateFromConnectionString(connectionString, "ProcessingQueue");
        }

        /// <summary>
        /// The generate infinite random values click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void GenerateInfiniteRandomValuesClick(object sender, EventArgs e)
        {
            int numberOfMessages = (int)this.numberOfMessagesNumericUpDown.Value;
            for (int i = 1; i <= numberOfMessages; i++)
            {
                int poolId = (int)this.poolIdNumericUpDown.Value;
                double ph = this.GetRandomNumber(1.0, 14.0);
                double temperature = this.GetRandomNumber(18.0, 32.0);

                this.randomValuePh.Text = ph.ToString(CultureInfo.CurrentUICulture);
                this.randomValueTemperature.Text = temperature.ToString(CultureInfo.CurrentUICulture);
                this.Refresh();

                this.SendMessagePoolSensor(poolId, ph, temperature);
                
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// The send message pool sensor.
        /// </summary>
        /// <param name="poolId">
        /// The pool id.
        /// </param>
        /// <param name="ph">
        /// The pH.
        /// </param>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        private void SendMessagePoolSensor(int poolId, double ph, double temperature)
        {
            BrokeredMessage message = new BrokeredMessage();
            message.Properties["pool_id"] = poolId;
            message.Properties["ph"] = ph;
            message.Properties["temperature"] = temperature;

            this.queueClient.Send(message);
        }

        /// <summary>
        /// The get random number.
        /// </summary>
        /// <param name="minimum">
        /// The minimum.
        /// </param>
        /// <param name="maximum">
        /// The maximum.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return Math.Round((random.NextDouble() * (maximum - minimum)) + minimum, 1);
        }

        /// <summary>
        /// The send one message with value button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SendOneMessageWithValueButton_Click(object sender, EventArgs e)
        {
            int poolId = (int)this.poolIdNumericUpDown.Value;
            double ph = (double)this.phNumericUpDown.Value;
            double temperature = (double)this.temperatureNumericUpDown.Value;

            this.SendMessagePoolSensor(poolId, ph, temperature);
        }

    }
}
