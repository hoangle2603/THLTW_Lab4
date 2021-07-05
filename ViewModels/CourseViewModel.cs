using Lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Lab4.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }


        [FutureDate]
        [Required]
        public string Date { get; set; }
       
        [ValidTime]
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
            //exception
            //, CultureInfo.InvariantCulture
        }


    }
}