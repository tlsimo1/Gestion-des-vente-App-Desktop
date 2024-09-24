namespace WindowsFormsApplication1.PL
{
    partial class FRM_PRODUCTS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtrecherch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridlistproduct = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_allreport = new System.Windows.Forms.Button();
            this.btn_rport = new System.Windows.Forms.Button();
            this.btn_img = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_sup = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridlistproduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECHERCH  :";
            // 
            // txtrecherch
            // 
            this.txtrecherch.Location = new System.Drawing.Point(191, 30);
            this.txtrecherch.Name = "txtrecherch";
            this.txtrecherch.Size = new System.Drawing.Size(629, 21);
            this.txtrecherch.TabIndex = 0;
            this.txtrecherch.TextChanged += new System.EventHandler(this.txtrecherch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridlistproduct);
            this.groupBox1.Location = new System.Drawing.Point(14, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // gridlistproduct
            // 
            this.gridlistproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridlistproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridlistproduct.Location = new System.Drawing.Point(7, 22);
            this.gridlistproduct.Name = "gridlistproduct";
            this.gridlistproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridlistproduct.Size = new System.Drawing.Size(902, 328);
            this.gridlistproduct.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_export);
            this.groupBox2.Controls.Add(this.btn_allreport);
            this.groupBox2.Controls.Add(this.btn_rport);
            this.groupBox2.Controls.Add(this.btn_img);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_sup);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Location = new System.Drawing.Point(14, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(740, 44);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(169, 27);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_export
            // 
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Location = new System.Drawing.Point(23, 44);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(194, 27);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "EXPORT DATA IN EXEL";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_allreport
            // 
            this.btn_allreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allreport.Location = new System.Drawing.Point(224, 44);
            this.btn_allreport.Name = "btn_allreport";
            this.btn_allreport.Size = new System.Drawing.Size(194, 27);
            this.btn_allreport.TabIndex = 5;
            this.btn_allreport.Text = "REPORT  ALL DATA ";
            this.btn_allreport.UseVisualStyleBackColor = true;
            this.btn_allreport.Click += new System.EventHandler(this.btn_allreport_Click);
            // 
            // btn_rport
            // 
            this.btn_rport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rport.Location = new System.Drawing.Point(23, 10);
            this.btn_rport.Name = "btn_rport";
            this.btn_rport.Size = new System.Drawing.Size(194, 27);
            this.btn_rport.TabIndex = 4;
            this.btn_rport.Text = "REPORT DATA SPECIFIER";
            this.btn_rport.UseVisualStyleBackColor = true;
            this.btn_rport.Click += new System.EventHandler(this.btn_rport_Click);
            // 
            // btn_img
            // 
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Location = new System.Drawing.Point(224, 10);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(194, 27);
            this.btn_img.TabIndex = 3;
            this.btn_img.Text = "VIEW IMAGE PRODUCT";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(425, 10);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 27);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "UPDATE PRODUCT";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_sup
            // 
            this.btn_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sup.Location = new System.Drawing.Point(594, 10);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(139, 27);
            this.btn_sup.TabIndex = 1;
            this.btn_sup.Text = "DELETE PRODUCT";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(740, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(169, 27);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD NEW PRODUCT";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRODUCT";
            // 
            // FRM_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtrecherch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCTS";
            this.Load += new System.EventHandler(this.FRM_PRODUCTS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridlistproduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrecherch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_allreport;
        private System.Windows.Forms.Button btn_rport;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.DataGridView gridlistproduct;
        private System.Windows.Forms.Label label2;
    }
}