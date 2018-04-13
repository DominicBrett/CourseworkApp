using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CourseworkApp.Models
{
    public class Publication
    {
        [Key]
        public int PublicationID { get; set; }
        [Required(ErrorMessage = "Please enter the Publication Title!")]
        public string PublicationTitle { get; set; }
        [Required(ErrorMessage = "Please enter the Publication Abstract!")]
        public string PublicationAbstract { get; set; }
        [Required(ErrorMessage = "Please enter the Publication Link!")]
        public string PublicationLink { get; set; }
    }
}