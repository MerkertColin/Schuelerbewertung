using Schuelerbewertung.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung.Student
{
    public partial class StudentSubmittedRatingControl : UserControl
    {
        public event EventHandler HasNoRating;
        public StudentSubmittedRatingControl()
        {
            InitializeComponent();
        }

        public void ShowRatings( string sUsername )
        {
            RatingTable rt = new RatingTable( sUsername );
            dgvSubmittedRatings.DataSource = rt;
            if ( !rt.HasResults )
            {
                HasNoRating?.Invoke(null, null);
            }
        }
    }
}
