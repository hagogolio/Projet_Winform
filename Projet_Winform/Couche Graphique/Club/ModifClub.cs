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

            //  DataTable Four = nveau.club(nom);

            // Set up the DataGridView.
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //  int  index= dataGridView1.CurrentCell.RowIndex;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Automatically generate the DataGridView columns.
            dataGridView1.AutoGenerateColumns = true;
            List<Club> club = nveau.ReadAll();
            foreach (Club item in club)
            {

                toolStripComboBox1.Items.Add(item.getNom().ToString());

            }
            /* dataGridView1.DataSource = Four;
             {
                 listBoxmod.Items.Add(item.getId());
                 listBoxmod.Items.Add(item.getNom());



             }*/
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom = toolStripComboBox1.ComboBox.SelectedItem.ToString();
            DBConnectTest con = new DBConnectTest();
            DataTable test = con.club(nom);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //  int  index= dataGridView1.CurrentCell.RowIndex;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Automatically generate the DataGridView columns.
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = test;
              
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" || textAdresse.Text == "" || textCP.Text == "" || textVille.Text == "" || textWeb.Text == "" || textTel.Text == "")
                MessageBox.Show("Veuillez renseigner tous les champs");
            else
            {
                DBConnectTest nveau = new DBConnectTest();
                int id = Int32.Parse(textId.Text);
                string nom = textNom.Text;
                string ville = textVille.Text;
                string adr = textAdresse.Text;
                int cp = Int32.Parse(textCP.Text);
                string tel = textTel.Text;
                string web = textWeb.Text;
                nveau.ModifLigue(nom, adr, cp, ville, tel, web,id);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (id2 != "")
            {
             
                
                int idtest = Int32.Parse(id2);
                DBConnectTest con = new DBConnectTest();
                Club test = con.Read(idtest);
                textId.Text = test.getId().ToString();
                textNom.Text = test.getNom();
                textAdresse.Text = test.getadresse();
                textCP.Text = test.getcp().ToString();
                textVille.Text = test.getville();
                textWeb.Text = test.getweb();
                textTel.Text = test.gettel();
                groupBox1.Show();
            }
        }


    }
}

