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
            string query = "SELECT Naam, Verkoopprijs, Alcohol, Omzet, Voorraad, ID FROM Drankjes";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> Drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Name = (String)(dr["Naam"].ToString()),
                    Price = (decimal)dr["Verkoopprijs"],
                    AlcoholPercent = (decimal)dr["Alcohol"],
                    Revenue = (decimal)dr["Omzet"],
                    Supply = (int)dr["Voorraad"],
                    Id = (int)dr["ID"]
                };
                Drinks.Add(drink);
            }
            return Drinks;
        }

    }
}