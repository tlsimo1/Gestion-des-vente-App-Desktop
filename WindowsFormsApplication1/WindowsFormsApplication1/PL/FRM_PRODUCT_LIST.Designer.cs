namespace WindowsFormsApplication1.PL
{
    partial class FRM_PRODUCT_LIST
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
            this.gridAllProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAllProduct
            // 
            this.gridAllProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAllProduct.Location = new System.Drawing.Point(0, 0);
            this.gridAllProduct.MultiSelect = false;
            this.gridAllProduct.Name = "gridAllProduct";
            this.gridAllProduct.ReadOnly = true;
            this.gridAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAllProduct.Size = new System.Drawing.Size(726, 262);
            this.gridAllProduct.TabIndex = 0;
            this.gridAllProduct.DoubleClick += new System.EventHandler(this.gridAllProduct_DoubleClick);
            // 
            // FRM_PRODUCT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 262);
            this.Controls.Add(this.gridAllProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCT_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LIST PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.gridAllProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridAllProduct;

    }
}