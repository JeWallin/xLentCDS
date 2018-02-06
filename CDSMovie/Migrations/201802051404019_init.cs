namespace CDSMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountLoggins",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 256, unicode: false),
                        Password = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountLoggins");
        }
    }
}
