using Schuelerbewertung.Data;
using Schuelerbewertung.Database;
using Schuelerbewertung.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung
{
    public partial class StudentControl : UserControl
    {
        private List<StudentInput> _studentInputFields;
        public StudentControl()
        {
            InitializeComponent();
            _studentInputFields = new List<StudentInput>();
            InitStudents();
        }

        /// <summary>
        /// [TEST] Mehtode zum testweise Erstellen von StudenInputs
        /// </summary>
        private void InitStudents()
        {
            string[] students = new string[]
            {
                "Friedrich",
                "Johann",
                "Jürgen",
                "Sabine"
            };

            for (int i = 0; i < 4; i++)
            {
                StudentInput si = new StudentInput( i + 1, students[i] );
                _studentInputFields.Add( si );
            }
            flpStudentDisplay.Controls.AddRange( _studentInputFields.ToArray() );
        }

        /// <summary>
        /// Schreibt die erhaltenen Daten mittels Insert in die Datenbank
        /// </summary>
        private void InsertRatingsIntoDatabase( List<StudentRating> ratings )
        {
            DbConnection con = DbConnection.GetInstance();
            List<string> categories = new List<string>();
            List<string> values = new List<string>();
            string sQuery = "";
            foreach ( StudentRating studentRating in ratings )
            {
                foreach ( CategoryRating categoryRating in studentRating.Categories )
                {
                    categories.Add(categoryRating.CategoryName);
                    values.Add(categoryRating.Value.ToString());
                }
                sQuery = $"INSERT INTO bewertungen ( bewerter, {String.Join( ',', categories )}) VALUES ({String.Join( ',', values )})";
                con.ExecuteNoReturn(sQuery);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<StudentRating> ratings = new List<StudentRating>();
            foreach( StudentInput si in _studentInputFields )
            {
                ratings.Add( si.GetRating() );
            }

            InsertRatingsIntoDatabase( ratings );
            //Daten in Datenbank einpflegen
        }
    }
}
