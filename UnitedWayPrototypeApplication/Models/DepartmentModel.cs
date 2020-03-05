using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitedWayPrototypeApplication.Models
{
    public class DepartmentModel
    {
        [Display(Name = "Org Code")]
        [Required(ErrorMessage = "You must enter an org code.")]
        [StringLength(6, MinimumLength = 6)]
        public int OrgCode { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "You must enter a department name.")]
        [MinLength(1)]
        public string departmentname { get; set; }

        [Display(Name = "UW Coordinator 3")]
        [MinLength(0)]
        public string UWCoordinator3 { get; set; }

        [Display(Name = "UW Coordinator 2")]
        [MinLength(0)]
        public string UWCoordinator2 { get; set; }

        [Display(Name = "UW Coordinator 1")]
        [MinLength(0)]
        public string UWCoordinator1 { get; set; }

        [Display(Name = "Division")]
        [Required(ErrorMessage = "You must enter an Division.")]
        [MinLength(1)]
        public string Division { get; set; }


        // Commented out in Views file
        [Display(Name = "Department Status")]
        public bool DepartmentStatus { get; set; } = true;

        // Commented out in Views file
        [DataType(DataType.Date)]
        [Display(Name = "Department Date Created")]
        public DateTime DepartmentDateCreated { get; set; } = DateTime.Now;

        // Commented out in Views file
        [DataType(DataType.Date)]
        [Display(Name = "Department Date Last Edited")]
        public DateTime DepartmentLastEdited { get; set; } = DateTime.Now;


    }

}