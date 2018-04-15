using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CourseworkApp.Models
{
    public class ConferenceCallResearcher
    {
        [Key]
        public int ResearcherID { get; set; }
        public int ConferenceCallID { get; set; }
    }
}