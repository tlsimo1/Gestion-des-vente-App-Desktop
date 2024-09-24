namespace WindowsFormsApplication1.PL
{
    partial class FRM_CATEGORIES
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblposition = new System.Windows.Forms.Label();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_suiv = new System.Windows.Forms.Button();
            this.btn_der = new System.Windows.Forms.Button();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridview_cat = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_rptp = new System.Windows.Forms.Button();
            this.btn_pdft = new System.Windows.Forms.Button();
            this.btn_rptsl = new System.Windows.Forms.Button();
            this.btn_rpt = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_cat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblposition);
            this.groupBox1.Controls.Add(this.btn_pre);
            this.groupBox1.Controls.Add(this.btn_precedent);
            this.groupBox1.Controls.Add(this.btn_suiv);
            this.groupBox1.Controls.Add(this.btn_der);
            this.groupBox1.Controls.Add(this.txt_des);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gridview_cat);
            this.groupBox1.Location = new System.Drawing.Point(14, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.Location = new System.Drawing.Point(210, 228);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(35, 15);
            this.lblposition.TabIndex = 9;
            this.lblposition.Text = "label3";
            // 
            // btn_pre
            // 
            this.btn_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pre.Location = new System.Drawing.Point(374, 223);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(93, 27);
            this.btn_pre.TabIndex = 8;
            this.btn_pre.Text = "PREMIER";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_precedent.Location = new System.Drawing.Point(264, 223);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(104, 27);
            this.btn_precedent.TabIndex = 7;
            this.btn_precedent.Text = "PRECEDENT";
            this.btn_precedent.UseVisualStyleBackColor = true;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // btn_suiv
            // 
            this.btn_suiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suiv.Location = new System.Drawing.Point(104, 223);
            this.btn_suiv.Name = "btn_suiv";
            this.btn_suiv.Size = new System.Drawing.Size(99, 27);
            this.btn_suiv.TabIndex = 6;
            this.btn_suiv.Text = "SUIVANT";
            this.btn_suiv.UseVisualStyleBackColor = true;
            this.btn_suiv.Click += new System.EventHandler(this.btn_suiv_Click);
            // 
            // btn_der
            // 
            this.btn_der.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_der.Location = new System.Drawing.Point(10, 223);
            this.btn_der.Name = "btn_der";
            this.btn_der.Size = new System.Drawing.Size(86, 27);
            this.btn_der.TabIndex = 5;
            this.btn_der.Text = "DERNIER";
            this.btn_der.UseVisualStyleBackColor = true;
            this.btn_der.Click += new System.EventHandler(this.btn_der_Click);
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(118, 75);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(184, 119);
            this.txt_des.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPTION : ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(121, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(116, 21);
            this.txt_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORIE ID : ";
            // 
            // gridview_cat
            // 
            this.gridview_cat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_cat.Location = new System.Drawing.Point(325, 22);
            this.gridview_cat.Name = "gridview_cat";
            this.gridview_cat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_cat.Size = new System.Drawing.Size(397, 173);
            this.gridview_cat.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_rptp);
            this.groupBox2.Controls.Add(this.btn_pdft);
            this.groupBox2.Controls.Add(this.btn_rptsl);
            this.groupBox2.Controls.Add(this.btn_rpt);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_new);
            this.groupBox2.Location = new System.Drawing.Point(15, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(52, 55);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 27);
            this.btn_close.TabIndex = 17;
            this.btn_close.Text = "CANCEL";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_rptp
            // 
            this.btn_rptp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rptp.Location = new System.Drawing.Point(206, 55);
            this.btn_rptp.Name = "btn_rptp";
            this.btn_rptp.Size = new System.Drawing.Size(288, 27);
            this.btn_rptp.TabIndex = 16;
            this.btn_rptp.UseVisualStyleBackColor = true;
            this.btn_rptp.Click += new System.EventHandler(this.btn_rptp_Click);
            // 
            // btn_pdft
            // 
            this.btn_pdft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdft.Location = new System.Drawing.Point(560, 55);
            this.btn_pdft.Name = "btn_pdft";
            this.btn_pdft.Size = new System.Drawing.Size(146, 27);
            this.btn_pdft.TabIndex = 15;
            this.btn_pdft.Text = "PDF";
            this.btn_pdft.UseVisualStyleBackColor = true;
            this.btn_pdft.Click += new System.EventHandler(this.btn_pdft_Click);
            // 
            // btn_rptsl
            // 
            this.btn_rptsl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rptsl.Location = new System.Drawing.Point(52, 22);
            this.btn_rptsl.Name = "btn_rptsl";
            this.btn_rptsl.Size = new System.Drawing.Size(213, 27);
            this.btn_rptsl.TabIndex = 14;
            this.btn_rptsl.Text = "IMRIMER CAT SELECTIONNER";
            this.btn_rptsl.UseVisualStyleBackColor = true;
            this.btn_rptsl.Click += new System.EventHandler(this.btn_rptsl_Click);
            // 
            // btn_rpt
            // 
            this.btn_rpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rpt.Location = new System.Drawing.Point(273, 22);
            this.btn_rpt.Name = "btn_rpt";
            this.btn_rpt.Size = new System.Drawing.Size(132, 27);
            this.btn_rpt.TabIndex = 13;
            this.btn_rpt.Text = "IMPRIMER TOUS";
            this.btn_rpt.UseVisualStyleBackColor = true;
            this.btn_rpt.Click += new System.EventHandler(this.btn_rpt_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(412, 22);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(80, 27);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(499, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(64, 27);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(570, 22);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 27);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_new
            // 
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(642, 22);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(64, 27);
            this.btn_new.TabIndex = 9;
            this.btn_new.Text = "NEW";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "CATEGORIES";
            // 
            // FRM_CATEGORIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CATEGORIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIES";
            this.Load += new System.EventHandler(this.FRM_CATEGORIES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_cat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_suiv;
        private System.Windows.Forms.Button btn_der;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridview_cat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_rptp;
        private System.Windows.Forms.Button btn_pdft;
        private System.Windows.Forms.Button btn_rptsl;
        private System.Windows.Forms.Button btn_rpt;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label label3;
    }
}