namespace Pendu_game
{
    partial class Fenetre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_char = new System.Windows.Forms.Button();
            this.mot_chercheur = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.combo_char = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.liste_char = new System.Windows.Forms.ListBox();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_char
            // 
            this.btn_char.Location = new System.Drawing.Point(204, 24);
            this.btn_char.Name = "btn_char";
            this.btn_char.Size = new System.Drawing.Size(55, 23);
            this.btn_char.TabIndex = 1;
            this.btn_char.Text = "valider";
            this.btn_char.UseVisualStyleBackColor = true;
            this.btn_char.Click += new System.EventHandler(this.BoutonLettre);
            // 
            // mot_chercheur
            // 
            this.mot_chercheur.Location = new System.Drawing.Point(140, 150);
            this.mot_chercheur.Name = "mot_chercheur";
            this.mot_chercheur.Size = new System.Drawing.Size(100, 20);
            this.mot_chercheur.TabIndex = 2;
            this.mot_chercheur.TextChanged += new System.EventHandler(this.TexteChercheur);
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(21, 12);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(100, 169);
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.ImagePendu);
            // 
            // combo_char
            // 
            this.combo_char.FormattingEnabled = true;
            this.combo_char.Location = new System.Drawing.Point(140, 26);
            this.combo_char.Name = "combo_char";
            this.combo_char.Size = new System.Drawing.Size(58, 21);
            this.combo_char.TabIndex = 3;
            this.combo_char.SelectedIndexChanged += new System.EventHandler(this.ComboLettre);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BoutonMot);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.TextePendu);
            // 
            // liste_char
            // 
            this.liste_char.FormattingEnabled = true;
            this.liste_char.Location = new System.Drawing.Point(139, 53);
            this.liste_char.Name = "liste_char";
            this.liste_char.Size = new System.Drawing.Size(120, 69);
            this.liste_char.TabIndex = 6;
            this.liste_char.SelectedIndexChanged += new System.EventHandler(this.ListeChar);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(33, 227);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.BtnReset);
            // 
            // Fenetre
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.liste_char);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combo_char);
            this.Controls.Add(this.mot_chercheur);
            this.Controls.Add(this.btn_char);
            this.Controls.Add(this.Image);
            this.Name = "Fenetre";
            this.Load += new System.EventHandler(this.FenetreJeu);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_char;
        private System.Windows.Forms.TextBox mot_chercheur;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.ComboBox combo_char;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox liste_char;
        private System.Windows.Forms.Button btn_reset;
    }
}

