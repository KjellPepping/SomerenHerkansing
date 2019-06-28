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
                a.Name = "TestDrink01";
                a.Price = 10.0m;
                a.AlcoholPercent = 10.0m;
                a.Revenue = 10.0m;
                a.Supply = 10;
                a.Id = 10;
                Drinks.Add(a);
                Drink b = new Drink();
                a.Name = "TestDrink02";
                a.Price = 20.0m;
                a.AlcoholPercent = 20.0m;
                a.Revenue = 20.0m;
                a.Supply = 20;
                a.Id = 20;
                Drinks.Add(b);
                return Drinks;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }

        public void UpdateDrink(Drink drink)
        {
            drink_db.UpdateDrink(drink);
        }

        public void DeleteDrink(string drinkName)
        {
            drink_db.DeleteDrink(drinkName);
        }
    }
}
