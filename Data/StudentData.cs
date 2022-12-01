using System;
using System.Collections.Generic;
using System.Text;

namespace Schuelerbewertung.Data
{
    public class StudentData
    {
        public string Name;
        public string ID;

        public StudentData( string sId, string sName )
        {
            this.Name = sName;
            this.ID = sId;
        }
    }
}
