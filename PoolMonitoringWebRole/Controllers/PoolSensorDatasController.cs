// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Company" file="PoolSensorDatasController.cs">
//   The Pool sensor data controller
// </copyright>
// <summary>
//   The pool sensor data controller.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

namespace PoolMonitoringWebRole.Controllers
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Net;
    using System.Web.Mvc;
    using PoolMonitoringWebRole.Models;
    using PoolMonitoringWebRole.ViewModels;

    /// <summary>
    /// The pool sensor data controller.
    /// </summary>
    public class PoolSensorDatasController : Controller
    {
        /// <summary>
        /// The databaseContext.
        /// </summary>
        private PoolMonitoringContext databaseContext = new PoolMonitoringContext();

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Index()
        {
            IEnumerable<PoolSensorData> allPoolSensorData = this.databaseContext.PoolSensorDatas.Include(d => d.Pool);
            return this.View(allPoolSensorData);
        }

        /// <summary>
        /// The details.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PoolSensorData poolSensorData = this.databaseContext.PoolSensorDatas.Find(id);
            if (poolSensorData == null)
            {
                return this.HttpNotFound();
            }

            PoolStatus poolStatus = new PoolStatus(poolSensorData.Ph, poolSensorData.Temperature);
            PoolSensorDataViewModel viewModel = new PoolSensorDataViewModel
                                                    {
                                                        PoolName = poolSensorData.Pool.Name,
                                                        Ph = poolSensorData.Ph,
                                                        Temperature = poolSensorData.Temperature,
                                                        IsStatusOk = poolStatus.IsStatusOk(),
                                                        AlertMessages = poolStatus.AlertMessages
                                                    };
            return this.View(viewModel);
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        /// <param name="disposing">
        /// The disposing.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.databaseContext.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
