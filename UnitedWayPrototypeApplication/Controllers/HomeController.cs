using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitedWayPrototypeApplication.Models;
using DataLibrary;
//use comments on code

namespace UnitedWayPrototypeApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //employee overview, the list of all employees in the system
        public ActionResult Employee()
        {
            ViewBag.Message = "Employee Overview";

            //using the SQL SELECT statements in EmployeeProcessor to LOAD the employees to a list
            var data = DataLibrary.BusinessLogic.EmployeeProcessor.LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();

            // creating new row for each record
            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    CWID = row.CWID,
                    EmployeeFirstName = row.EmployeeFirstName,
                    EmployeeLastName = row.EmployeeLastName,
                    EmployeeMI = row.EmployeeMI,
                    StreetAddress = row.StreetAddress,
                    EmployeeCity = row.EmployeeCity,
                    EmployeeState = row.EmployeeState,
                    EmployeeZip = row.EmployeeZip,
                    EmployeeDepartment = row.EmployeeDepartment,
                    OrgCode = row.OrgCode,
                    EmployeeStatus = row.EmployeeStatus,
                    EmployeeDateCreated = row.EmployeeDateCreated,
                    GivingYear = row.GivingYear,
                    Payroll = row.Payroll,
                    Salary = row.Salary,
                    POBox = row.POBox,
                    POBoxCity = row.POBoxCity,
                    POBoxState = row.POBoxState
                });
            }

            return View(employees); 
        }

        //form for creating an employee
        public ActionResult EmployeeCreate()
        {
            ViewBag.Message = "Create new Employee";

            return View();
        }
        //catching the information entered in the employee create form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmployeeCreate(EmployeeModel model)
        {
            //if the model (data) is valid, create the employee in the database using these parameters
            if (ModelState.IsValid)
            {
                DataLibrary.BusinessLogic.EmployeeProcessor.CreateEmployee(model.CWID, model.EmployeeFirstName, model.EmployeeLastName, model.EmployeeMI, model.StreetAddress, model.EmployeeCity, model.EmployeeState, model.EmployeeZip,
                    model.Payroll, model.Salary, model.POBox, model.POBoxCity, model.POBoxState, model.OrgCode, model.EmployeeDepartment, model.GivingYear, model.EmployeeStatus, model.EmployeeDateCreated);
                return RedirectToAction("Employee");
            }

            ViewBag.Message = "Create new Employee";

            return View();
        }

        public ActionResult Agency()
        {
            ViewBag.Message = "Agency Overview";
            //utilizing the SQL SELECT statements in AgencyProcessor to LOAD the agencies
            var data = DataLibrary.BusinessLogic.AgencyProcessor.LoadAgencies();

            //using the SQL SELECT statements in AgencyProcessor to LOAD the agencies to a list
            List<AgencyModel> agencies = new List<AgencyModel>();
            //create new row for each record
            foreach (var row in data)
            {
                agencies.Add(new AgencyModel
                {
                    AgencyID = row.AgencyID,
                    AgencyName = row.AgencyName,
                    AgencyStatus = row.AgencyStatus,
                    AgencyDateCreated = row.AgencyDateCreated,
                    AgencyDateLastEdited = row.AgencyDateLastEdited
                });
            }
            
            return View(agencies);
        }

        public ActionResult CreateAgency()
        {
            ViewBag.Message = "Create new Agency";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAgency(AgencyModel model)
        {
            ViewBag.Message = "Create new Agency";
            
            if (ModelState.IsValid)
            {
                DataLibrary.BusinessLogic.AgencyProcessor.CreateAgency(model.AgencyID, model.AgencyName, model.AgencyStatus, model.AgencyDateCreated, model.AgencyDateLastEdited);
                return RedirectToAction("Agency");
            }


            return View();
        }

        public ActionResult Contribution()
        {
            ViewBag.Message = "Contribution Overview";

            List<Models.ContributionModel> contributions = new List<Models.ContributionModel>();

            contributions.Add(new Models.ContributionModel
            {
                CWID = 11708591,
                AgencyID = 001,
                ContributionAmount = 120,
                ContributionID = 001,
                UWDateCreated = new DateTime(2020, 2, 14),
                UWType = "m",
                UWMonthly = 10,
                UWMonths = 12,
                UWYear = 2020,
                UWDateLastEdited = new DateTime(2020,2,16),
                CFirstName = "Christian",
                CLastName = "Golczynski"
            });

            return View(contributions);
        }

        public ActionResult CreateContribution()
        {
            ViewBag.Message = "Enter new Contribution";

            return View();
        }

        //department overview, shows all departments in a list
        public ActionResult Department()
        {
            ViewBag.Message = "Department Overview";

            //able to use that SQL SELECT statement from DepartmentProcessor, use for each to loop through all data
            var data = DataLibrary.BusinessLogic.DepartmentProcessor.LoadDepartments();
            List<DepartmentModel> departments = new List<DepartmentModel>();


            foreach (var row in data)
            {
                departments.Add(new DepartmentModel
                {
                    OrgCode = row.OrgCode,
                    departmentname = row.departmentname,
                    UWCoordinator3 = row.UWCoordinator3,
                    UWCoordinator2 = row.UWCoordinator2,
                    UWCoordinator1 = row.UWCoordinator1,
                    Division = row.Division,
                    DepartmentStatus = row.DepartmentStatus,
                    DepartmentDateCreated = row.DepartmentDateCreated,
                    DepartmentLastEdited = row.DepartmentLastEdited
                });
            }


            return View(departments);
        }

        //form for creating a new department
        public ActionResult CreateDepartment()
        {
            ViewBag.Message = "Create new Department";

            return View();
        }

        //catching the information from the create department form
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDepartment(DepartmentModel model)
        {
            //checking if the data sent from the form is valid 
            if (ModelState.IsValid)
            {
                DataLibrary.BusinessLogic.DepartmentProcessor.CreateDepartment(model.OrgCode, model.departmentname, model.UWCoordinator3, model.UWCoordinator2, model.UWCoordinator1, model.Division,
                    model.DepartmentStatus, model.DepartmentDateCreated, model.DepartmentLastEdited);
                return RedirectToAction("Department");
            }

            return View();
        }
        // Creates forms for editing department
        public ActionResult EditDepartment()
        {
            ViewBag.Message = "Edit Department";

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDepartment(DepartmentModel model)
        {
            if (ModelState.IsValid)
            {
                model.DepartmentLastEdited = DateTime.Now;
                DataLibrary.BusinessLogic.DepartmentProcessor.EditDepartment(model.OrgCode, model.departmentname, model.UWCoordinator3, model.UWCoordinator2, model.UWCoordinator1, model.Division,
                    model.DepartmentStatus, model.DepartmentDateCreated, model.DepartmentLastEdited);
                return RedirectToAction("Department");
            }
            return View();
        }



        /*
        // GET /Department/Edit
        public ActionResult EditDepartment(int orgCode)
        {
            var data = DataLibrary.BusinessLogic.DepartmentProcessor.LoadDepartments();
            DepartmentModel dept = new DepartmentModel();

            foreach (var row in data)
            {
                if (row.OrgCode == orgCode)
                {
                    dept.OrgCode = row.OrgCode;
                    dept.departmentname = row.departmentname;
                    dept.UWCoordinator3 = row.UWCoordinator3;
                    dept.UWCoordinator2 = row.UWCoordinator2;
                    dept.UWCoordinator1 = row.UWCoordinator1;
                    dept.Division = row.Division;
                    dept.DepartmentStatus = row.DepartmentStatus;
                    dept.DepartmentDateCreated = row.DepartmentDateCreated;
                    dept.DepartmentLastEdited = row.DepartmentLastEdited;
                    break;
                }
            }

            return View(dept);
        }
        
        // POST /Department/Edit
        [HttpPost]
        public ActionResult EditDepartment(DepartmentModel dept)
        {
            if (ModelState.IsValid)
            {
                DataLibrary.BusinessLogic.DepartmentProcessor.LoadDepartments().Entry(dept).State = EntityState.Modified;
                DataLibrary.BusinessLogic.DepartmentProcessor.LoadDepartments().SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dept);
        }*/
        
    }
}