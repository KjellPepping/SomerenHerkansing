using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Activiteit_DAO : Base
    {

        public List<Activity> Db_Get_All_Activities()
        {
            string query = "SELECT aantalStudenten, aantalBegeleiders, Omschrijving, ID FROM Activiteiten";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> Activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                   countStudents = (int)dr["aantalStudenten"],
                   countMentors = (int)dr["aantalBegeleiders"],
                   Description = (string)dr["Omschrijving"],
                   Id = (int)dr["ID"]
                };
                Activities.Add(activity);
            }
            return Activities;
        }

    }
}