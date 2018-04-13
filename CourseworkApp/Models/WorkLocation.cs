using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CourseworkApp.Models
{
    public class WorkLocation
    {
        [Key]
        public int WorkLocationID { get; set; }

        public string WorkLocationName { get; set; }

        [Required(ErrorMessage = "Please enter the 1st Address Line!")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter the City!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the County!")]
        public string County { get; set; }

        [Required(ErrorMessage = "Please enter the PostCode!")]
        public string PostCode { get; set; }
    }
}