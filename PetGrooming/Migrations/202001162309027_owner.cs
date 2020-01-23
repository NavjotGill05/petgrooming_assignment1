namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class owner : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerId = c.String(nullable: false, maxLength: 128),
                        OwnerFName = c.String(),
                        OwnerLName = c.String(),
                        OwnerPhone = c.Int(nullable: false),
                        OwnerEmail = c.String(),
                        OwnerAddress = c.String(),
                    })
                .PrimaryKey(t => t.OwnerId);
            
            AddColumn("dbo.Pets", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pets", "DOB");
            DropTable("dbo.Owners");
        }
    }
}
