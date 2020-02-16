using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class ContributionModel
    {
        [Display(Name = "Contribution ID")]
        public int ContributionID { get; set; }

        [Display(Name = "CWID")]
        [Required(ErrorMessage = "You must enter an employee CWID")]
        public int CWID { get; set; }

        [Display(Name = "First Name")]
        public string CFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string CLastName { get; set; }

        [Display(Name = "Agency ID (optional)")]
        public int AgencyID { get; set; }

        [Display(Name = "Type of contribution")]
        [Required(ErrorMessage = "You must select a contribution type")]
        public string UWType { get; set; }

        [Display(Name = "Monthly Amount")]
        public int UWMonthly { get; set; }

        [Display(Name = "Number of Months")]
        public int UWMonths { get; set; }

        [Display(Name = "Check Number")]
        public int CheckNumber { get; set; }

        [Display(Name = "Total Contribution Amount")]
        public int ContributionAmount { get; set; }

        [Display(Name = "Current Year")]
        public int UWYear { get; set; }

        [Display(Name = "Date of Contribution")]
        public DateTime UWDateCreated { get; set; } = DateTime.Now;

        [Display(Name = "Date of Edit")]
        public DateTime UWDateLastEdited { get; set; }
    }
}