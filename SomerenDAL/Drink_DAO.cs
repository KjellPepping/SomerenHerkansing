﻿using System;
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
    public class Drink_DAO : Base
    {
        private SqlConnection dbConnection;

        public Drink_DAO()
        {
            string connstring = ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString;
            dbConnection = new SqlConnection(connstring);
        }

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

        public void UpdateDrink(Drink drink)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("UPDATE Drankjes SET Naam = @Naam, Verkoopprijs = @Verkoopprijs, Voorraad = @Voorraad  WHERE Id = @Id", dbConnection);
            command.Parameters.AddWithValue("@Naam",drink.Name);
            command.Parameters.AddWithValue("@Verkoopprijs",drink.Price);
            command.Parameters.AddWithValue("@Voorraad",drink.Supply);
            command.Parameters.AddWithValue("@Id",drink.Id);
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

        public void DeleteDrink(string drinkName)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Drankjes WHERE CONVERT(VARCHAR,Naam) = @Naam",dbConnection);
            command.Parameters.AddWithValue("@Naam", drinkName.ToString());
            SqlDataReader reader = command.ExecuteReader();
            dbConnection.Close();
        }

    }
}