namespace Projet_Winform
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gestionLiguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneLigueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLigueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.créerUneLigueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterModifierLigueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAdhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consulterModifierAdhérentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tousLesAdhérentsToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gestionEvénementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerEvénementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterGérerEvénementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionLiguesToolStripMenuItem,
            this.gestionAdhérentsToolStripMenuItem,
            this.gestionEvénementsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(843, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gestionLiguesToolStripMenuItem
            // 
            this.gestionLiguesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUneLigueToolStripMenuItem1,
            this.consulterLigueToolStripMenuItem,
            this.toolStripSeparator4,
            this.créerUneLigueToolStripMenuItem,
            this.consulterModifierLigueToolStripMenuItem});
            this.gestionLiguesToolStripMenuItem.Name = "gestionLiguesToolStripMenuItem";
            this.gestionLiguesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.gestionLiguesToolStripMenuItem.Text = "Gestion Ligues";
            // 
            // créerUneLigueToolStripMenuItem1
            // 
            this.créerUneLigueToolStripMenuItem1.Name = "créerUneLigueToolStripMenuItem1";
            this.créerUneLigueToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.créerUneLigueToolStripMenuItem1.Text = "Créer une Ligue";
            this.créerUneLigueToolStripMenuItem1.Click += new System.EventHandler(this.créerUneLigueToolStripMenuItem1_Click);
            // 
            // consulterLigueToolStripMenuItem
            // 
            this.consulterLigueToolStripMenuItem.Name = "consulterLigueToolStripMenuItem";
            this.consulterLigueToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consulterLigueToolStripMenuItem.Text = "Consulter Ligue";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // créerUneLigueToolStripMenuItem
            // 
            this.créerUneLigueToolStripMenuItem.Name = "créerUneLigueToolStripMenuItem";
            this.créerUneLigueToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.créerUneLigueToolStripMenuItem.Text = "Créer un Club";
            this.créerUneLigueToolStripMenuItem.Click += new System.EventHandler(this.créerUneLigueToolStripMenuItem_Click);
            // 
            // consulterModifierLigueToolStripMenuItem
            // 
            this.consulterModifierLigueToolStripMenuItem.Name = "consulterModifierLigueToolStripMenuItem";
            this.consulterModifierLigueToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.consulterModifierLigueToolStripMenuItem.Text = "Consulter/Modifier Club";
            this.consulterModifierLigueToolStripMenuItem.Click += new System.EventHandler(this.consulterModifierLigueToolStripMenuItem_Click);
            // 
            // gestionAdhérentsToolStripMenuItem
            // 
            this.gestionAdhérentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.toolStripSeparator1,
            this.consulterModifierAdhérentToolStripMenuItem,
            this.toolStripSeparator2});
            this.gestionAdhérentsToolStripMenuItem.Name = "gestionAdhérentsToolStripMenuItem";
            this.gestionAdhérentsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gestionAdhérentsToolStripMenuItem.Text = "Gestion Adhérents";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ajouterToolStripMenuItem.Text = "Nouvel Adhérent";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // consulterModifierAdhérentToolStripMenuItem
            // 
            this.consulterModifierAdhérentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripComboBox1,
            this.toolStripSeparator3,
            this.toolStripTextBox2,
            this.toolStripComboBox2,
            this.toolStripSeparator5,
            this.tousLesAdhérentsToolStripMenuItem});
            this.consulterModifierAdhérentToolStripMenuItem.Name = "consulterModifierAdhérentToolStripMenuItem";
            this.consulterModifierAdhérentToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.consulterModifierAdhérentToolStripMenuItem.Text = "Consulter/Modifier Adhérent";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Ligue :";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(152, 23);
            this.toolStripComboBox1.ToolTipText = "test";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(269, 6);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Club:";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(152, 23);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(269, 6);
            // 
            // tousLesAdhérentsToolStripMenuItem
            // 
            this.tousLesAdhérentsToolStripMenuItem.Name = "tousLesAdhérentsToolStripMenuItem";
            this.tousLesAdhérentsToolStripMenuItem.Size = new System.Drawing.Size(212, 23);
            this.tousLesAdhérentsToolStripMenuItem.Text = "Tous les adhérents";
            this.tousLesAdhérentsToolStripMenuItem.Click += new System.EventHandler(this.tousLesAdhérentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // gestionEvénementsToolStripMenuItem
            // 
            this.gestionEvénementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerEvénementsToolStripMenuItem,
            this.consulterGérerEvénementsToolStripMenuItem});
            this.gestionEvénementsToolStripMenuItem.Name = "gestionEvénementsToolStripMenuItem";
            this.gestionEvénementsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestionEvénementsToolStripMenuItem.Text = "Gestion Evénements";
            // 
            // créerEvénementsToolStripMenuItem
            // 
            this.créerEvénementsToolStripMenuItem.Name = "créerEvénementsToolStripMenuItem";
            this.créerEvénementsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.créerEvénementsToolStripMenuItem.Text = "Créer Evénements";
            // 
            // consulterGérerEvénementsToolStripMenuItem
            // 
            this.consulterGérerEvénementsToolStripMenuItem.Name = "consulterGérerEvénementsToolStripMenuItem";
            this.consulterGérerEvénementsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.consulterGérerEvénementsToolStripMenuItem.Text = "Consulter/Gérer Evénements";
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(843, 711);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion";
            this.Tag = "";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gestionLiguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneLigueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterModifierLigueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAdhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterModifierAdhérentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem créerUneLigueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterLigueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox tousLesAdhérentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem gestionEvénementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerEvénementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterGérerEvénementsToolStripMenuItem;
    }
}

