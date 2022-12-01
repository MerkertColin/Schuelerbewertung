using Schuelerbewertung.Database;
using Schuelerbewertung.EvArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schuelerbewertung
{
    public partial class Form1 : Form
    {
        private string _loggedInUser;
        DbConnection con;
        public Form1()
        {
            InitializeComponent();
            con = DbConnection.GetInstance();
            _loggedInUser = "";
            HideAllControls();
            loginView.Visible = true;
            loginView.LoginSuccessful += OnSuccessfulLogin;
            studentRatingView.RatingSubmitted += OnRatingSubmitted;
            studentRatingView.NoGroupAssigned += OnNoGroupAssigned;
            submittedRatingView.HasNoRating += OnHasNoRating;
        }
        
        private void HideAllControls()
        {
            foreach ( Control control in this.Controls )
            {
                control.Visible = false;
            }
        }

        private void OnSuccessfulLogin( object sender, LoginSuccessfulEventArgs e )
        {
            _loggedInUser = e.Username;

            if ( con.IsStudent( _loggedInUser ) )
            {
                if ( con.HasRated( _loggedInUser ) )
                {
                    ShowSubmittedRatingView( _loggedInUser );
                }
                else
                {
                    ShowStudentRatingView( _loggedInUser );
                }
            }
            else
            {
                ShowNoStudentView();
            }
        }

        private void ShowStudentRatingView( string sUsername )
        {
            HideAllControls();
            studentRatingView.Visible = true;
            studentRatingView.GenerateInputMask( sUsername );
        }

        private void ShowSubmittedRatingView( string sUsername )
        {
            HideAllControls();
            submittedRatingView.Visible = true;
            submittedRatingView.ShowRatings( sUsername );
        }

        private void ShowNoStudentView()
        {
            HideAllControls();
            noStudentView.Visible = true;
        }

        private void OnRatingSubmitted( object sender, EventArgs e )
        {
            ShowSubmittedRatingView( _loggedInUser );
        }

        private void OnNoGroupAssigned( object sender, EventArgs e )
        {
            ShowNowGroupAssignedView();
        }

        private void ShowNowGroupAssignedView()
        {
            HideAllControls();
            noGroupAssignedControl1.Visible = true;
        }

        private void OnHasNoRating( object sender, EventArgs e )
        {
            HideAllControls();
            ShowStudentRatingView( _loggedInUser );
        }
    }
}
