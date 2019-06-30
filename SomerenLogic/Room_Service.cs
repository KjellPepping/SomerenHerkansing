using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Room_Service
    {
        Room_DAO room_db = new Room_DAO();

        public List<Room> Getrooms()
        {
            try
            {
                List<Room> rooms = room_db.Db_Get_All_Rooms();
                return rooms;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }

        public void UpdateRoom(Room Room)
        {
            room_db.UpdateRoom(Room);
        }

        public void DeleteRoom(int id)
        {
            room_db.DeleteRoom(id);
        }

        public void AddRoom(Room Room)
        {
            room_db.AddRoom(Room);
        }
    }
}