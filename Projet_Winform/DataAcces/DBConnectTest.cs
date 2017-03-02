using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Winform;

namespace Projet_Winform
{
    class DBConnectTest
    {


        private string connectionString;

        //Constructor
        public DBConnectTest()
        {
            Initialize();
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

        internal Club insert(string nom, string adr, int cp, string ville, string tel, string web)
        {
            throw new NotImplementedException();
        }

        internal Adherent insert(string prenom, string nom, int tarif)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// La méthode Read retourne un fournisseur en fonction de l'id dans la table. 
        /// </summary>
        /// <param name="id">id du fournisseur recherché</param>
        /// <returns></returns>
        public Club Read(int id)
        {
            Club laLigue = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM club where id_club=@id";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        laLigue = new Club();
                        laLigue.setId(dataReader["id_club"] != DBNull.Value ? (int)dataReader["id_club"] : 0);
                        laLigue.setNom((string)dataReader["nom_club"]);
                        laLigue.setadresse((string)dataReader["adresse_club"]);
                        laLigue.setville((string)dataReader["ville_club"]);
                        laLigue.setcp(dataReader["cp_club"] != DBNull.Value ? (int)dataReader["cp_club"] : 0);
                        laLigue.setweb((string)dataReader["site_club"]);
                        laLigue.settel((string)dataReader["tel_club"]);


                    }

                }

            }

            return laLigue;


        }
      
        public DataTable data(string nom)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable t = null;
            connection.Open();
            /* MySqlDataAdapter test = new MySqlDataAdapter("Select * from adherent where id_club_adh=1 ",connection);
             DataTable dt = new DataTable();
             test.Fill(dt);
             return dt;*/
            if (nom == " ")
            {
                using (MySqlDataAdapter a = new MySqlDataAdapter("Select adherent.id_adh as Licence,nom_adh as Nom ,prenom_adh as Prenom from adherent", connection))
                {
                    string filter = nom;
                    t = new DataTable();

                    a.Fill(t);

                }
            }
            else
            {
                using (MySqlDataAdapter a = new MySqlDataAdapter("Select adherent.id_adh as Licence,nom_adh as Nom ,prenom_adh as Prenom from lien_adh_club  inner join adherent on lien_adh_club.id_adh=adherent.id_adh inner join club on lien_adh_club.id_club=club.id_club where nom_club=@filter", connection))
                {
                    string filter = nom;
                    t = new DataTable();
                    a.SelectCommand.Parameters.AddWithValue("@filter", filter);
                    a.Fill(t);

                }
            }
          /*  using (MySqlDataAdapter a = new MySqlDataAdapter("Select adherent.id_adh as Licence,nom_adh as Nom ,prenom_adh as Prenom from adherent", connection))
            {
            
             t = new DataTable();
         
                a.Fill(t);
            }*/
            return t;
        }
        public Adherent Adh(int id)
        {


            Adherent Adh = null;



            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select * from adherent where id_adh=@id";


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        Adh = new Adherent();
                        Adh.setId(dataReader["id_adh"] != DBNull.Value ? (int)dataReader["id_adh"] : 0);
                        Adh.setNom((string)dataReader["nom_adh"]);
                        Adh.setprenom((string)dataReader["prenom_adh"]);
                        Adh.setadr((string)dataReader["adresse_adh"]);
                        Adh.setville((string)dataReader["ville_adh"]);
                        Adh.setcp(dataReader["cp_adh"] != DBNull.Value ? (int)dataReader["cp_adh"] : 0);
                        Adh.setmail((string)dataReader["mail_adh"]);
                        Adh.settel((string)dataReader["tel_adh"]);


                    }

                }
                return Adh;
            } }

        public DataTable club(string nom)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable t = null;
            connection.Open();
            /* MySqlDataAdapter test = new MySqlDataAdapter("Select * from adherent where id_club_adh=1 ",connection);
             DataTable dt = new DataTable();
             test.Fill(dt);
             return dt;*/
            if (nom == " ")
            {
                using (MySqlDataAdapter a = new MySqlDataAdapter("Select club.id_club as Id,nom_club as Nom ,nom_ligue as Ligue from club inner join ligue on ligue.id_club=ligue.id_club", connection))
                {
                    string filter = nom;
                    t = new DataTable();

                    a.Fill(t);

                }
            }
            else
            {
                using (MySqlDataAdapter a = new MySqlDataAdapter("Select club.id_club as Id,club.nom_club as Nom ,ligue.nom_ligue as Ligue from club inner join ligue on club.id_club=ligue.id_club where club.nom_club=@filter ", connection))
                {
                    string filter = nom;
                    t = new DataTable();
                    a.SelectCommand.Parameters.AddWithValue("@filter", filter);
                    a.Fill(t);

                }
               
            }
            return t;
        }

            /* using (MySqlDataAdapter a = new MySqlDataAdapter("Select adherent.id_adh as Licence,nom_adh as Nom ,prenom_adh as Prenom from adherent", connection))
             {

                 t = new DataTable();

                 a.Fill(t);
             }*/
         
        
        public List<Club> ReadAll()
        {
            Club laligue = null;
            List<Club> List = new List<Club>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM club";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);


                //Create a data reader and Execute the command

                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        laligue = new Club();
                        laligue.setNom((string)dataReader["nom_club"]);
                        laligue.setadresse((string)dataReader["adresse_club"]);
                        laligue.setville((string)dataReader["ville_club"]);
                        laligue.setcp(dataReader["cp_club"] != DBNull.Value ? (int)dataReader["cp_club"] : 0);
                        laligue.setweb((string)dataReader["site_club"]);
                        laligue.settel((string)dataReader["tel_club"]);
                        List.Add(laligue);
                    }


                }

            }
            return List;


        }
        public void ModifLigue(string nom, string adresse, int cp, string ville, string tel, string web, int id)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string sql = "Update club set nom_club=@nom,adresse_club=@adresse,cp_club=@cp,ville_club=@ville,tel_club=@tel,site_club=@web where id_club=@id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@adresse", adresse);
                cmd.Parameters.AddWithValue("@cp", cp);
                cmd.Parameters.AddWithValue("@ville", ville);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@web", web);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
        public void ModifAdh(string nom,string prenom, string adresse, int cp, string ville, string tel, string mail, int id)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string sql = "Update adherent set nom_adh=@nom,prenom_adh=@prenom,adresse_adh=@adresse,cp_adh=@cp,ville_adh=@ville,tel_adh=@tel,mail_adh=@web where id_adh=@id";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
               
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@adresse", adresse);
                cmd.Parameters.AddWithValue("@cp", cp);
                cmd.Parameters.AddWithValue("@ville", ville);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@web", mail);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
        public void InsertLigue( string nom, string adresse, int cp, string ville, string tel, string web)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                string sql = "INSERT INTO club(nom_club,adresse_club,cp_club,ville_club,tel_club,site_club) VALUES(@nom,@adresse,@cp,@ville,@tel,@web)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@adresse", adresse);
                cmd.Parameters.AddWithValue("@cp", cp);
                cmd.Parameters.AddWithValue("@ville", ville);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@web", web);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
       
    }
}