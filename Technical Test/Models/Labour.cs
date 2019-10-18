using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Technical_Test.Models
{
    public class Labour
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Labour Name")]
        public string LabourName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Premises premises { get; set; }
       
        public int Cost { get; set; }
    }
    public enum Premises { London, NewDelhi, Paris }
}