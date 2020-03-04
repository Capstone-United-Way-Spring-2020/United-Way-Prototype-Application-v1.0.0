using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    //process the information/data, statements for sending data to and from sql database
    public class ContributionProcessor
    {
        public static int CreateContribution(int contributionID, int CWID, string CFirstName, string CLastName, int AgencyID, string UWType, double UWMonthly, int UWMonths, int CheckNumber, double ContributionAmount, int UWYear, DateTime UWDateCreated, DateTime UWDateLastEdited)
        {
            ContributionModel data = new ContributionModel
            {
                ContributionID = contributionID,
                CWID = CWID,
                CFirstName = CFirstName,
                CLastName = CLastName,
                AgencyID = AgencyID,
                UWType = UWType,
                UWMonthly = UWMonthly,
                UWMonths = UWMonths,
                CheckNumber = CheckNumber,
                ContributionAmount = ContributionAmount,
                UWYear = UWYear,
                UWDateCreated = UWDateCreated,
                UWDateLastEdited = UWDateLastEdited
            };

            //sql for sending data to the database from the values above
            string sql = @"INSERT INTO Contribution (contributionid, cwid, contributionfname, contributionlname, agencyid, uwtype, uwmonthly, uwmonths, checknumber, checkamount, uwyear, uwdatecreated, uwdateedited)
                        VALUES (@cID, @cwid, @cFName, @cLName, @agencyID, @uwType, @uwMonthly, @uwMonths, @chNumber, @cAmount, @uwYear, @uwDCreated, @uwDLEdited);";

            return SQLDataAccess.SaveData(sql, data);
        }

        //code for pulling the data from the agency table in the UW database
        public static List<ContributionModel> LoadContributions()
        {
            string sql = @"SELECT contributionid, cwid, contributionfname, contributionlname, agencyid, uwtype, uwmonthly, uwmonths, checknumber, checkamount, uwyear, uwdatecreated, uwdateedited 
                            FROM Agency;";

            return SQLDataAccess.LoadData<ContributionModel>(sql);
        }




    }
}
