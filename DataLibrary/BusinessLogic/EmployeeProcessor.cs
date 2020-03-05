using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class EmployeeProcessor
    {
        public static int CreateEmployee(int empCWID, string firstName, string lastName, string empMI, 
            string streetAddress, string empCity, string empState, int empZip, string payroll, int salary, 
            int empPoBox, string empPoBoxCity, string empPoBoxState, int empOrgCode, string empDepartment, 
            int givingYear, bool empStatus, DateTime empDateCreated)
        {
            EmployeeModel data = new EmployeeModel
            {
                CWID = empCWID,
                EmployeeFirstName = firstName,
                EmployeeLastName = lastName,
                EmployeeMI = empMI,
                StreetAddress = streetAddress,
                EmployeeCity = empCity,
                EmployeeState = empState,
                EmployeeZip = empZip,
                Payroll = payroll,
                Salary = salary,
                POBox = empPoBox,
                POBoxCity = empPoBoxCity,
                POBoxState = empPoBoxState,
                OrgCode = empOrgCode,
                EmployeeDepartment = empDepartment,
                GivingYear = givingYear,
                EmployeeStatus = empStatus,
                EmployeeDateCreated = empDateCreated,
            };

            string sql = @"INSERT INTO Employee (cwid, employeefirstname, employeelastname, employeemi, streetaddress, employeecity, employeestate, employeezip, payroll, salary, pobox, poboxstate, poboxcity, givingyear, employeestatus, orgcode, employeedatecreated)
                    VALUES                      (@CWID, @EmployeeFirstName, @EmployeeLastName, @EmployeeMI, @StreetAddress, @EmployeeCity, @EmployeeState, @EmployeeZip, @Payroll, @Salary, @POBox, @POBoxState, @POBoxCity, @GivingYear, @EmployeeStatus, @OrgCode, @EmployeeDateCreated)";

            return SQLDataAccess.SaveData(sql, data);

        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"SELECT cwid, employeefirstname, employeelastname, employeemi, streetaddress, employeecity, employeestate, employeezip, payroll, salary, pobox, poboxstate, poboxcity, givingyear, employeestatus, orgcode, employeedatecreated
                            from dbo.Employee;";

            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
