using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class ContributionModel
    {
        //This means were on the same page
        [Required(ErrorMessage = "Please enter a Contribution ID")]
        [Display(Name = "Contribution ID")]
        [Range(0, int.MaxValue, ErrorMessage = "Contribution ID must be a valid ID.")]
        public int ContributionID { get; set; }

        [Display(Name = "CWID")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "CWID must be valid in length.")]
        public int CWID { get; set; }

        [Display(Name = "Employee First Name")]
        [MinLength(0)]
        [Required(ErrorMessage = "You must enter an employee first name.")]
        public string CFirstName { get; set; }

        [Display(Name = "Employee Last Name")]
        [MinLength(0)]
        [Required(ErrorMessage = "You must enter an employee last name.")]
        public string CLastName { get; set; }

        [Display(Name = "Agency ID #1")]
        [Required(ErrorMessage = "You must enter at least one Agency ID.")]
        [Range(0, 100, ErrorMessage = "Agency ID must be valid.")]
        public int AgencyID { get; set; }

        // Need Agency ID #2 (Optional) Field

        // Need Agency ID #3 (Optional) Field

        [Display(Name = "Type of Contribution")]
        [Required(ErrorMessage = "You must select a contribution type.")]
        public string UWType { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Monthly Amount")]
        [MinLength(0, ErrorMessage = "Monthly Amount must be a valid number.")]
        [Required(ErrorMessage = "You must enter the monthly amount.")]
        public double UWMonthly { get; set; }

        [Display(Name = "Number of Months")]
        [Range(0, 12, ErrorMessage = "Number of Months must be a valid number.")]
        [Required(ErrorMessage = "You must enter the number of months.")]
        public int UWMonths { get; set; }

        // Skipping validation for check number right now but it'll need to be added later on
        [Display(Name = "Check Number")]
        public int CheckNumber { get; set; }

        // Validation to check that user entered amount equals monthly * months ????
        [DataType(DataType.Currency)]
        [Display(Name = "Total Contribution Amount")]
        [MinLength(0, ErrorMessage = "Total Amount must be a valid number.")]
        public double ContributionAmount { get; set; }

        // Automate..?
        [Display(Name = "Current Year")]
        [Required(ErrorMessage = "You must enter the current year.")]
        public int UWYear { get; set; }



        // Commented out in Views file
        [DataType(DataType.Date)]
        [Display(Name = "Date of Contribution")]
        public System.DateTime UWDateCreated { get; set; } = DateTime.Now;

        // Commented out in Views file
        [DataType(DataType.Date)]
        [Display(Name = "Date of Edit")]
        public System.DateTime UWDateLastEdited { get; set; }
    }

}