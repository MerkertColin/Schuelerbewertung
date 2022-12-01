using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Schuelerbewertung.Database
{
    class DbConnection
    {
        private const string IP_ADDRESS = "192.168.0.241";
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
                                                IP_ADDRESS,
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

        public bool RatingExists( int nStudentId, int nGroupId )
        {
            string sQuery = $"SELECT EXISTS ( SELECT * FROM bewertungen WHERE bewerter={nStudentId} AND gruppenid={nGroupId} )";
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = sQuery;
            int result = (int)command.ExecuteScalar();
            return 1 == result;
        }

        public bool HasRated( string sUsername )
        {
            int nExists = 0;
            string sQuery = "SELECT EXISTS " +
                "(SELECT * " +
                "FROM bewertungen AS b " +
                "JOIN schueler AS s " +
                "ON b.Bewerter=s.SchuelerID " +
                "WHERE b.Bewerter=(SELECT schuelerid " +
                "FROM schueler " +
                $"WHERE nutzername='{sUsername}'))";
            MySqlCommand command = _connection.CreateCommand();
            
            command.CommandText = sQuery;
            nExists = (int)command.ExecuteScalar();
            return 1 == nExists;
        }

        public bool IsStudent( string sUsername )
        {
            int nIsStudent = 0;
            string sQuery = $"SELECT EXISTS (SELECT * FROM schueler WHERE nutzername = '{sUsername}')";
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = sQuery;
            nIsStudent = (int)command.ExecuteScalar();
            return 1 == nIsStudent;
        }
    }
}
