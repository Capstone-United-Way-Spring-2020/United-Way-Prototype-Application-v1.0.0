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
        [Required(ErrorMessage = "You must enter an org code")]
        public int OrgCode { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "You must enter a department name.")]
        public string departmentname { get; set; }

        [Display(Name = "UW Coordinator 3")]
        public string UWCoordinator3 { get; set; }

        [Display(Name = "UW Coordinator 2")]
        public string UWCoordinator2 { get; set; }

        [Display(Name = "UW Coordinator 1")]
        public string UWCoordinator1 { get; set; }

        [Display(Name = "Division")]
        public string Division { get; set; }

       [Display(Name = "Department Status")]
        public bool DepartmentStatus { get; set; } = true;

        [Display(Name = "Department Date Created")]
        public DateTime DepartmentDateCreated { get; set; } = DateTime.Now;

        [Display(Name = "Department Last Edited")]
        public DateTime DepartmentLastEdited { get; set; } = DateTime.Now;


    }
}