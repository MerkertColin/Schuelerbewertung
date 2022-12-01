using System;
using System.Collections.Generic;
using System.Text;

namespace Schuelerbewertung.EvArgs
{
    public class LoginSuccessfulEventArgs : EventArgs
    {
        public string Username { get; private set; }

        public LoginSuccessfulEventArgs( string sUsername )
        {
            Username = sUsername;
        }
    }
}
