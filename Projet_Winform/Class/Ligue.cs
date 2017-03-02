using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Winform.Class
{
    class Ligue
    {
        private string nom;
        private int idclub;
        private int idligue;

        public Ligue(string nom, int idclub, int idligue)
        {
            this.nom = nom;
            this.idclub = idclub;
            this.idligue = idligue;
        }
        public string getnom()
        {
            return nom;

        }
        public void setnom(string nom)
        {
            this.nom = nom;

        }
        public int getidclub()
        {
            return idclub;
        }
        public void setidclub(int idclub)
        {
            this.idclub = idclub;
        }
        public int getidligue()
        {
            return idligue;
        }
        public void setidligue(int idligue)
        {
            this.idligue = idligue;
        }




    }
}
