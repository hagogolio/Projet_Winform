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
    public partial class AddClub : Form
    {
        public AddClub()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            DBConnectTest con = new DBConnectTest();
           
            List<Club> club = con.ReadAll();
            foreach (Club item in club)
            {

                comboBoxNom.Items.Add(item.getNom().ToString());

            }
            // Set up the DataGridView.


        }
          // Set the MaximizeBox to false to remove the maximize box.
           

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text == "" || textBoxAd.Text == "" || textBoxCP.Text == "" || textBoxTel.Text == "" || textBoxVille.Text == "" || textBoxWeb.Text == "")
                MessageBox.Show("Veuillez remplir tous les champs");
            else
            {
                string nom = textBoxNom.Text;
                string ville = textBoxVille.Text;
                string adr = textBoxAd.Text;
                int cp = Int32.Parse(textBoxCP.Text);
                string tel = textBoxTel.Text;
                string web = textBoxWeb.Text;
                DBConnectTest nveau = new DBConnectTest();
                nveau.InsertLigue(nom, adr, cp, ville, tel, web);
                Close();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
          
            textBoxNom.Clear();
            textBoxVille.Clear();
            textBoxAd.Clear();
            textBoxCP.Clear();
            textBoxTel.Clear();
            textBoxWeb.Clear();

        }
     
        }
    }
   


