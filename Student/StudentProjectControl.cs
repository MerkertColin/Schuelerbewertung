using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Schuelerbewertung.Tables;

namespace Schuelerbewertung.Student
{
    public partial class StudentProjectControl : UserControl
    {
        public StudentProjectControl()
        {
            InitializeComponent();
        }

        public void Update( string sUsername )
        {
            ProjectTable studentTable = new ProjectTable( 1 );
            dgvRatings.DataSource = studentTable;
        }
        
    }
}
