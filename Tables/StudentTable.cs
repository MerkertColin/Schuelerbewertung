using Schuelerbewertung.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Schuelerbewertung.Tables
{
    public class StudentTable : DataTable
    {
        public string Id { get => (string)this.Rows[0].ItemArray[0]; }
        public string LastName { get => (string)this.Rows[0].ItemArray[1]; }
        public string FirstName { get => (string)this.Rows[0].ItemArray[2]; }
        public string Class { get => (string)this.Rows[0].ItemArray[3]; }
        public string Username { get => (string)this.Rows[0].ItemArray[4]; }
        public StudentTable( string sStudentUsername )
        {
            Init( sStudentUsername );
        }

        private void Init( string sUsername )
        {
            DbConnection con = DbConnection.GetInstance();
            string sQuery = $"SELECT * FROM schueler WHERE nutzername={"'friedrich_leichenberg'"}";
            this.Load( con.CreateReader( sQuery ) );
        }
    }
}
