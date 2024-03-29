﻿using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class Lecturer_DAO : Base
    {
        public List<Teacher> Db_Get_All_Lecturers()
        {
            string query = "SELECT Vak, NAAM, LEEFTIJD,  ID FROM TEACHER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Vak = (string)dr["Vak"],
                    Name = (String)(dr["Name"].ToString()),
                    Leeftijd = (int)(dr["Leeftijd"]),
                    Number = (int)(dr["Number"])
                };
                teachers.Add(teacher);
            }
            return teachers;
        }


    }
}
