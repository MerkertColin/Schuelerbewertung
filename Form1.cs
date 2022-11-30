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

        public Form1()
        {
            InitializeComponent();
            _loggedInUser = "";
            HideAllControls();
            loginView.Visible = true;
            loginView.LoginSuccessful += OnSuccessfulLogin;
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
            HideAllControls();
            _loggedInUser = e.Username;
            studentProjectView.Visible = true;
            studentProjectView.Update( e.Username );
        }
    }
}
