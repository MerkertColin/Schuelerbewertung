using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GroupingAlgorithm
{
    public class Pupil
    {
        /// <summary>
        /// SchülerID
        /// </summary>
        public String Identifier;

        /// <summary>
        /// Besitzt schon Partner.
        /// </summary>
        public bool hasPartner = false;

        /// <summary>
        /// Werte der einzelnen Kategorien
        /// </summary>
        public List<double> Coordinates = new List<double>();


        public Pupil() { }
        public Pupil(DataRow row)
        {
            for (int i = 0; i < row.Table.Columns.Count; i++)
            {
                if (row.Table.Columns[i].ColumnName.ToUpper().Contains("SCHUELERID"))
                    Identifier = row[i].ToString();
                else if (row.Table.Columns[i].ColumnName.ToUpper().Contains("KAT")) {

                    if (row[i].GetType() == typeof(System.DBNull)) {
                        Coordinates.Add(0.0d);
                    } else {
                        Coordinates.Add(Decimal.ToDouble((decimal)row[i]));
                    }
                }
			}
        }
    }
}
