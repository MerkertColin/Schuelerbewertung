using System;
using System.Collections.Generic;
using System.Text;

namespace Schuelerbewertung.Student
{
    class Project
    {
        public string Name { get; }
        public string[] Students { get; }

        public Project( string sName )
        {
            Name = sName;
            Students = new string[]
            {
                "Niklas",
                "Colin",
                "Udo",
                "Robin"
            };
        }


    }
}
