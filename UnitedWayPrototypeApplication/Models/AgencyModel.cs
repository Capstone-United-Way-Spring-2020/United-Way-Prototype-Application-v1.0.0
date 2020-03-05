using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class AgencyModel
    {
        [Display(Name = "Agency ID")]
        [Range(0, 100, ErrorMessage = "Please enter a valid Agency ID.")]
        [Required(ErrorMessage = "You must enter an Agency ID.")]
        public int AgencyID { get; set; }

        [Display(Name = "Agency Name")]
        [Required(ErrorMessage = "You must enter an Agency Name.")]
        [MinLength(1)]
        public string AgencyName { get; set; }

        // Commented out in Views file
        [Display(Name = "Agency Status")]
        public bool AgencyStatus { get; set; } = true;

        // Commented out in Views file
        [Display(Name = "Agency Date Created")]
        public DateTime AgencyDateCreated { get; set; } = DateTime.Now;

        // Commented out in Views file
        [Display(Name = "Agency Last Edited")]
        public DateTime AgencyDateLastEdited { get; set; } = DateTime.Now;
    }

}