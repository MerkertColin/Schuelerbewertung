using Schuelerbewertung.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Schuelerbewertung.Tables
{
    public class ProjectTable : DataTable
    {

        public ProjectTable( int nStudentId )
        {
            Init( nStudentId );
        }

        private void Init( int nStudentId )
        {
            string sQuery = $"SELECT * FROM gruppen AS g JOIN projekte AS p ON g.ProjektId=p.ProjektId WHERE g.sch1={nStudentId} OR g.sch2={nStudentId} OR g.sch3={nStudentId} OR g.sch4={nStudentId} OR g.Sch5={nStudentId} ORDER BY p.Erstelldatum;";
            DbConnection con = DbConnection.GetInstance();
            this.Load( con.CreateReader( sQuery ) );
        }

    }
}
