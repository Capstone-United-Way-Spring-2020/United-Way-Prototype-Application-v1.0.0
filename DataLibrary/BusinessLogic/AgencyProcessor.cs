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
    public class AgencyProcessor
    {
        public static int CreateAgency(int agencyID, string agencyName, bool agencyStatus, DateTime agencyDateCreated, DateTime agencyDateLastEdited)
        {
            AgencyModel data = new AgencyModel
            {
                AgencyID = agencyID,
                AgencyName = agencyName,
                AgencyStatus = agencyStatus,
                AgencyDateCreated = agencyDateCreated,
                AgencyDateLastEdited = agencyDateLastEdited
            };

            //sql for sending data to the database from the values above
            string sql = @"INSERT INTO Agency (agencyid, agencyname, agencystatus, agencydatecreated, agencydatelastedited)
                        VALUES (@AgencyID, @AgencyName, @AgencyStatus, @AgencyDateCreated, @AgencyDateLastEdited);";

            return SQLDataAccess.SaveData(sql, data);
        }

        //code for pulling the data from the agency table in the UW database
        public static List<AgencyModel> LoadAgencies()
        {
            string sql = @"SELECT agencyid, agencyname, agencystatus, agencydatecreated, agencydatelastedited 
                            FROM Agency;";

            return SQLDataAccess.LoadData<AgencyModel>(sql);
        }

        public static int EditAgency(int agencyID, string agencyName, bool agencyStatus, DateTime agencyDateCreated, DateTime agencyDateLastEdited)
        {
            AgencyModel data = new AgencyModel
            {
                AgencyID = agencyID,
                AgencyName = agencyName,
                AgencyStatus = agencyStatus,
                AgencyDateCreated = agencyDateCreated,
                AgencyDateLastEdited = agencyDateLastEdited
            };


            string sql = @"UPDATE Agency
                            SET agencyid = @AgencyID, agencyname = @AgencyName, agencystatus = @AgencyStatus, agencydatecreated = @AgencyDateCreated, 
                            agencydatelastedited = @AgencyDateLastEdited
                            WHERE agencyid = @AgencyID;";

            return SQLDataAccess.SaveData(sql, data);
        }


    }
}
