using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PERK.Models
{
    public class CaseReview
    {
        public int ID { get; set; }
        public DateTime DateReviewed { get; set; }
        public String Investigator { get; set; }
    }
}