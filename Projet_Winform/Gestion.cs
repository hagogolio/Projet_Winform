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
    public partial class Gestion : Form
    {
        public Gestion()
        {

            
            InitializeComponent();
            this.IsMdiContainer = true;





            DBConnectTest nveau = new DBConnectTest();
            List<Club> Four = nveau.ReadAll();
           /* foreach (Ligue item in Four)
            {
                MnuStripItem = new ToolStripMenuItem(item.getNom().ToString());
                menuStrip1.Items.Add(MnuStripItem);


            }*/
            this.MainMenuStrip = menuStrip1;
            foreach (Club item in Four)
            {
                toolStripComboBox1.Items.Add(item.getNom().ToString());

            }
        }



        
        AddAdh f5;
        AddLigue f1;
        AddClub f2;
        ModifClub f3;
        ModifAdhClub f4;
        /*  private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (f2 == null)
              {
                  f2 = new Form2();
                  f2.MdiParent = this;
                  f2.FormClosed += F2_FormClosed;
                  f2.Show();



                  Form childForm = new Form();
              }
              else
                  f2.Activate();
          }*/

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            // Take some action based on the data in clickedItem
        }
    

    
        private void toolStripTextBoxEv_Click(object sender, EventArgs e)
        {
            //  GestionEvenement Ev = new GestionEvenement();
            // Ev.Show();
        }

        private void créerUneLigueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new AddClub();
                f2.MdiParent = this;
                f2.FormClosed += F2_FormClosed; ;
                f2.Show();




                Form childForm = new Form();
            }
            else
                f2.Activate();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }

        private void consulterModifierLigueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new ModifClub();
                f3.MdiParent = this;
                f3.FormClosed += F3_FormClosed; ; ;
                f3.Show();




                Form childForm = new Form();
            }
            else
                f3.Activate();
        }

        private void F3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3 = null;
        }

        /*   private void consulterModifierAdhérentToolStripMenuItem_Click(object sender, EventArgs e)
           {
               if (f4 == null)
               {
                   f4 = new FormEmploye();
                   f4.MdiParent = this;
                   f4.FormClosed += F4_FormClosed1;
                   f4.Show();




                   Form childForm = new Form();
               }
               else
                   f4.Activate();
           }*/

        private void F4_FormClosed1(object sender, FormClosedEventArgs e)
        {
            f4 = null;
        }

        /*private void toolStripComboBox1_Enter(object sender, EventArgs e)
        {
            string nom = toolStripComboBox1.ComboBox.SelectedValue.ToString();
            if (f4 == null)
            {
                
                f4 = new FormEmploye(nom);
                f4.MdiParent = this;
                f4.FormClosed += F4_FormClosed1;
                f4.Show();




                Form childForm = new Form();
            }
            else
                f4.Activate();
        }*/




        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
                string nom = toolStripComboBox1.ComboBox.SelectedItem.ToString();
                if (f4 == null)
                {
                    
                    f4 = new ModifAdhClub(nom);
                    f4.MdiParent = this;
                    f4.FormClosed += F4_FormClosed1;
                    f4.Show();




                    Form childForm = new Form();
                }
                else

                f4 = new ModifAdhClub(nom);
            f4.MdiParent = this;
            f4.FormClosed += F4_FormClosed1;
            f4.Show();
        }

        private void tousLesAdhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nom = " ";
            if (f4 == null)
            {

                f4 = new ModifAdhClub(nom);
                f4.MdiParent = this;
                f4.FormClosed += F4_FormClosed1;
                f4.Show();




                Form childForm = new Form();
            }
            else

                f4 = new ModifAdhClub(nom);
            f4.MdiParent = this;
            f4.FormClosed += F4_FormClosed1;
            f4.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (f5 == null)
            {

                f5 = new AddAdh();
                f5.MdiParent = this;
                f5.FormClosed += F5_FormClosed; 
                f5.Show();




                Form childForm = new Form();
            }
            else

            f5 = new AddAdh();
            f5.MdiParent = this;
            f5.FormClosed += F5_FormClosed; ;
            f5.Show();
        }

        private void F5_FormClosed(object sender, FormClosedEventArgs e)
        {
            f5 = null;
        }

        private void créerUneLigueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (f1 == null)
            {
                f1 = new AddLigue();
                f1.MdiParent = this;
                f1.FormClosed += F1_FormClosed;
                f1.Show();




                Form childForm = new Form();
            }
            else
                f1.Activate();
        }

        private void F1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = null;
        }
    }
    }
    
   

    
    
    

    
    

