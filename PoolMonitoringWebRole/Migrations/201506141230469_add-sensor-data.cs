namespace PoolMonitoringWebRole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsensordata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PoolSensorDatas",
                c => new
                    {
                        PoolId = c.Int(nullable: false),
                        Ph = c.Double(nullable: false),
                        Temperature = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PoolId)
                .ForeignKey("dbo.Pools", t => t.PoolId)
                .Index(t => t.PoolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PoolSensorDatas", "PoolId", "dbo.Pools");
            DropIndex("dbo.PoolSensorDatas", new[] { "PoolId" });
            DropTable("dbo.PoolSensorDatas");
            DropTable("dbo.Pools");
        }
    }
}
