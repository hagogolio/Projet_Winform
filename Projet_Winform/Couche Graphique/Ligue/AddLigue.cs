using Projet_Winform.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_Winform
{
    public partial class AddLigue : Form
    {
        public AddLigue()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnectTest con = new DBConnectTest();
            if (textNom.Text == "")
                MessageBox.Show("Veuillez Entrer un nom valide");
            else
            {
                string nom = textNom.Text;

                DataAccesLigue nveau = new DataAccesLigue();
                nveau.insertLigue(nom);
                MessageBox.Show("Nouvelle Ligue Crée!");
                Close();
            }
        }
    }
}
