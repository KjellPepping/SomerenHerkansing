using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Configuration;

namespace SomerenDAL
{
    public class Activiteit_DAO : Base
    {
        private SqlConnection dbConnection;

        public Activiteit_DAO()
        {
            string connstring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            dbConnection = new SqlConnection(connstring);
        }

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

        public void UpdateActivity(Activity activity)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Activiteiten SET aantalStudenten = @aantalStudenten, aantalBegeleiders = @aantalBegeleiders, Omschrijving = @Omschrijving WHERE ID = @ID", dbConnection);
            command.Parameters.AddWithValue("@aantalStudenten", activity.countStudents);
            command.Parameters.AddWithValue("@aantalBegeleiders",activity.countMentors);
            command.Parameters.AddWithValue("@Omschrijving", activity.Description);
            command.Parameters.AddWithValue("@ID",activity.Id);
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

        public void DeleteActivity(int ActivityID)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Activiteiten WHERE ID = @ID", dbConnection);
            command.Parameters.AddWithValue("@ID", ActivityID);
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

        public void AddActivity(Activity activity)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Activiteiten ( aantalStudenten, aantalBegeleiders, Omschrijving, ID ) VALUES ( @aantalstudenten, @aantalBegeleiders, @Omschrijving, @ID)",dbConnection);
            command.Parameters.AddWithValue("@aantalStudenten", activity.countStudents);
            command.Parameters.AddWithValue("@aantalBegeleiders", activity.countMentors);
            command.Parameters.AddWithValue("@Omschrijving", activity.Description);
            command.Parameters.AddWithValue("@ID", activity.Id);
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

    }
}