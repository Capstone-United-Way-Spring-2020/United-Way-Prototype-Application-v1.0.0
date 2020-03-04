using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ContributionModel
    //this is a front end, user interface model and is different from the data access model
    //dont want to decorate these models, not needed (name, requirements, error messages etc)
    //DATABASE doesnt care about modifiers, only the properties themselves
    {
        public int ContributionID { get; set; }
        public int CWID { get; set; }
        public string CFirstName { get; set; }
        public string CLastName { get; set; }
        public int AgencyID { get; set; }
        public string UWType { get; set; }
        public double UWMonthly { get; set; }
        public int UWMonths { get; set; }
        public int CheckNumber { get; set; }
        public int ContributionAmount { get; set; }
        public int UWYear { get; set; }
        public DateTime UWDateCreated { get; set; } = DateTime.Now;
        public DateTime UWDateLastEdited { get; set; }
    }
}
