using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Winform
{
   public class Club
    {
        private int id;
        private string nom;
        private string adresse;
        private int cp;
        private string ville;
        private string tel;
        private string web;

        public Club(int id, string nom, string adresse, int cp, string ville, string tel,string web)
        {
            this.id = id;
            this.nom = nom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.tel = tel;
            this.web = web;

        }
        public Club()
        {

        }
        public int getId()
        {

            return id;
        }
        public void setId(int id)
        {
            this.id = id;

        }
        public string getNom()
        {

            return nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;

        }
        public string getadresse()
        {

            return adresse;
        }
        public void setadresse(string adresse)
        {
            this.adresse = adresse;

        }
        public int getcp()
        {

            return cp;
        }
        public void setcp(int cp)
        {
            this.cp = cp;

        }
        public string getville()
        {

            return ville;
        }
        public void setville(string ville)
        {
            this.ville = ville;

        }
        public string gettel()
        {

            return tel;
        }
        public void settel(string tel)
        {
            this.tel = tel;

        }
        public string getweb()
        {

            return web;
        }
        public void setweb(string web)
        {
            this.web = web;

        }
    }
}
