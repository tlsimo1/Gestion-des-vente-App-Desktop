namespace WindowsFormsApplication1.PL
{
    partial class FRM_CUSTOMERSLIST
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
            this.gridcustomerlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomerlist)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcustomerlist
            // 
            this.gridcustomerlist.AllowUserToAddRows = false;
            this.gridcustomerlist.AllowUserToDeleteRows = false;
            this.gridcustomerlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridcustomerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcustomerlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcustomerlist.Location = new System.Drawing.Point(0, 0);
            this.gridcustomerlist.Name = "gridcustomerlist";
            this.gridcustomerlist.ReadOnly = true;
            this.gridcustomerlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridcustomerlist.Size = new System.Drawing.Size(619, 261);
            this.gridcustomerlist.TabIndex = 0;
            this.gridcustomerlist.DoubleClick += new System.EventHandler(this.gridcustomerlist_DoubleClick);
            // 
            // FRM_CUSTOMERSLIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.gridcustomerlist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUSTOMERSLIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CUSTOMERSLIST";
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomerlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridcustomerlist;

    }
}