using System;
using System.Data;
using System.Windows.Forms;

namespace Projet_Winform
{
    public partial class ModifAdhClub : Form
    {
        public ModifAdhClub(string nom)
        {





            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            //  int test = f.getId();
            DBConnectTest nveau = new DBConnectTest();
            DataTable Four = nveau.data(nom);

            // Set up the DataGridView.
            dataGridView1.Dock = DockStyle.Fill;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //  int  index= dataGridView1.CurrentCell.RowIndex;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Automatically generate the DataGridView columns.
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Four;
            textNom.Enabled = false;
            textPrenom.Enabled = false;
            textAdr.Enabled = false;
            textVille.Enabled = false;
            textCP.Enabled = false;
            textTel.Enabled = false;
            textMail.Enabled = false;
            textId.Enabled = false;
            button1.Hide();
            textBox1.Text = nom;

        }



    

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id2 = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (id2 != "")
            {
                textNom.Enabled = false;
                textPrenom.Enabled = false;
                textAdr.Enabled = false;
                textVille.Enabled = false;
                textCP.Enabled = false;
                textTel.Enabled = false;
                textMail.Enabled = false;
                button1.Hide();
                buttonModif.Show();
                int idtest = Int32.Parse(id2);
                DBConnectTest connec = new DBConnectTest();
                Adherent lAdherent = connec.Adh(idtest);
                textNom.Text = lAdherent.getNom();
                textPrenom.Text = lAdherent.getprenom();
                textAdr.Text = lAdherent.getadr();
                textVille.Text = lAdherent.getville();
                textCP.Text = Convert.ToString(lAdherent.getcp());
                textTel.Text = lAdherent.gettel();
                textMail.Text = lAdherent.getmail();
                textId.Text = Convert.ToString(idtest);
            }
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            textNom.Enabled = true;
            textPrenom.Enabled = true;
            textAdr.Enabled = true;
            textVille.Enabled = true;
            textCP.Enabled = true;
            textTel.Enabled = true;
            textMail.Enabled = true;
            button1.Show();
            buttonModif.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNom.Text == "" || textPrenom.Text == "" || textAdr.Text == "" || textCP.Text == "" || textVille.Text == "" || textMail.Text == "" || textTel.Text == "")
                MessageBox.Show("Veuillez renseigner tous les champs");
            else
            {
                textNom.Enabled = false;
                textPrenom.Enabled = false;
                textAdr.Enabled = false;
                textVille.Enabled = false;
                textCP.Enabled = false;
                textTel.Enabled = false;
                textMail.Enabled = false;
                button1.Hide();
                buttonModif.Show();
                DBConnectTest nveau = new DBConnectTest();
                string nom = textNom.Text;
                string prenom = textPrenom.Text;
                string ville = textVille.Text;
                string adr = textAdr.Text;
                int cp = Int32.Parse(textCP.Text);
                string tel = textTel.Text;
                string mail = textMail.Text;
                int id = Int32.Parse(textId.Text);
                nveau.ModifAdh(nom, prenom, adr, cp, ville, tel, mail, id);
            }
        }
    }
}


