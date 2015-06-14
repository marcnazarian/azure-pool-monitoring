// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Company" file="PoolMonitoringContext.cs">
//   The Pool monitoring context
// </copyright>
// <summary>
//   The pool monitoring context.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace PoolMonitoringWebRole.Models
{
    using System.Data.Entity;

    using Microsoft.WindowsAzure;

    /// <summary>
    /// The pool monitoring context.
    /// </summary>
    public class PoolMonitoringContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoolMonitoringContext"/> class.
        /// </summary>
        public PoolMonitoringContext()
            : base(CloudConfigurationManager.GetSetting("PoolMonitoringDatabase"))
        {
        }

        /// <summary>
        /// Gets or sets the pools.
        /// </summary>
        public DbSet<Pool> Pools { get; set; }

        /// <summary>
        /// Gets or sets the pool sensor data.
        /// </summary>
        public DbSet<PoolSensorData> PoolSensorDatas { get; set; }
    }
}
