namespace WindowsFormsApplication1.PL
{
    partial class FRM_ORDERS
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_searchcust = new System.Windows.Forms.Button();
            this.txt_custid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.txt_custemeil = new System.Windows.Forms.TextBox();
            this.txt_custtel = new System.Windows.Forms.TextBox();
            this.txt_custlastname = new System.Windows.Forms.TextBox();
            this.txt_custfirstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateorder = new System.Windows.Forms.DateTimePicker();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_desorder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_totalG = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_remise = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_quantite = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_prixproduct = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_libleproduct = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_productid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_deleteS = new System.Windows.Forms.Button();
            this.grid_commande = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_browse = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_valide = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_commande)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_searchcust);
            this.groupBox1.Controls.Add(this.txt_custid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.picCustomer);
            this.groupBox1.Controls.Add(this.txt_custemeil);
            this.groupBox1.Controls.Add(this.txt_custtel);
            this.groupBox1.Controls.Add(this.txt_custlastname);
            this.groupBox1.Controls.Add(this.txt_custfirstname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_searchcust
            // 
            this.btn_searchcust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchcust.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_searchcust.Location = new System.Drawing.Point(212, 18);
            this.btn_searchcust.Name = "btn_searchcust";
            this.btn_searchcust.Size = new System.Drawing.Size(63, 27);
            this.btn_searchcust.TabIndex = 0;
            this.btn_searchcust.Text = "....";
            this.btn_searchcust.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_searchcust.UseVisualStyleBackColor = true;
            this.btn_searchcust.Click += new System.EventHandler(this.btn_searchcust_Click);
            // 
            // txt_custid
            // 
            this.txt_custid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_custid.Location = new System.Drawing.Point(121, 22);
            this.txt_custid.Name = "txt_custid";
            this.txt_custid.ReadOnly = true;
            this.txt_custid.Size = new System.Drawing.Size(84, 21);
            this.txt_custid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID :";
            // 
            // picCustomer
            // 
            this.picCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCustomer.Location = new System.Drawing.Point(282, 22);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(152, 155);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomer.TabIndex = 8;
            this.picCustomer.TabStop = false;
            // 
            // txt_custemeil
            // 
            this.txt_custemeil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_custemeil.Location = new System.Drawing.Point(121, 153);
            this.txt_custemeil.Name = "txt_custemeil";
            this.txt_custemeil.ReadOnly = true;
            this.txt_custemeil.Size = new System.Drawing.Size(154, 21);
            this.txt_custemeil.TabIndex = 7;
            // 
            // txt_custtel
            // 
            this.txt_custtel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_custtel.Location = new System.Drawing.Point(121, 121);
            this.txt_custtel.Name = "txt_custtel";
            this.txt_custtel.ReadOnly = true;
            this.txt_custtel.Size = new System.Drawing.Size(154, 21);
            this.txt_custtel.TabIndex = 6;
            // 
            // txt_custlastname
            // 
            this.txt_custlastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_custlastname.Location = new System.Drawing.Point(121, 88);
            this.txt_custlastname.Name = "txt_custlastname";
            this.txt_custlastname.ReadOnly = true;
            this.txt_custlastname.Size = new System.Drawing.Size(154, 21);
            this.txt_custlastname.TabIndex = 5;
            // 
            // txt_custfirstname
            // 
            this.txt_custfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_custfirstname.Location = new System.Drawing.Point(121, 53);
            this.txt_custfirstname.Name = "txt_custfirstname";
            this.txt_custfirstname.ReadOnly = true;
            this.txt_custfirstname.Size = new System.Drawing.Size(154, 21);
            this.txt_custfirstname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "EMAIL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TEL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LAST_NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST_NAME :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateorder);
            this.groupBox2.Controls.Add(this.txt_orderid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_user);
            this.groupBox2.Controls.Add(this.txt_desorder);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(475, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dateorder
            // 
            this.dateorder.Location = new System.Drawing.Point(135, 118);
            this.dateorder.Name = "dateorder";
            this.dateorder.Size = new System.Drawing.Size(233, 21);
            this.dateorder.TabIndex = 1;
            // 
            // txt_orderid
            // 
            this.txt_orderid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_orderid.Location = new System.Drawing.Point(132, 17);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.ReadOnly = true;
            this.txt_orderid.Size = new System.Drawing.Size(84, 21);
            this.txt_orderid.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID ORDER :";
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Location = new System.Drawing.Point(132, 149);
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = true;
            this.txt_user.Size = new System.Drawing.Size(236, 21);
            this.txt_user.TabIndex = 18;
            // 
            // txt_desorder
            // 
            this.txt_desorder.Location = new System.Drawing.Point(132, 48);
            this.txt_desorder.Multiline = true;
            this.txt_desorder.Name = "txt_desorder";
            this.txt_desorder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desorder.Size = new System.Drawing.Size(228, 61);
            this.txt_desorder.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "NAME VENDEUR :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "DATE DE VENTE :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "DESCRIPTION :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txt_totalG);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_remise);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_amount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txt_quantite);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_prixproduct);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_libleproduct);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_productid);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn_deleteS);
            this.groupBox3.Controls.Add(this.grid_commande);
            this.groupBox3.Controls.Add(this.btn_browse);
            this.groupBox3.Location = new System.Drawing.Point(14, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(919, 231);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(6, 11);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(3);
            this.label19.Size = new System.Drawing.Size(87, 35);
            this.label19.TabIndex = 31;
            this.label19.Text = "Search";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_totalG
            // 
            this.txt_totalG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalG.Location = new System.Drawing.Point(789, 44);
            this.txt_totalG.Name = "txt_totalG";
            this.txt_totalG.ReadOnly = true;
            this.txt_totalG.Size = new System.Drawing.Size(122, 21);
            this.txt_totalG.TabIndex = 30;
            this.txt_totalG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(789, 11);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(122, 35);
            this.label18.TabIndex = 29;
            this.label18.Text = "Total";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_remise
            // 
            this.txt_remise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remise.Location = new System.Drawing.Point(682, 44);
            this.txt_remise.MaxLength = 3;
            this.txt_remise.Name = "txt_remise";
            this.txt_remise.Size = new System.Drawing.Size(107, 21);
            this.txt_remise.TabIndex = 28;
            this.txt_remise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_remise.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_remise_KeyDown);
            this.txt_remise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_remise_KeyPress);
            this.txt_remise.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_remise_KeyUp);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(682, 11);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(107, 35);
            this.label17.TabIndex = 27;
            this.label17.Text = "Remise";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_amount
            // 
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amount.Location = new System.Drawing.Point(575, 44);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(107, 21);
            this.txt_amount.TabIndex = 26;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(575, 11);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(107, 35);
            this.label16.TabIndex = 25;
            this.label16.Text = "Amount";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_quantite
            // 
            this.txt_quantite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_quantite.Location = new System.Drawing.Point(468, 44);
            this.txt_quantite.MaxLength = 8;
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.Size = new System.Drawing.Size(107, 21);
            this.txt_quantite.TabIndex = 24;
            this.txt_quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantite_KeyDown);
            this.txt_quantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantite_KeyPress);
            this.txt_quantite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_quantite_KeyUp);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(468, 11);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(107, 35);
            this.label15.TabIndex = 23;
            this.label15.Text = "Quantité";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_prixproduct
            // 
            this.txt_prixproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prixproduct.Location = new System.Drawing.Point(361, 44);
            this.txt_prixproduct.MaxLength = 8;
            this.txt_prixproduct.Name = "txt_prixproduct";
            this.txt_prixproduct.Size = new System.Drawing.Size(107, 21);
            this.txt_prixproduct.TabIndex = 22;
            this.txt_prixproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_prixproduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_prixproduct_KeyDown);
            this.txt_prixproduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prixproduct_KeyPress);
            this.txt_prixproduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_prixproduct_KeyUp);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(361, 11);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(107, 35);
            this.label14.TabIndex = 21;
            this.label14.Text = "Prix";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_libleproduct
            // 
            this.txt_libleproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_libleproduct.Location = new System.Drawing.Point(200, 44);
            this.txt_libleproduct.Name = "txt_libleproduct";
            this.txt_libleproduct.Size = new System.Drawing.Size(161, 21);
            this.txt_libleproduct.TabIndex = 20;
            this.txt_libleproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(200, 11);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(161, 35);
            this.label13.TabIndex = 19;
            this.label13.Text = "Libele Product";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_productid
            // 
            this.txt_productid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productid.Location = new System.Drawing.Point(93, 44);
            this.txt_productid.Name = "txt_productid";
            this.txt_productid.ReadOnly = true;
            this.txt_productid.Size = new System.Drawing.Size(107, 21);
            this.txt_productid.TabIndex = 18;
            this.txt_productid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(93, 11);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(107, 35);
            this.label12.TabIndex = 17;
            this.label12.Text = "Product ID";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Location = new System.Drawing.Point(758, 201);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(154, 21);
            this.txt_total.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(694, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "TOTAL :";
            // 
            // btn_deleteS
            // 
            this.btn_deleteS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteS.Location = new System.Drawing.Point(6, 198);
            this.btn_deleteS.Name = "btn_deleteS";
            this.btn_deleteS.Size = new System.Drawing.Size(269, 27);
            this.btn_deleteS.TabIndex = 12;
            this.btn_deleteS.Text = "SUPPRIMER LA LIGNE SELECTIONNER";
            this.btn_deleteS.UseVisualStyleBackColor = true;
            // 
            // grid_commande
            // 
            this.grid_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_commande.ColumnHeadersVisible = false;
            this.grid_commande.ContextMenuStrip = this.contextMenuStrip1;
            this.grid_commande.Location = new System.Drawing.Point(7, 71);
            this.grid_commande.MultiSelect = false;
            this.grid_commande.Name = "grid_commande";
            this.grid_commande.ReadOnly = true;
            this.grid_commande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_commande.Size = new System.Drawing.Size(905, 124);
            this.grid_commande.TabIndex = 0;
            this.grid_commande.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grid_commande_RowsRemoved);
            this.grid_commande.DoubleClick += new System.EventHandler(this.grid_commande_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteRowToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteAllRowsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 82);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // deleteAllRowsToolStripMenuItem
            // 
            this.deleteAllRowsToolStripMenuItem.Name = "deleteAllRowsToolStripMenuItem";
            this.deleteAllRowsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteAllRowsToolStripMenuItem.Text = "Delete All Rows";
            this.deleteAllRowsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllRowsToolStripMenuItem_Click);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(5, 44);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(90, 21);
            this.btn_browse.TabIndex = 32;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_cancel);
            this.groupBox4.Controls.Add(this.btn_imprimer);
            this.groupBox4.Controls.Add(this.btn_valide);
            this.groupBox4.Controls.Add(this.btn_new);
            this.groupBox4.Location = new System.Drawing.Point(178, 451);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 53);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(7, 18);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 27);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Enabled = false;
            this.btn_imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimer.Location = new System.Drawing.Point(90, 18);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(131, 27);
            this.btn_imprimer.TabIndex = 14;
            this.btn_imprimer.Text = "IMRIMER";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // btn_valide
            // 
            this.btn_valide.Enabled = false;
            this.btn_valide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valide.Location = new System.Drawing.Point(227, 18);
            this.btn_valide.Name = "btn_valide";
            this.btn_valide.Size = new System.Drawing.Size(161, 27);
            this.btn_valide.TabIndex = 13;
            this.btn_valide.Text = "ENREGISTRER VENTE";
            this.btn_valide.UseVisualStyleBackColor = true;
            this.btn_valide.Click += new System.EventHandler(this.btn_valide_Click);
            // 
            // btn_new
            // 
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(395, 18);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(148, 27);
            this.btn_new.TabIndex = 12;
            this.btn_new.Text = "NOUVELLE  VENTE";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "ORDERS";
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 510);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDERS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_commande)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_searchcust;
        private System.Windows.Forms.TextBox txt_custid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.TextBox txt_custemeil;
        private System.Windows.Forms.TextBox txt_custtel;
        private System.Windows.Forms.TextBox txt_custlastname;
        private System.Windows.Forms.TextBox txt_custfirstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateorder;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_desorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_deleteS;
        private System.Windows.Forms.DataGridView grid_commande;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_valide;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_totalG;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_remise;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_quantite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_prixproduct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_libleproduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_productid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteAllRowsToolStripMenuItem;
    }
}