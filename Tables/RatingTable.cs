using Schuelerbewertung.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Schuelerbewertung.Tables
{
    class RatingTable : DataTable
    {
        
        public string[] Students { get => GetStudents(); }
        public bool HasResults { get => this.Rows.Count > 0; }

        public RatingTable( string sUsername )
        {
            Init( sUsername );
        }

        private void Init( string sUsername )
        {
            DbConnection con = DbConnection.GetInstance();
            string sQuery = @$"SELECT b.Bewerter, CONCAT(s2.Vorname, ' ', s2.Name) as vorname, b.GruppenID, p.ProjektID, b.Kat1, b.Kat2, b.Kat3, b.Kat4, b.Kat5, b.Kat6, b.Kat7
FROM Schueler s
JOIN Bewertungen as b on b.Bewerter = s.SchuelerID
join gruppen as g on g.GruppenID = b.GruppenID
JOIN projekte as p on p.ProjektID = g.ProjektID
JOIN schueler as s2 on s2.SchuelerID = b.SchuelerID
Where s.Nutzername = 'alina_schwansee'
AnD p.erstelldatum = (select MAX(p.Erstelldatum)
                   from projekte)";
            this.Load( con.CreateReader( sQuery ) );
        }

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
