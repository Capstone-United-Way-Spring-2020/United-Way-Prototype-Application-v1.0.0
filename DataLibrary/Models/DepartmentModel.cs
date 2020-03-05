using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class DepartmentModel
    //this is a front end, user interface model and is different from the data access model
    //dont want to decorate these models, not needed (name, requirements, error messages etc)
    //DATABASE doesnt care about modifiers, only the properties themselves
    {
        public int OrgCode { get; set; }
        public string departmentname { get; set; }
        public string UWCoordinator3 { get; set; }
        public string UWCoordinator2 { get; set; }
        public string UWCoordinator1 { get; set; }
        public string Division { get; set; }
        public bool DepartmentStatus { get; set; } = true;
        public DateTime DepartmentDateCreated { get; set; }
        public DateTime DepartmentLastEdited { get; set; }
    }
}
