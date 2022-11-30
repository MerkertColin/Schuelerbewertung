using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Schuelerbewertung.Database
{
    class DbConnection
    {
        private const string IP_ADRESS = "192.168.0.241";
        private const string DATABASE = "schuelergruppierung";
        private MySqlConnection _connection;
        private static DbConnection _instance;

        private DbConnection()
        {
            _connection = new MySqlConnection();
        }

        public static DbConnection GetInstance()
        {
            if ( _instance == null )
            {
                _instance = new DbConnection();
            }
            return _instance;
        }

        public bool Connect( string sUser, string sPassword )
        {
            string sConString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};",
                                                IP_ADRESS,
                                                DATABASE,
                                                sUser,
                                                sPassword);
            _connection.ConnectionString = sConString;
            try
            {
                _connection.Open();
            } catch ( Exception e )
            {
                return false;
            }
            return true;
        }

        public void Disconnect()
        {
            _connection.Close();
            _connection.ConnectionString = null;
        }

        public void ExecuteNoReturn( string sQuery )
        {
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = sQuery;
            command.ExecuteNonQuery();
        }

        public MySqlDataReader CreateReader( string sQuery )
        {
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = sQuery;
            return command.ExecuteReader();
        }
    }
}
