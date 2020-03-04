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
        public static int CreateContribution(int contributionID, string UWType, double UWMonthly, int UWMonths, double ContributionAmount, int UWYear, int CWID, int AgencyID, string CFirstName, string CLastName, int CheckNumber, DateTime UWDateCreated, DateTime UWDateLastEdited)
        {
            ContributionModel data = new ContributionModel
            {
                ContributionID = contributionID,
                UWType = UWType,
                UWMonthly = UWMonthly,
                UWMonths = UWMonths,
                ContributionAmount = ContributionAmount,
                UWYear = UWYear,
                CWID = CWID,
                AgencyID = AgencyID,
                CFirstName = CFirstName,
                CLastName = CLastName,
                CheckNumber = CheckNumber,
                UWDateCreated = UWDateCreated,
                UWDateLastEdited = UWDateLastEdited
            };

            //sql for sending data to the database from the values above
            string sql = @"INSERT INTO Contribution (contributionid, uwtype, uwmonthly, uwmonths, uwcontributionamount, uwyear, cwid, agencyid, contributionfname, contributionlname, checknumber, uwdatecreated, uwdateedited)
                        VALUES (@ContributionID, @UWType, @UWMonthly, @UWMonths, @ContributionAmount, @UWYear, @CWID, @AgencyID, @CFirstName, @CLastName, @CheckNumber, @UWDateCreated, @UWDateLastEdited);";

            return SQLDataAccess.SaveData(sql, data);
        }

        //code for pulling the data from the agency table in the UW database
        public static List<ContributionModel> LoadContributions()
        {
            string sql = @"SELECT contributionid, uwtype, uwmonthly, uwmonths, uwcontributionamount, uwyear, cwid, agencyid, contributionfname, contributionlname, checknumber, uwdatecreated, uwdateedited
                            FROM Contribution;";

            return SQLDataAccess.LoadData<ContributionModel>(sql);
        }




    }
}
