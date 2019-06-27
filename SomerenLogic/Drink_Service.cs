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
    public class Drink_Service
    {
        Drink_DAO drink_db = new Drink_DAO();

        public List<Drink> GetDrinks()
        {
            try
            {
                List<Drink> Drinks = drink_db.Db_Get_All_Drinks();
                return Drinks;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Drink> Drinks = new List<Drink>();
                Drink a = new Drink();
                a.name = "TestDrink01";
                a.price = 10.0;
                a.alcoholPercent = 10.0;
                a.revenue = 10.0;
                a.supply = 10;
                a.id = 10;
                Drinks.Add(a);
                Drink b = new Drink();
                a.name = "TestDrink02";
                a.price = 20.0;
                a.alcoholPercent = 20.0;
                a.revenue = 20.0;
                a.supply = 20;
                a.id = 20;
                Drinks.Add(b);
                return Drinks;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
