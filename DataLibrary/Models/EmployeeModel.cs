using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public int CWID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeMI { get; set; }
        public string StreetAddress { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeState { get; set; }
        public int EmployeeZip { get; set; }
        public string Payroll { get; set; }
        public int Salary { get; set; }
        public int POBox { get; set; }
        public string POBoxCity { get; set; }
        public string POBoxState { get; set; }
        public int OrgCode { get; set; }
        public string EmployeeDepartment { get; set; }
        public int GivingYear { get; set; }
        public bool EmployeeStatus { get; set; } = true;
        public DateTime EmployeeDateCreated { get; set; } = DateTime.Now;
    }
}
