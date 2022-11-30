using System;
using System.Collections.Generic;
using System.Text;

namespace Schuelerbewertung.Data
{
    public class CategoryRating
    {
        public string CategoryName { get; private set; }
        public int Value { get; private set; }

        public CategoryRating( string sName, int sValue )
        {
            CategoryName = sName;
            Value = sValue;
        }
    }
}
