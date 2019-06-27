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
    public class Drink_DAO : Base
    {

        public List<Drink> Db_Get_All_Drinks()
        {
            string query = "SELECT Naam, Verkoopprijs,Alcohol,Omzet,Voorraad,ID FROM Drankjes WHERE Naam NOT IN ('Water', 'Sinas', 'Kersensap')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink();
                {
                    drink.name = (String)(dr["Naam"].ToString());
                    drink.price = (double)dr["Verkoopprijs"];
                    drink.alcoholPercent = (double)dr["Alcohol"];
                    drink.revenue = (double)dr["Omzet"];
                    drink.supply = (int)dr["Voorraad"];
                    drink.id = (int)dr["ID"];
                };
                drinks.Add(drink);
            }
            return drinks;
        }

    }
}