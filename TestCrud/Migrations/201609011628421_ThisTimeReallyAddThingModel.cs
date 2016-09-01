namespace TestCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThisTimeReallyAddThingModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Things",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Things");
        }
    }
}
