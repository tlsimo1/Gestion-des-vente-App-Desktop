namespace WindowsFormsApplication1.PL
{
    partial class FRM_CONFIG
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
            this.txt_NomServeur = new System.Windows.Forms.TextBox();
            this.txt_Nom_database = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomUtilisateur = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.lblerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NomServeur
            // 
            this.txt_NomServeur.Location = new System.Drawing.Point(176, 39);
            this.txt_NomServeur.Name = "txt_NomServeur";
            this.txt_NomServeur.Size = new System.Drawing.Size(226, 25);
            this.txt_NomServeur.TabIndex = 0;
            // 
            // txt_Nom_database
            // 
            this.txt_Nom_database.Location = new System.Drawing.Point(176, 80);
            this.txt_Nom_database.Name = "txt_Nom_database";
            this.txt_Nom_database.Size = new System.Drawing.Size(226, 25);
            this.txt_Nom_database.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOM DU SERVEUR :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOM DATABASE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "AUTHENTIFICATION :";
            // 
            // txt_NomUtilisateur
            // 
            this.txt_NomUtilisateur.Location = new System.Drawing.Point(176, 238);
            this.txt_NomUtilisateur.Name = "txt_NomUtilisateur";
            this.txt_NomUtilisateur.ReadOnly = true;
            this.txt_NomUtilisateur.Size = new System.Drawing.Size(226, 25);
            this.txt_NomUtilisateur.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(176, 284);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.ReadOnly = true;
            this.txt_Password.Size = new System.Drawing.Size(226, 25);
            this.txt_Password.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOM D\'UTILISATEUR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "PASSWORD :";
            // 
            // btn_Valider
            // 
            this.btn_Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Valider.Location = new System.Drawing.Point(226, 330);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(109, 29);
            this.btn_Valider.TabIndex = 26;
            this.btn_Valider.Text = "VALIDER";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(109, 330);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 29);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(176, 161);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(176, 21);
            this.rbWindows.TabIndex = 27;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows Authentification";
            this.rbWindows.UseVisualStyleBackColor = true;
            this.rbWindows.CheckedChanged += new System.EventHandler(this.rbWindows_CheckedChanged);
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(176, 201);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(192, 21);
            this.rbSQL.TabIndex = 28;
            this.rbSQL.Text = "SQL Server Authentification";
            this.rbSQL.UseVisualStyleBackColor = true;
            this.rbSQL.CheckedChanged += new System.EventHandler(this.rbSQL_CheckedChanged);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(214, 376);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 29;
            // 
            // FRM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 416);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.rbSQL);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_NomUtilisateur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nom_database);
            this.Controls.Add(this.txt_NomServeur);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_CONFIG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_CONFIG";
            this.Load += new System.EventHandler(this.FRM_CONFIG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label lblerror;
        public System.Windows.Forms.TextBox txt_NomServeur;
        public System.Windows.Forms.TextBox txt_Nom_database;
        public System.Windows.Forms.TextBox txt_NomUtilisateur;
        public System.Windows.Forms.TextBox txt_Password;
        public System.Windows.Forms.RadioButton rbWindows;
        public System.Windows.Forms.RadioButton rbSQL;
    }
}