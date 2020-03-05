using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class DepartmentProcessor
    {
        //process the information/data, statement for sending that data to sql database
        public static int CreateDepartment(int orgCode, string departmentName, string uwCoordinator3, string uwCoordinator2, string uwCoordinator1, 
            string diVision, bool departmentStatus, DateTime departmentDateCreated, DateTime departmentLastEdited)
        {
            DepartmentModel data = new DepartmentModel
            {
                OrgCode = orgCode,
                departmentname = departmentName,
                UWCoordinator3 = uwCoordinator3,
                UWCoordinator2 = uwCoordinator2,
                UWCoordinator1 = uwCoordinator1,
                Division = diVision,
                DepartmentDateCreated = departmentDateCreated,
                DepartmentLastEdited = departmentLastEdited,
                DepartmentStatus = departmentStatus
            };

            //sending data TO the database, paramterized sql, @ = variable
            string sql = @"INSERT INTO Department (orgcode, departmentname, uwcoordinator3, uwcoordinator2, uwcoordinator1, division, departmentdatecreated, departmentlastedited, departmentstatus)
                            VALUES (@OrgCode, @departmentname, @UWCoordinator3, @UWCoordinator2, @UWCoordinator1, @Division, @DepartmentDateCreated, @DepartmentLastEdited, @DepartmentStatus);";


            return SQLDataAccess.SaveData(sql, data);
        }

        //code for pulling data FROM the database, LOADS all departments m
        public static List<DepartmentModel> LoadDepartments()
        {
            string sql = @"SELECT orgcode, departmentname, division, uwcoordinator3, uwcoordinator2, uwcoordinator1, departmentstatus, departmentdatecreated, departmentlastedited
                            FROM Department;";

            return SQLDataAccess.LoadData<DepartmentModel>(sql);
        }
    }
}
