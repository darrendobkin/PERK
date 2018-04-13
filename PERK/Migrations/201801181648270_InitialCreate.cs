namespace PERK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Case",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateReviewed = c.DateTime(nullable: false),
                        Reviewer = c.String(),
                        CRNumber = c.String(),
                        SANEBarcode = c.String(),
                        Clearance = c.String(),
                        CaseDate = c.DateTime(nullable: false),
                        VictimLastName = c.String(),
                        VictimFirstName = c.String(),
                        VictimMiddleName = c.String(),
                        Resealed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EvidenceReview",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReviewDate = c.DateTime(nullable: false),
                        Investigator = c.String(),
                        LabTech = c.String(),
                        CrimeSceneTech = c.String(),
                        ProbativeItems = c.Boolean(nullable: false),
                        Located = c.Boolean(nullable: false),
                        Case_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Case", t => t.Case_ID)
                .Index(t => t.Case_ID);
            
            CreateTable(
                "dbo.EvidenceItem",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BarCode = c.String(),
                        EvidenceReview_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EvidenceReview", t => t.EvidenceReview_ID)
                .Index(t => t.EvidenceReview_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EvidenceReview", "Case_ID", "dbo.Case");
            DropForeignKey("dbo.EvidenceItem", "EvidenceReview_ID", "dbo.EvidenceReview");
            DropIndex("dbo.EvidenceItem", new[] { "EvidenceReview_ID" });
            DropIndex("dbo.EvidenceReview", new[] { "Case_ID" });
            DropTable("dbo.EvidenceItem");
            DropTable("dbo.EvidenceReview");
            DropTable("dbo.Case");
        }
    }
}
