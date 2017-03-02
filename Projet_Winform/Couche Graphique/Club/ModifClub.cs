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
    public partial class ModifClub : Form
    {
        public ModifClub()
        {
         
            InitializeComponent();
            groupBox1.Hide();
            this.WindowState = FormWindowState.Maximized;
            DBConnectTest nveau = new DBConnectTest();
            List<Club> Four = nveau.ReadAll();
            foreach (Club item in Four)
            {
         
               listBoxmod.Items.Add(item.getNom());
                

            }
        }

    

        private void listBoxmod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = (this.listBoxmod.SelectedIndex+1);
            DBConnectTest nveau = new DBConnectTest();
            Club test = nveau.Read(id);
            textNom.Text = test.getNom();
            textAdresse.Text = test.getadresse();
            textCP.Text = test.getcp().ToString();
            textVille.Text = test.getville();
            textWeb.Text = test.getweb();
            textTel.Text = test.gettel();
            groupBox1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" || textAdresse.Text == "" || textCP.Text == "" || textVille.Text == "" || textWeb.Text=="" || textTel.Text=="")
                MessageBox.Show("Veuillez renseigner tous les champs");
            else
            {
                DBConnectTest nveau = new DBConnectTest();
                string nom = textNom.Text;
                string ville = textVille.Text;
                string adr = textAdresse.Text;
                int cp = Int32.Parse(textCP.Text);
                string tel = textTel.Text;
                string web = textWeb.Text;
                nveau.ModifLigue(nom, adr, cp, ville, tel, web, this.listBoxmod.SelectedIndex + 1);
            }
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }







}

