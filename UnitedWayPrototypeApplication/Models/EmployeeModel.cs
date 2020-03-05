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
        [Range(10000000, 99999999, ErrorMessage = "You need to enter a valid CWID")]
        [Required(ErrorMessage = "You must enter a CWID")]
        public int CWID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="You must enter a first name")]
        public string EmployeeFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter a last name")]
        public string EmployeeLastName { get; set; }

        [Display(Name = "Middle Initial")]
        public string EmployeeMI { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "You must enter a street address")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must enter a ctiy")]
        public string EmployeeCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "You must enter a state")]
        public string EmployeeState { get; set; }
        
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "You must enter a zip code")]
        public int EmployeeZip { get; set; }

        [Display(Name = "Payroll Type")]
        [Required(ErrorMessage = "You must enter an employee payroll type")]
        public string Payroll { get; set; }

        [Display(Name = "Salary")]
        [Required(ErrorMessage = "You must enter a valid salary")]
        public int Salary { get; set; }

        [Display(Name = "PO Box")]
        public int POBox { get; set; }

        [Display(Name = "PO Box City")]
        public string POBoxCity { get; set; }

        [Display(Name = "PO Box State")]
        public string POBoxState { get; set; }

        [Display(Name = "Org Code")]
        public int OrgCode { get; set; }

        [Display(Name = "Department")]
        public string EmployeeDepartment { get; set; }

        [Display(Name = "Giving Year")]
        [Required(ErrorMessage = "You must enter the giving year")]
        public int GivingYear { get; set; } 

        [Display(Name = "Employee Status")]
        public bool EmployeeStatus { get; set; } = true;

        [Display(Name = "Date Created")]
        public DateTime EmployeeDateCreated { get; set; } = DateTime.Now;

    }
}