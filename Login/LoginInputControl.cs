using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Schuelerbewertung.Login
{
    public partial class LoginInputControl : UserControl
    {
        public event EventHandler LoginClick;
        public string Username { get => tbUsername.Text; }
        public string Password { get => tbPassword.Text; }
        
        public LoginInputControl()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClick?.Invoke( sender, e );
        }
    }
}
