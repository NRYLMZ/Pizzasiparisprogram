namespace Pizza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupCustomer = new System.Windows.Forms.GroupBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.checkBoxOlive = new System.Windows.Forms.CheckBox();
            this.checkBoxMushroom = new System.Windows.Forms.CheckBox();
            this.checkBoxPickle = new System.Windows.Forms.CheckBox();
            this.checkBoxTomato = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.textAmoCal = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textGrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonNewc = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupCustomer.SuspendLayout();
            this.groupType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupAdd.SuspendLayout();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCustomer
            // 
            this.groupCustomer.Controls.Add(this.textAddress);
            this.groupCustomer.Controls.Add(this.textName);
            this.groupCustomer.Controls.Add(this.label2);
            this.groupCustomer.Controls.Add(this.label1);
            this.groupCustomer.Location = new System.Drawing.Point(13, 13);
            this.groupCustomer.Name = "groupCustomer";
            this.groupCustomer.Size = new System.Drawing.Size(687, 71);
            this.groupCustomer.TabIndex = 0;
            this.groupCustomer.TabStop = false;
            this.groupCustomer.Text = "Customer Information";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(96, 40);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(525, 20);
            this.textAddress.TabIndex = 3;
            this.textAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddress_KeyPress);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(96, 17);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(194, 20);
            this.textName.TabIndex = 2;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name  Surname";
            // 
            // groupType
            // 
            this.groupType.Controls.Add(this.pictureBox1);
            this.groupType.Controls.Add(this.radioButton4);
            this.groupType.Controls.Add(this.radioButton3);
            this.groupType.Controls.Add(this.radioButton2);
            this.groupType.Controls.Add(this.radioButton1);
            this.groupType.Enabled = false;
            this.groupType.Location = new System.Drawing.Point(13, 91);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(224, 116);
            this.groupType.TabIndex = 1;
            this.groupType.TabStop = false;
            this.groupType.Text = "Pizza Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 91);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(53, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Mixed";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Napoliten";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Marine";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sicilian";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupAdd
            // 
            this.groupAdd.Controls.Add(this.checkBoxOlive);
            this.groupAdd.Controls.Add(this.checkBoxMushroom);
            this.groupAdd.Controls.Add(this.checkBoxPickle);
            this.groupAdd.Controls.Add(this.checkBoxTomato);
            this.groupAdd.Controls.Add(this.checkBoxGreen);
            this.groupAdd.Enabled = false;
            this.groupAdd.Location = new System.Drawing.Point(13, 214);
            this.groupAdd.Name = "groupAdd";
            this.groupAdd.Size = new System.Drawing.Size(224, 100);
            this.groupAdd.TabIndex = 2;
            this.groupAdd.TabStop = false;
            this.groupAdd.Text = "Additions";
            // 
            // checkBoxOlive
            // 
            this.checkBoxOlive.AutoSize = true;
            this.checkBoxOlive.Location = new System.Drawing.Point(106, 68);
            this.checkBoxOlive.Name = "checkBoxOlive";
            this.checkBoxOlive.Size = new System.Drawing.Size(50, 17);
            this.checkBoxOlive.TabIndex = 4;
            this.checkBoxOlive.Text = "Olive";
            this.checkBoxOlive.UseVisualStyleBackColor = true;
            this.checkBoxOlive.CheckedChanged += new System.EventHandler(this.checkBoxOlive_CheckedChanged);
            // 
            // checkBoxMushroom
            // 
            this.checkBoxMushroom.AutoSize = true;
            this.checkBoxMushroom.Location = new System.Drawing.Point(106, 20);
            this.checkBoxMushroom.Name = "checkBoxMushroom";
            this.checkBoxMushroom.Size = new System.Drawing.Size(75, 17);
            this.checkBoxMushroom.TabIndex = 3;
            this.checkBoxMushroom.Text = "Mushroom";
            this.checkBoxMushroom.UseVisualStyleBackColor = true;
            this.checkBoxMushroom.CheckedChanged += new System.EventHandler(this.checkBoxMushroom_CheckedChanged);
            // 
            // checkBoxPickle
            // 
            this.checkBoxPickle.AutoSize = true;
            this.checkBoxPickle.Location = new System.Drawing.Point(7, 68);
            this.checkBoxPickle.Name = "checkBoxPickle";
            this.checkBoxPickle.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPickle.TabIndex = 2;
            this.checkBoxPickle.Text = "Pickle";
            this.checkBoxPickle.UseVisualStyleBackColor = true;
            this.checkBoxPickle.CheckedChanged += new System.EventHandler(this.checkBoxPickle_CheckedChanged);
            // 
            // checkBoxTomato
            // 
            this.checkBoxTomato.AutoSize = true;
            this.checkBoxTomato.Location = new System.Drawing.Point(7, 44);
            this.checkBoxTomato.Name = "checkBoxTomato";
            this.checkBoxTomato.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTomato.TabIndex = 1;
            this.checkBoxTomato.Text = "Tomato";
            this.checkBoxTomato.UseVisualStyleBackColor = true;
            this.checkBoxTomato.CheckedChanged += new System.EventHandler(this.checkBoxTomato_CheckedChanged);
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.AutoSize = true;
            this.checkBoxGreen.Location = new System.Drawing.Point(7, 20);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(92, 17);
            this.checkBoxGreen.TabIndex = 0;
            this.checkBoxGreen.Text = "Green Pepper";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            this.checkBoxGreen.CheckedChanged += new System.EventHandler(this.checkBoxGreen_CheckedChanged);
            // 
            // group
            // 
            this.group.Controls.Add(this.textAmoCal);
            this.group.Controls.Add(this.textTotal);
            this.group.Controls.Add(this.numericUpDown1);
            this.group.Controls.Add(this.textUnit);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.label4);
            this.group.Controls.Add(this.label3);
            this.group.Enabled = false;
            this.group.Location = new System.Drawing.Point(13, 321);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(224, 124);
            this.group.TabIndex = 3;
            this.group.TabStop = false;
            // 
            // textAmoCal
            // 
            this.textAmoCal.Enabled = false;
            this.textAmoCal.Location = new System.Drawing.Point(96, 86);
            this.textAmoCal.Name = "textAmoCal";
            this.textAmoCal.Size = new System.Drawing.Size(100, 20);
            this.textAmoCal.TabIndex = 7;
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(96, 59);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 20);
            this.textTotal.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(96, 36);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textUnit
            // 
            this.textUnit.Enabled = false;
            this.textUnit.Location = new System.Drawing.Point(96, 13);
            this.textUnit.Name = "textUnit";
            this.textUnit.Size = new System.Drawing.Size(100, 20);
            this.textUnit.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Amount of \r\nCalorie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "# of Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unit Price";
            // 
            // groupOrder
            // 
            this.groupOrder.Controls.Add(this.listView1);
            this.groupOrder.Controls.Add(this.textGrand);
            this.groupOrder.Controls.Add(this.label7);
            this.groupOrder.Enabled = false;
            this.groupOrder.Location = new System.Drawing.Point(252, 91);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Size = new System.Drawing.Size(448, 223);
            this.groupOrder.TabIndex = 4;
            this.groupOrder.TabStop = false;
            this.groupOrder.Text = "Current Order";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(25, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 150);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pizza";
            this.columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "# of Unit";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Price";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 61;
            // 
            // textGrand
            // 
            this.textGrand.Enabled = false;
            this.textGrand.Location = new System.Drawing.Point(319, 188);
            this.textGrand.Name = "textGrand";
            this.textGrand.Size = new System.Drawing.Size(109, 20);
            this.textGrand.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Grand Total";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Enabled = false;
            this.buttonInsert.Location = new System.Drawing.Point(252, 337);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 36);
            this.buttonInsert.TabIndex = 5;
            this.buttonInsert.Text = "&Insert Order";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(369, 337);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 36);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "&Delete Order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Enabled = false;
            this.buttonNew.Location = new System.Drawing.Point(486, 337);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 36);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "&New Order";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonNewc
            // 
            this.buttonNewc.Location = new System.Drawing.Point(605, 337);
            this.buttonNewc.Name = "buttonNewc";
            this.buttonNewc.Size = new System.Drawing.Size(75, 36);
            this.buttonNewc.TabIndex = 8;
            this.buttonNewc.Text = "New &Customer";
            this.buttonNewc.UseVisualStyleBackColor = true;
            this.buttonNewc.Click += new System.EventHandler(this.buttonNewc_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(252, 394);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(428, 38);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sicilian.jpg");
            this.imageList1.Images.SetKeyName(1, "Marine.jpg");
            this.imageList1.Images.SetKeyName(2, "Napoliten.jpg");
            this.imageList1.Images.SetKeyName(3, "Mixed.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 457);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewc);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.groupOrder);
            this.Controls.Add(this.group);
            this.Controls.Add(this.groupAdd);
            this.Controls.Add(this.groupType);
            this.Controls.Add(this.groupCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupCustomer.ResumeLayout(false);
            this.groupCustomer.PerformLayout();
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupAdd.ResumeLayout(false);
            this.groupAdd.PerformLayout();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCustomer;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.CheckBox checkBoxOlive;
        private System.Windows.Forms.CheckBox checkBoxMushroom;
        private System.Windows.Forms.CheckBox checkBoxPickle;
        private System.Windows.Forms.CheckBox checkBoxTomato;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAmoCal;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textUnit;
        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.TextBox textGrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonNewc;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList imageList1;
    }
}

