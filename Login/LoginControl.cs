using Schuelerbewertung.Database;
using Schuelerbewertung.EvArgs;
using System;
using System.Windows.Forms;

namespace Schuelerbewertung.Student
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler<LoginSuccessfulEventArgs> LoginSuccessful;
        public LoginControl()
        {
            InitializeComponent();
            ctrlLoginInput.LoginClick += OnLoginClick;
        }

        private void OnLoginClick( object sender, EventArgs e )
        {
            DbConnection con = DbConnection.GetInstance();
            bool bLoginSuccessful = con.Connect( ctrlLoginInput.Username, ctrlLoginInput.Password );
            if ( bLoginSuccessful )
            {
                LoginSuccessful?.Invoke( sender, new LoginSuccessfulEventArgs( ctrlLoginInput.Username ) );
            }
        }
    }
}
