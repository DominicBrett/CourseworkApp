using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CourseworkApp.Models
{
    public class User
    {
        [Key]

    
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter the Name!")]
        public string Name { get; set; }

        public string Gender { get; set; }
        public string DOB { get; set; }

        [Required(ErrorMessage = "Please enter the e-mail!")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Please enter the 1st Address Line!")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter the City!")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the County!")]
        public string County { get; set;}

        [Required(ErrorMessage = "Please enter the PostCode!")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Please enter the HomePhone!")]
        public string HomePhone { get; set; }

        [Required(ErrorMessage = "Please enter the WorkPhone!")]
        public string WorkPhone { get; set; }

        [Required(ErrorMessage = "Please enter the MobilePhone!")]
        public string MobilePhone { get; set; }

        public Boolean IsAdmin { get; set; }

        public int WorkLocationID { get; set; }
        //Do Should haves and could havse
    }
}