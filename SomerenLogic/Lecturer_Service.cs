using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenLogic
{
   public class Lecturer_Service
    {
        Lecturer_DAO lecturer_db = new Lecturer_DAO();

        public List<Teacher> Get_All_lecturers()
        {
            try
            {
                List<Teacher> teacher = lecturer_db.Db_Get_All_Lecturers();
                return teacher;
            }
            catch (Exception)
            {
                List<Teacher> teachers = new List<Teacher>();
                Teacher t = new Teacher();
                t.Vak = "Engels";
                t.Name = "Patricia Leeuwenhart";
                t.Leeftijd = 43;
                t.Number = 23523;
                teachers.Add(t);
                return teachers;
            }

        }
    }
}
