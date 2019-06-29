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
    public class Activity_Service
    {
        Activiteit_DAO activity_db = new Activiteit_DAO();

        public List<Activity> GetActivities()
        {
            try
            {
                List<Activity> activities = activity_db.Db_Get_All_Activities();
                return activities;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Activity> activities = new List<Activity>();
                Activity a = new Activity();
                a.countStudents = 10;
                a.countMentors = 10;
                a.Description = "Test activity 01";
                a.Id = 10;
                activities.Add(a);
                Activity b = new Activity();
                b.countStudents = 20;
                b.countMentors = 20;
                b.Description = "Test activity 02";
                b.Id = 20;
                activities.Add(b);
                return activities;
                //throw new Exception("Someren couldn't connect to the database");
            }
        }

        public void UpdateActivity(Activity activity)
        {
            activity_db.UpdateActivity(activity);
        }

        public void DeleteActivity(int id)
        {
            activity_db.DeleteActivity(id);
        }

        public void AddActivity(Activity activity)
        {
            activity_db.AddActivity(activity);
        }
    }
}