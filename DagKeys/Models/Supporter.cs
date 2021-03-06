//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DagKeys.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public partial class Supporter
    {
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        public int supporterId { get; set; }
        [Display(Name = "Years of Support")]
        public Nullable<int> yearsOfSupport { get; set; }
        [Display(Name = "Residence")]
        public string location { get; set; }
        [Display(Name = "Contribution")]
        public string contributionType { get; set; }
    }
}
