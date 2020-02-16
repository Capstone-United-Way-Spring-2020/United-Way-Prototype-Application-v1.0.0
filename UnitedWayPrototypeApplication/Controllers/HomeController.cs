using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult Employee()
        {
            ViewBag.Message = "Employee Overview";

            List<Models.EmployeeModel> employees = new List<Models.EmployeeModel>();

            employees.Add(new Models.EmployeeModel
            {
                CWID = 11708591,
                EmployeeCity = "Tuscaloosa",
                EmployeeDateCreated = new DateTime(2020, 2, 14),
                EmployeeMI = "T",
                EmployeeState = "AL",
                EmployeeStreetAddress = "238 Cedar Crest",
                EmployeeZip = 35401,
                FirstName = "Christian",
                LastName = "Golczynski",
                GivingYear = 2020,
                Payroll = "m",
                Salary = 900000,
                POBox = 85392,
                POBoxCity = "Tuscaloosa",
                POBoxState = "AL",
                EmpOrgCode = 10510,
                EmployeeDepartment = "President Office"
            });

            return View(employees);
        }

        public ActionResult EmployeeCreate()
        {
            ViewBag.Message = "Create new Employee";

            return View();
        }

        public ActionResult Agency()
        {
            ViewBag.Message = "Agency Overview";

            List<Models.AgencyModel> agencies = new List<Models.AgencyModel>();

            agencies.Add(new Models.AgencyModel { AgencyId = "001", AgencyName = "2-1-1/Information & Referral" });
            agencies.Add(new Models.AgencyModel { AgencyId = "002", AgencyName = "Alabama Head Injury Foundation" });
            agencies.Add(new Models.AgencyModel { AgencyId = "003", AgencyName = "American Red Cross" });
            agencies.Add(new Models.AgencyModel { AgencyId = "004", AgencyName = "Arts 'n Autism" });
            agencies.Add(new Models.AgencyModel { AgencyId = "005", AgencyName = "Big Brothers Big Sisters of West Alabama" });
            agencies.Add(new Models.AgencyModel { AgencyId = "006", AgencyName = "Black Warrior Council Boy Scouts" });
            agencies.Add(new Models.AgencyModel { AgencyId = "007", AgencyName = "Boys & Girls Clubs of West Alabama" });
            agencies.Add(new Models.AgencyModel { AgencyId = "008", AgencyName = "Caring Days Adult Day Care" });
            agencies.Add(new Models.AgencyModel { AgencyId = "009", AgencyName = "Child Abuse Prevention Services" });
            agencies.Add(new Models.AgencyModel { AgencyId = "010", AgencyName = "Easterseals West Alabama" });
            agencies.Add(new Models.AgencyModel { AgencyId = "011", AgencyName = "Family Counseling Service" });
            agencies.Add(new Models.AgencyModel { AgencyId = "012", AgencyName = "Five Horizons Health Services" });
            agencies.Add(new Models.AgencyModel { AgencyId = "013", AgencyName = "FOCUS on Senior Citizens" });
            agencies.Add(new Models.AgencyModel { AgencyId = "014", AgencyName = "Girl Scouts of North-Central Alabama" });
            agencies.Add(new Models.AgencyModel { AgencyId = "015", AgencyName = "Good Samaritan Clinic" });
            agencies.Add(new Models.AgencyModel { AgencyId = "016", AgencyName = "Hospice of West Alabama" });
            agencies.Add(new Models.AgencyModel { AgencyId = "017", AgencyName = "Phoenix House" });
            agencies.Add(new Models.AgencyModel { AgencyId = "018", AgencyName = "Sickle Cell Disease Association" });
            agencies.Add(new Models.AgencyModel { AgencyId = "019", AgencyName = "Success By 6" });
            agencies.Add(new Models.AgencyModel { AgencyId = "020", AgencyName = "Temporary Emergency Services" });
            agencies.Add(new Models.AgencyModel { AgencyId = "021", AgencyName = "The Arc of Tuscaloosa Country" });
            agencies.Add(new Models.AgencyModel { AgencyId = "022", AgencyName = "The Salvation Army" });
            agencies.Add(new Models.AgencyModel { AgencyId = "023", AgencyName = "Turning Point" });
            agencies.Add(new Models.AgencyModel { AgencyId = "024", AgencyName = "Tuscaloosa's One Place" });
            agencies.Add(new Models.AgencyModel { AgencyId = "025", AgencyName = "United Cerebral Palsy of West Alabama" });
            agencies.Add(new Models.AgencyModel { AgencyId = "026", AgencyName = "United Way of West Alabama" });
            agencies.Add(new Models.AgencyModel { AgencyId = "027", AgencyName = "YMCA" });

            return View(agencies);
        }

        public ActionResult CreateAgency()
        {
            ViewBag.Message = "Create new Agency";

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

        public ActionResult Department()
        {
            ViewBag.Message = "Department Overview";

            List<Models.DepartmentModel> departments = new List<Models.DepartmentModel>();

            departments.Add(new Models.DepartmentModel
            {
                OrgCode = 10510,
                DepartmentDateCreated = new DateTime(2020, 2 / 14),
                Division = "President Office",
                UWCoordinator3 = "Beverly Baker",
                UWCoordinator2 = "Beverly Baker",
                UWCoordinator1 = "Beverly Baker",
                DepartmentLastEdited = new DateTime(2020, 2, 16)
            });

            return View(departments);
        }

        public ActionResult CreateDepartment()
        {
            ViewBag.Message = "Create new Department";

            return View();
        }
    }
}