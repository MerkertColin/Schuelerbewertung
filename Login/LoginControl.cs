using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung.Student
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler LoginSuccessful;
        public LoginControl()
        {
            InitializeComponent();
            ctrlLoginInput.LoginClick += OnLoginClick;

        }

        private void OnLoginClick( object sender, EventArgs e )
        {
            bool bLoginSuccessful = TestLogin();
            if ( bLoginSuccessful )
            {
                LoginSuccessful?.Invoke( sender, e );
            }
        }

        private bool TestLogin()
        {
            return "test" == ctrlLoginInput.Username && "test123" == ctrlLoginInput.Password;
        }


    }
}
