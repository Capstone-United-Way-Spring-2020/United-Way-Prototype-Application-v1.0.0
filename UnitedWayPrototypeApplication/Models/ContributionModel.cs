using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class ContributionModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Contribution ID")]
        public int ContributionID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "CWID")]
        [Required(ErrorMessage = "You must enter an employee CWID.")]
        public int CWID { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Employee First Name")]
        public string CFirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Employee Last Name")]
        public string CLastName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Agency ID (optional)")]
        public int AgencyID { get; set; }

        [Display(Name = "Type of Contribution")]
        [Required(ErrorMessage = "You must select a contribution type.")]
        public string UWType { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Monthly Amount")]
        [Required(ErrorMessage ="You must enter the monthly amount.")]
        public double UWMonthly { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Number of Months")]
        [Required(ErrorMessage = "You must enter the number of months.")]
        public int UWMonths { get; set; }

        [Display(Name = "Check Number")]
        public int CheckNumber { get; set; }

        [DataType(DataType.Currency)]
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