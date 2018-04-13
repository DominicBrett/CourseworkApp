using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CourseworkApp.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        [Required(ErrorMessage = "Please enter the Name!")]
        public string EventName { get; set; }
        [Required(ErrorMessage = "Please enter the Description!")]
        public string EventDescription { get; set; }
        [Required(ErrorMessage = "Please enter the Location!")]
        public string EventLocation { get; set; }
        [Required(ErrorMessage = "Please enter the Date!")]
        public string EventDate { get; set; }
    }
}