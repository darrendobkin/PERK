using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PERK.Models
{
    public class Case
    {
        public int ID { get; set; }
        public DateTime DateReviewed { get; set; }
        public String Reviewer { get; set; }
        public String CRNumber { get; set; }
        public String SANEBarcode { get; set; }
        public String Clearance { get; set; }
        public DateTime CaseDate { get; set; }
        public String VictimLastName { get; set; }
        public String VictimFirstName { get; set; }
        public String VictimMiddleName { get; set; }
        public Boolean Resealed { get; set; }

        public virtual ICollection<EvidenceReview> EvidenceReviews { get; set; }
    }
}