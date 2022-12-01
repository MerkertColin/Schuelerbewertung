using Schuelerbewertung.Data;
using Schuelerbewertung.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Schuelerbewertung.Tables
{
    public class GroupTable : DataTable
    {
        public List<StudentData> GroupMembers { get => GetGroupMembers(); }
        public int GroupID { get => GetGroupId(); }
        public bool HasResults { get => this.Rows.Count > 0; }
        public GroupTable( string sUsername )
        {
            DbConnection con = DbConnection.GetInstance();
            string sQuery = @$"SELECT
                            g.GruppenID, 
                            g.ProjektID, 
                            g.Gruppenname, 
                            userid,
                            g.sch1 as id1,
                            CONCAT(s1.vorname, ' ', s1.name) AS name1,
                            g.sch2 as id2,
                            CONCAT(s2.vorname, ' ', s2.name) AS name2,
                            g.sch3 as id3,                            
                            CONCAT(s3.vorname, ' ', s3.name) AS name3,
                            g.sch4 as id4,                                                        
                            CONCAT(s4.vorname, ' ', s4.name) AS name4,
                            g.sch5 as id5,
                            CONCAT(s5.vorname, ' ', s5.name) AS name5
                            from gruppen AS g
                            LEFT JOIN schueler AS s1 ON g.sch1=s1.schuelerid
                            LEFT JOIN schueler AS s2 ON g.sch2=s2.schuelerid
                            LEFT JOIN schueler AS s3 ON g.sch3=s3.schuelerid
                            LEFT JOIN schueler AS s4 ON g.sch4=s4.schuelerid
                            LEFT JOIN schueler AS s5 ON g.sch5=s5.schuelerid
                            CROSS JOIN ( SELECT SchuelerID as userid FROM schueler WHERE nutzername='{sUsername}' ) q
                            where (g.sch1=userid OR g.sch2=userid OR g.sch3=userid OR g.Sch4=userid OR g.sch5=userid)
                            AND g.projektid=(SELECT max(projektid) FROM projekte WHERE erstelldatum=(SELECT MAX(erstelldatum) FROM projekte))";
            this.Load( con.CreateReader( sQuery ) );
        }

        private List<StudentData> GetGroupMembers()
        {
            object id1 = Rows[0].Field<object>("id1");
            object id2 = Rows[0].Field<object>("id2");
            object id3 = Rows[0].Field<object>("id3");
            object id4 = Rows[0].Field<object>("id4");
            object id5 = Rows[0].Field<object>("id5");
            List<StudentData> groupMembers = new List<StudentData>()
            {
                id1 != null ? new StudentData( id1.ToString(), this.Rows[0].Field<string>( "name1" ) ) : null,
                id2 != null ? new StudentData( id2.ToString(), this.Rows[0].Field<string>( "name2" ) ) : null,
                id3 != null ? new StudentData( id3.ToString(), this.Rows[0].Field<string>( "name3" ) ) : null,
                id4 != null ? new StudentData( id4.ToString(), this.Rows[0].Field<string>( "name4" ) ) : null,
                id5 != null ? new StudentData( id5.ToString(), this.Rows[0].Field<string>( "name5" ) ) : null
            };

            return groupMembers;
        }

        private int GetGroupId()
        {
            int nId;
            object idField;
            idField = Rows[0].Field<object>( "gruppenid" );
            nId = idField != null ? (int)idField : -1;
            return nId;
        }
    }
}
