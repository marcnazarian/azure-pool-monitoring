// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PoolSensorDataViewModel.cs" company="Company">
//   Pool sensor data view model
// </copyright>
// <summary>
//   The pool sensor data view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PoolMonitoringWebRole.ViewModels
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// The pool sensor data view model.
    /// </summary>
    public class PoolSensorDataViewModel
    {
        /// <summary>
        /// Gets or sets the pool name.
        /// </summary>
        public string PoolName { get; set; }

        /// <summary>
        /// Gets or sets the pH.
        /// </summary>
        [DisplayName("pH")]
        public double Ph { get; set; }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is status ok.
        /// </summary>
        public bool IsStatusOk { get; set; }

        /// <summary>
        /// Gets or sets the alert messages.
        /// </summary>
        public List<string> AlertMessages { get; set; }
    }
}