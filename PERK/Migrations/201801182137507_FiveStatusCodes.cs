namespace PERK.Migrations
{
    using PERK.DAL;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FiveStatusCodes : DbMigration
    {
        public override void Up()
        {
            PERKContext db = new PERKContext();
            db.CaseReviewStatusCodes.Add(new Models.CaseReviewStatusCode() { Code = "O", Description = "Open" });
            db.CaseReviewStatusCodes.Add(new Models.CaseReviewStatusCode() { Code = "S", Description = "Suspended" });
            db.CaseReviewStatusCodes.Add(new Models.CaseReviewStatusCode() { Code = "A", Description = "Arrest" });
            db.CaseReviewStatusCodes.Add(new Models.CaseReviewStatusCode() { Code = "C", Description = "Closed by Exception" });
            db.CaseReviewStatusCodes.Add(new Models.CaseReviewStatusCode() { Code = "U", Description = "Unfounded" });
            db.SaveChanges();
        }

        public override void Down()
        {

            PERKContext db = new PERKContext();
            foreach (Models.CaseReviewStatusCode c in db.CaseReviewStatusCodes)
            {
                db.CaseReviewStatusCodes.Remove(c);
            }
            db.SaveChanges();
        }
    }
}
