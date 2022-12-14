using Schuelerbewertung.Data;
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
        private List<CriteriaSliderControl> _criteriaSlider;
        public string StudentName { get => lbStudentName.Text; }
        private StudentData _student;

        public StudentInput()
        {
            InitializeComponent();
            _criteriaSlider = new List<CriteriaSliderControl>();
            InitCategories();
        }
        
        public StudentInput( StudentData student )
        {
            InitializeComponent();
            _student = student;
            lbStudentName.Text = _student.Name;
            _criteriaSlider = new List<CriteriaSliderControl>();
            InitCategories();
        }

        private void InitCategories()
        {
            for (int i = 0; i < 7; i++)
            {
                CriteriaSliderControl csc = new CriteriaSliderControl( $"Kat{i+1}");
                _criteriaSlider.Add( csc );
            }
            flpCriteriaDisplay.Controls.AddRange( _criteriaSlider.ToArray() );
        }

        public StudentRating GetRating()
        {
            StudentRating res;
            List<CategoryRating> categoryRatings = new List<CategoryRating>();
            foreach ( CriteriaSliderControl csc in _criteriaSlider )
            {
                categoryRatings.Add( new CategoryRating( csc.CategoryName, csc.SliderValue ) );
            }
            res = new StudentRating( _student.ID, _student.Name, categoryRatings );
            return res;
        }
    }
}
