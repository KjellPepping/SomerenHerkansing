﻿using SomerenDAL;
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
                throw new Exception("Someren couldn't connect to the database");
            }

        }

        public void UpdateDrink(Drink drink)
        {
            drink_db.UpdateDrink(drink);
        }

        public void AddDrink(Drink drink)
        {
            drink_db.AddDrink(drink);
        }


        public void DeleteDrink(string drinkName)
        {
            drink_db.DeleteDrink(drinkName);
        }
    }
}
