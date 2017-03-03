namespace Projet_Winform
{
    public class Adherent
    {

        private int id;
        private string nom;
        private string prenom;
        //   private int cotisation;
        private string adr;
        private string tel;
        private string mail;
        private int cp;
        private string ville;

        public Adherent(int id, string nom, string prenom, string adr, int cp, string ville, string tel, string mail)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            // this.cotisation = cotisation;
            this.adr = adr;
            this.cp = cp;
            this.ville = ville;
            this.tel = tel;
            this.mail = mail;


        }
        public Adherent()
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
        public string getprenom()
        {

            return prenom;
        }
        public void setprenom(string prenom)
        {
            this.prenom = prenom;

        }
        /*   public int getcotisation()
           {

               return cotisation;
           }
        /   public void setcotisation(int cotisation)
           {
               this.cotisation = cotisation;

           }*/
        public string getadr()
        {
            return adr;
        }
        public void setadr(string adr)
        {
            this.adr = adr;
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
        public string getmail()
        {
            return mail;
        }
        public void setmail(string mail)
        {
            this.mail = mail;
        }
        public void settel(string tel)
        {
            this.tel = tel;
        }
        public string gettel()
        {
            return tel;
        }
    }


}