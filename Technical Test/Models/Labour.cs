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
        /// <summary>
        /// Set and get the labour name
        /// </summary>
        [Required]
        [Display(Name = "Labour Name")]
        public string LabourName { get; set; }
        /// <summary>
        /// Set and get department 
        /// </summary>
        [Required]
        public string Department { get; set; }
        /// <summary>
        /// Set and get description
        /// </summary>
        [Required]
        public string Description { get; set; }
        /// <summary>
        /// Set and get premises
        /// </summary>
        [Required]
        [Display(Name ="Premises")]
        public Premises premises { get; set; }
        /// <summary>
        /// Set and get cost
        /// </summary>
        [RegularExpression(@"^(0|-?\d{0,16}(\.\d{0,2})?)$")]
        public decimal Cost { get; set; }
    }
    public enum Premises { London, NewDelhi, Paris }
}