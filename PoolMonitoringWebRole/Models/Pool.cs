// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pool.cs" company="Company">
//   The Pool model
// </copyright>
// <summary>
//   The pool.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PoolMonitoringWebRole.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The pool.
    /// </summary>
    public class Pool
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}