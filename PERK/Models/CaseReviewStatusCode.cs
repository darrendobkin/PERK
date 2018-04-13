using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PERK.Models
{
    public class CaseReviewStatusCode
    {
        [Key]
        public String Code { get; set; }

        public String Description { get; set; }
    }
}