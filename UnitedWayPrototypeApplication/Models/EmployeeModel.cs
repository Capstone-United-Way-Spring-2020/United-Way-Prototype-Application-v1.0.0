using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class EmployeeModel
    {
        [Display(Name = "CWID")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "CWID must be valid in length.")]
        [Required(ErrorMessage = "You must enter a CWID.")]
        public int CWID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter an employee first name.")]
        [MinLength(1)]
        public string EmployeeFirstName { get; set; }

        [Display(Name = "Last Name")]
        [MinLength(1)]
        [Required(ErrorMessage = "You must enter an employee last name.")]
        public string EmployeeLastName { get; set; }

        [Display(Name = "Middle Initial")]
        [MinLength(0)]
        public string EmployeeMI { get; set; }


        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "You must enter a street address.")]
        [MinLength(1)]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must enter a city.")]
        [MinLength(1)]
        public string EmployeeCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "You must enter a state.")]
        [MinLength(1)]
        public string EmployeeState { get; set; }

        // Needs to probably be changed into a string to read any 0's at the beginning (00510 not 510)
        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "Must be a valid zip code.")]
        [Required(ErrorMessage = "You must enter a zip code.")]
        public int EmployeeZip { get; set; }

        // Payroll Type could probably be changed to radio buttons (monthly, one-time, etc)
        [Display(Name = "Payroll Type")]
        [Required(ErrorMessage = "You must enter an employee payroll type.")]
        public string Payroll { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Salary")]
        [MinLength(0, ErrorMessage = "Monthly Amount must be a valid number.")]
        public int Salary { get; set; }

        // Needs to probably be changed into a string to read any 0's at the beginning 
        [Display(Name = "PO Box")]
        [Required(ErrorMessage = "You must enter an employee po box number.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Must be a valid PO box number.")]
        public int POBox { get; set; }

        [Display(Name = "PO Box City")]
        [Required(ErrorMessage = "You must enter a city for the employee's PO box.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be a valid city.")]
        public string POBoxCity { get; set; }

        [Display(Name = "PO Box State")]
        [Required(ErrorMessage = "You must enter a state for the employee's PO box.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Must be a valid state.")]
        public string POBoxState { get; set; }

        [Display(Name = "Org Code")]
        [MinLength(0)]
        public int OrgCode { get; set; }

        // Set Department equal to Dept. associated with entered org code?
        // SQL DB missing Department field in Employee Table
        [Display(Name = "Department")]
        [MinLength(0)]
        public string EmployeeDepartment { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Giving Year")]
        [Required(ErrorMessage = "You must enter the giving year.")]
        public int GivingYear { get; set; }


        // Commented out in Views file
        [Display(Name = "Employee Status")]
        public bool EmployeeStatus { get; set; } = true;

        // Commented out in Views file
        [DataType(DataType.Date)]
        [Display(Name = "Date Created")]
        public DateTime EmployeeDateCreated { get; set; } = DateTime.Now;

        // Need to add EmployeeDateLastEdited Field
        // Will need to be Commented out in Views file
    }

}