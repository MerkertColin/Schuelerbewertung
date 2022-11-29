using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung.Student
{
    public partial class StudentInput : UserControl
    {
        public StudentInput()
        {
            InitializeComponent();
            InitCategories();
        }
        
        public StudentInput( string sName )
        {
            lbStudentName.Text = sName;
        }

        private void InitCategories()
        {
            for (int i = 0; i < 7; i++)
            {
                CriteriaSliderControl csc = new CriteriaSliderControl();
                flpCriteriaDisplay.Controls.Add( csc );
            }
        }
    }
}
