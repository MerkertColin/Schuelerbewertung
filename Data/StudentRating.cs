using System;
using System.Collections.Generic;
using System.Text;

namespace Schuelerbewertung.Data
{
    public class StudentRating
    {
        public string StudentName { get; private set; }
        public string StudentId { get; private set; }
        public List<CategoryRating> Categories { get; private set; }

        public StudentRating( string sId, string sName, List<CategoryRating> categories )
        {
            StudentName = sName;
            StudentId = sId;
            Categories = categories;
        }
    }
}
