// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PoolSensorData.cs" company="Company">
//   The pool sensor data model
// </copyright>
// <summary>
//   The pool sensor data model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PoolMonitoringWebRole.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The pool sensor data model.
    /// </summary>
    public class PoolSensorData
    {
        /// <summary>
        /// Gets or sets the pool id.
        /// </summary>
        [Key]
        public int PoolId { get; set; }

        /// <summary>
        /// Gets or sets the pool.
        /// </summary>
        [ForeignKey("PoolId")]
        public virtual Pool Pool { get; set; }

        /// <summary>
        /// Gets or sets the ph.
        /// </summary>
        public double Ph { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public double Temperature { get; set; }
    }
}