namespace NereNot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ctxNOT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mission",
                c => new
                    {
                        msnRef = c.Guid(nullable: false),
                        msnHead = c.String(maxLength: 1500),
                        msnContent = c.String(),
                        msnNotify = c.Boolean(nullable: false),
                        msnNotifyTime = c.String(),
                        msnNotifyDate = c.DateTime(nullable: false),
                        msnOffer = c.Boolean(nullable: false),
                        msnProject = c.Boolean(nullable: false),
                        msnFileIsOn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.msnRef)
                .Index(t => t.msnHead, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Mission", new[] { "msnHead" });
            DropTable("dbo.Mission");
        }
    }
}
