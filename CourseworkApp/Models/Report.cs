using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CourseworkApp.Models
{
    public class Report
    {
        [Key]
        public int ReportID { get; set; }
        [Required(ErrorMessage = "Please enter the Report Title!")]
        public string ReportTitle { get; set; }
        [Required(ErrorMessage = "Please enter the Report Abstract!")]
        public string ReportAbstract { get; set; }
        [Required(ErrorMessage = "Please enter the Report Link!")]
        public string ReportLink { get; set; }
    }
}