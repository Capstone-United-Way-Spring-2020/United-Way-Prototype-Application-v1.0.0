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
        [Required(ErrorMessage = "You must enter an Agency ID")]
        public int AgencyID { get; set; }

        [Display(Name = "Agency Name")]
        [Required(ErrorMessage = "You must enter an Agency Name")]
        public string AgencyName { get; set; }

       // [Display(Name = "Agency Status")]
        public bool AgencyStatus { get; set; } = true;

       // [Display(Name = "Agency Date Created")]
        public DateTime AgencyDateCreated { get; set; } = DateTime.Now;

      //  [Display(Name = "Agency Last Edited")]
        public DateTime AgencyDateLastEdited { get; set; } = DateTime.Now;
    }
}