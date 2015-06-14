// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PoolStatus.cs" company="Company">
//   The Pool status
// </copyright>
// <summary>
//   The pool status.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PoolMonitoringWebRole.ViewModels
{
    using System.Collections.Generic;

    /// <summary>
    /// The pool status.
    /// </summary>
    public class PoolStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoolStatus"/> class.
        /// </summary>
        public PoolStatus()
        {
            this.Status = PoolStatusEnum.Ok;
            this.AlertMessages = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolStatus"/> class.
        /// </summary>
        /// <param name="ph">
        /// The pH.
        /// </param>
        /// <param name="temperature">
        /// The temperature.
        /// </param>
        public PoolStatus(double ph, double temperature) : this()
        {
            if (temperature < 16.0)
            {
                this.AddWarning("You should warm your pool!");
            }

            if (temperature > 28.0)
            {
                this.AddWarning("Water is way too hot for you ;-)");
            }

            if (ph < 5.9)
            {
                this.AddWarning("pH too low: please add some pH+");
            }

            if (ph > 8.1)
            {
                this.AddWarning("pH too high: please add some pH-");
            }
        }

        /// <summary>
        /// The pool status.
        /// </summary>
        private enum PoolStatusEnum
        {
            /// <summary>
            /// The ok status.
            /// </summary>
            Ok = 1,

            /// <summary>
            /// The warning status.
            /// </summary>
            Warning = 2
        }

        /// <summary>
        /// Gets or sets the alert messages.
        /// </summary>
        public List<string> AlertMessages { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        private PoolStatusEnum Status { get; set; }

        /// <summary>
        /// The add warning.
        /// </summary>
        /// <param name="alertMessage">
        /// The alert message.
        /// </param>
        public void AddWarning(string alertMessage)
        {
            this.Status = PoolStatusEnum.Warning;
            this.AlertMessages.Add(alertMessage);
        }

        /// <summary>
        /// The is status ok.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsStatusOk()
        {
            return this.Status == PoolStatusEnum.Ok;
        }
    }
}