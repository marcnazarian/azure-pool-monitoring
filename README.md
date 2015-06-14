# azure-pool-monitoring
Pool monitoring in the cloud (Azure)

Open the solution into Visual Studio (2013, run as Administrator)

To deploy the project in the cloud:
- create an azure cloud service
- create an azure database
- create an azure service bus namespace
- create an azure table

Replace all the values into <> in files:
- ServiceConfiguration.Cloud.cscfg
- ServiceConfiguration.Local.cscfg
- PoolMonitoringWorkerRole/App.config
by connection strings of your newly created Azure items

Build the project.

Right-click on the cloud item on Visual Studio, 
Publish...
