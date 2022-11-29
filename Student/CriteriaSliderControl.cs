using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung.Student
{
    public partial class CriteriaSliderControl : UserControl
    {
        public CriteriaSliderControl()
        {
            InitializeComponent();
        }

        public CriteriaSliderControl( string sCriterium )
        {
            gbCategory.Text = sCriterium;
        }

        private void trbSlider_Scroll(object sender, EventArgs e)
        {
            nbNumberBox.Value = trbSlider.Value;
        }

        private void nbNumberBox_ValueChanged(object sender, EventArgs e)
        {
            trbSlider.Value = (int)nbNumberBox.Value;
        }
    }
}
