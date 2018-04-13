namespace PERK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CaseReviewStatusCode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CaseReviewStatusCode",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            AddColumn("dbo.Case", "Status_Code", c => c.String(maxLength: 128));
            CreateIndex("dbo.Case", "Status_Code");
            AddForeignKey("dbo.Case", "Status_Code", "dbo.CaseReviewStatusCode", "Code");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Case", "Status_Code", "dbo.CaseReviewStatusCode");
            DropIndex("dbo.Case", new[] { "Status_Code" });
            DropColumn("dbo.Case", "Status_Code");
            DropTable("dbo.CaseReviewStatusCode");
        }
    }
}
