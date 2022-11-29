using Schuelerbewertung.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung
{
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
            InitStudents();
        }

        private void InitStudents()
        {
            for (int i = 0; i < 4; i++)
            {
                StudentInput si = new StudentInput();
                flpStudentDisplay.Controls.Add( si );
            }
        }
    }
}
