using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Winform;

namespace Projet_Winform.DataAcces
{
    class DataAccesLigue
    {

        private string connectionString;
        public DataAccesLigue()
        {
            Initialize();
        }

        //Constructor
        internal Club insert(string nom, string adr, int cp, string ville, string tel, string web)
        {
            throw new NotImplementedException();
        }

        internal Adherent insert(string prenom, string nom, int tarif)
        {
            throw new NotImplementedException();
        }
       

        /// <summary>
        /// Initialise les champs et cree un objet connection.
        /// </summary>
        private void Initialize()
        {
            string server = "localhost";
            string port = "3306";
            string database = "projet_winform";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }

       
        public void insertLigue(string nom)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string sql = "Insert into ligue(nom_ligue) values (@nom)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
