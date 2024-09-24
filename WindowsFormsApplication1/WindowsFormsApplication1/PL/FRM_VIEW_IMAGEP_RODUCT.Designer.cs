namespace WindowsFormsApplication1.PL
{
    partial class FRM_VIEW_IMAGEP_RODUCT
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
            this.pic_IMAGE = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_IMAGE
            // 
            this.pic_IMAGE.Location = new System.Drawing.Point(12, 12);
            this.pic_IMAGE.Name = "pic_IMAGE";
            this.pic_IMAGE.Size = new System.Drawing.Size(459, 293);
            this.pic_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_IMAGE.TabIndex = 0;
            this.pic_IMAGE.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(184, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FRM_VIEW_IMAGEP_RODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_IMAGE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_VIEW_IMAGEP_RODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMAGE_PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.pic_IMAGE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pic_IMAGE;
        private System.Windows.Forms.Button button1;

    }
}