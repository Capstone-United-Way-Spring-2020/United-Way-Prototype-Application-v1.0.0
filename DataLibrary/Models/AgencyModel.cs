using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    //this is a front end, user interface model and is different from the data access model
    //dont want to decorate these models, not needed (name, requirements, error messages etc)
    //DATABASE DOESNT CARE about modifiers, only the properties themselves (below)
    public class AgencyModel
    {
        public int AgencyID { get; set; }

        public string AgencyName { get; set; }

        public bool AgencyStatus { get; set; } = true;

        public DateTime AgencyDateCreated { get; set; } = DateTime.Now;

        public DateTime AgencyDateLastEdited { get; set; }
    }
}
