using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CourseworkApp.Models
{
    public class ConferenceCall
    {
        [Key]
        public int ConferenceCallID { get; set; }
        public string ConferenceCallTitle { get; set; }
        public string ConferenceCallDate { get; set; }
        public string ConferenceCallTranscript { get; set; }

    }
}