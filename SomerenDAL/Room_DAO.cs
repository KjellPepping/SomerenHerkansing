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
    public class Room_DAO : Base
    {
        private SqlConnection dbConnection;

        public Room_DAO()
        {
            string connstring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            dbConnection = new SqlConnection(connstring);
        }

        public List<Room> Db_Get_All_Rooms()
        {
            string query = "SELECT Kamernummer, Slaapplekken, Type FROM Kamer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> Rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room Room = new Room()
                {
                   Number = (int)dr["Kamernummer"],
                   Capacity = (int)dr["Slaapplekken"],
                   Type = (string)dr["Type"]
                };
                Rooms.Add(Room);
            }
            return Rooms;
        }

        public void UpdateRoom(Room Room)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Kamer SET Kamernummer = @Kamernummer , Slaapplekken = @Slaapplekken , Type = @Type WHERE Kamernummer = @Kamernummer", dbConnection);
            command.Parameters.AddWithValue("@Kamernummer", Room.Number);
            command.Parameters.AddWithValue("@Slaapplekken",Room.Capacity);
            command.Parameters.AddWithValue("@Type", Room.Type);            
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

        public void DeleteRoom(int RoomID)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Kamer WHERE Kamernummer = @Kamernummer", dbConnection);
            command.Parameters.AddWithValue("@ID", RoomID);
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

        public void AddRoom(Room Room)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Kamer ( Kamernummer, Slaapplekken, Type ) VALUES ( @Kamernummer, @Slaapplekken, @Type)", dbConnection);
            command.Parameters.AddWithValue("@Kamernummer", Room.Number);
            command.Parameters.AddWithValue("@Slaapplekken", Room.Capacity);
            command.Parameters.AddWithValue("@Type", Room.Type);
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

    }
}