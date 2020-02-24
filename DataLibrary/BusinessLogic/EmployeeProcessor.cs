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
                FirstName = firstName,
                LastName = lastName,
                EmployeeMI = empMI,
                EmployeeStreetAddress = streetAddress,
                EmployeeCity = empCity,
                EmployeeState = empState,
                EmployeeZip = empZip,
                Payroll = payroll,
                Salary = salary,
                POBox = empPoBox,
                POBoxCity = empPoBoxCity,
                POBoxState = empPoBoxState,
                EmpOrgCode = empOrgCode,
                EmployeeDepartment = empDepartment,
                GivingYear = givingYear,
                EmployeeStatus = empStatus,
                EmployeeDateCreated = empDateCreated,
            };

            string sql = @"INSERT INTO Employee (cwid, employeefirstname, employeelastname, employeemi, streetaddress, employeecity, employeestate, employeezip, payroll, salary, pobox, poboxstate, poboxcity, givingyear, employeestatus, orgcode, employeedatecreated)
                    VALUES                      (@CWID, @FirstName, @LastName, @EmployeeMI, @EmployeeStreetAddress, @EmployeeCity, @EmployeeState, @EmployeeZip, @Payroll, @Salary, @POBox, @POBoxState, @POBoxCity, @GivingYear, @EmployeeStatus, @EmpOrgCode, @EmployeeDateCreated)";

            return SQLDataAccess.SaveData(sql, data);

        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"SELECT CWID, FirstName, LastName, EmployeeMI, EmployeeStreetAddress, EmployeeCity, EmployeeState, EmployeeZip, Payroll, Salary, EmpOrgCode, EmployeeDepartment, EmployeeDateCreated, EmployeeStatus
                            from dbo.Employee;";

            return SQLDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
