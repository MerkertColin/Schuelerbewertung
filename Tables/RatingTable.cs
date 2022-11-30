using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Schuelerbewertung.Tables
{
    class RatingTable : DataTable
    {
        
        public string[] Students { get => GetStudents(); }

        private string[] GetStudents()
        {
            string[] students = new string[this.Rows.Count];

            for (int i = 0; i < this.Rows.Count; i++)
            {
                students[i] = this.Rows[i].Field<string>("vorname");
            }
            return students;
        }

    }
}
