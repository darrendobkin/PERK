using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PERK.Models
{
    public class EvidenceReview
    {
        public int ID { get; set; }
        public DateTime ReviewDate { get; set; }
        public String Investigator { get; set; }
        public String LabTech { get; set; }
        public String CrimeSceneTech { get; set; }
        public Boolean ProbativeItems { get; set; }
        public Boolean Located { get; set; }
        public virtual ICollection<EvidenceItem> Items { get; set; }
    }
}