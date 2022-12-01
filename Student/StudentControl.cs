using Schuelerbewertung.Data;
using Schuelerbewertung.Database;
using Schuelerbewertung.Student;
using Schuelerbewertung.Tables;
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
        public event EventHandler RatingSubmitted;
        public event EventHandler NoGroupAssigned;
        private string _username;
        private int _groupId;

        public StudentControl()
        {
            InitializeComponent();
            _studentInputFields = new List<StudentInput>();
            //InitStudents();
        }

        /// <summary>
        /// Generiert die Bewertungseingabe für jedes Gruppenmitglied
        /// </summary>
        /// <param name="sUsername">Nutzername des angemeldeten Nutzers</param>
        public void GenerateInputMask( string sUsername )
        {
            _username = sUsername;
            GroupTable group = new GroupTable( sUsername );
            if ( group.HasResults )
            {
                _groupId = group.GroupID;
                foreach (StudentData groupMember in group.GroupMembers)
                {
                    if (groupMember != null)
                    {
                        StudentInput si = new StudentInput(groupMember);
                        _studentInputFields.Add(si);
                    }
                }
                flpStudentDisplay.Controls.AddRange(_studentInputFields.ToArray());
            }
            else
            {
                NoGroupAssigned?.Invoke( null, null );
            }
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
                sQuery = $"INSERT INTO bewertungen ( gruppenid, bewerter, schuelerid, {String.Join( ',', categories )}) VALUES ( {_groupId}, (SELECT SchuelerID FROM schueler WHERE nutzername='{_username}'), {studentRating.StudentId}, {String.Join( ',', values )})";
                con.ExecuteNoReturn(sQuery);
                categories.Clear();
                values.Clear();
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
            RatingSubmitted?.Invoke( sender, e );
        }
    }
}
