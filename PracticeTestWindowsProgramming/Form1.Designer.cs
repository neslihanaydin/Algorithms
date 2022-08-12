namespace PracticeTestForFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStdNm = new System.Windows.Forms.TextBox();
            this.textBoxStdNam = new System.Windows.Forms.TextBox();
            this.textBoxNumCrs = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCrs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStdTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFlt = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdt = new System.Windows.Forms.Button();
            this.buttonDlt = new System.Windows.Forms.Button();
            this.buttonDst = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDst = new System.Windows.Forms.TextBox();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.comboBoxStdTyp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the student number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the student name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose the student type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter the number of course";
            // 
            // textBoxStdNm
            // 
            this.textBoxStdNm.Location = new System.Drawing.Point(304, 48);
            this.textBoxStdNm.Name = "textBoxStdNm";
            this.textBoxStdNm.Size = new System.Drawing.Size(280, 20);
            this.textBoxStdNm.TabIndex = 4;
            // 
            // textBoxStdNam
            // 
            this.textBoxStdNam.Location = new System.Drawing.Point(304, 88);
            this.textBoxStdNam.Name = "textBoxStdNam";
            this.textBoxStdNam.Size = new System.Drawing.Size(280, 20);
            this.textBoxStdNam.TabIndex = 5;
            // 
            // textBoxNumCrs
            // 
            this.textBoxNumCrs.Location = new System.Drawing.Point(304, 128);
            this.textBoxNumCrs.Name = "textBoxNumCrs";
            this.textBoxNumCrs.Size = new System.Drawing.Size(280, 20);
            this.textBoxNumCrs.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnNam,
            this.columnCrs,
            this.columnStdTyp});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(72, 216);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 232);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnNum
            // 
            this.columnNum.Text = "Number";
            this.columnNum.Width = 100;
            // 
            // columnNam
            // 
            this.columnNam.Text = "Name";
            this.columnNam.Width = 100;
            // 
            // columnCrs
            // 
            this.columnCrs.Text = "#Courses";
            this.columnCrs.Width = 135;
            // 
            // columnStdTyp
            // 
            this.columnStdTyp.Text = "Student Type";
            this.columnStdTyp.Width = 144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filter";
            // 
            // textBoxFlt
            // 
            this.textBoxFlt.Location = new System.Drawing.Point(624, 296);
            this.textBoxFlt.Name = "textBoxFlt";
            this.textBoxFlt.Size = new System.Drawing.Size(136, 20);
            this.textBoxFlt.TabIndex = 10;
            this.textBoxFlt.TextChanged += new System.EventHandler(this.textBoxFlt_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(152, 472);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdt
            // 
            this.buttonEdt.Location = new System.Drawing.Point(240, 472);
            this.buttonEdt.Name = "buttonEdt";
            this.buttonEdt.Size = new System.Drawing.Size(75, 23);
            this.buttonEdt.TabIndex = 12;
            this.buttonEdt.Text = "Edit";
            this.buttonEdt.UseVisualStyleBackColor = true;
            this.buttonEdt.Click += new System.EventHandler(this.buttonEdt_Click);
            // 
            // buttonDlt
            // 
            this.buttonDlt.Location = new System.Drawing.Point(328, 472);
            this.buttonDlt.Name = "buttonDlt";
            this.buttonDlt.Size = new System.Drawing.Size(75, 23);
            this.buttonDlt.TabIndex = 13;
            this.buttonDlt.Text = "Delete";
            this.buttonDlt.UseVisualStyleBackColor = true;
            this.buttonDlt.Click += new System.EventHandler(this.buttonDlt_Click);
            // 
            // buttonDst
            // 
            this.buttonDst.Location = new System.Drawing.Point(416, 472);
            this.buttonDst.Name = "buttonDst";
            this.buttonDst.Size = new System.Drawing.Size(75, 23);
            this.buttonDst.TabIndex = 14;
            this.buttonDst.Text = "Discount";
            this.buttonDst.UseVisualStyleBackColor = true;
            this.buttonDst.Click += new System.EventHandler(this.buttonDst_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Discounts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Tuition Fee";
            // 
            // textBoxDst
            // 
            this.textBoxDst.Location = new System.Drawing.Point(304, 520);
            this.textBoxDst.Name = "textBoxDst";
            this.textBoxDst.ReadOnly = true;
            this.textBoxDst.Size = new System.Drawing.Size(280, 20);
            this.textBoxDst.TabIndex = 17;
            // 
            // textBoxFee
            // 
            this.textBoxFee.Location = new System.Drawing.Point(304, 552);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(280, 20);
            this.textBoxFee.TabIndex = 18;
            // 
            // comboBoxStdTyp
            // 
            this.comboBoxStdTyp.FormattingEnabled = true;
            this.comboBoxStdTyp.Items.AddRange(new object[] {
            "Domestic",
            "International"});
            this.comboBoxStdTyp.Location = new System.Drawing.Point(304, 168);
            this.comboBoxStdTyp.Name = "comboBoxStdTyp";
            this.comboBoxStdTyp.Size = new System.Drawing.Size(280, 21);
            this.comboBoxStdTyp.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.comboBoxStdTyp);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.textBoxDst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDst);
            this.Controls.Add(this.buttonDlt);
            this.Controls.Add(this.buttonEdt);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFlt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxNumCrs);
            this.Controls.Add(this.textBoxStdNam);
            this.Controls.Add(this.textBoxStdNm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tuition Fee Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxStdNm;
        public System.Windows.Forms.TextBox textBoxStdNam;
        private System.Windows.Forms.TextBox textBoxNumCrs;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnNam;
        private System.Windows.Forms.ColumnHeader columnCrs;
        private System.Windows.Forms.ColumnHeader columnStdTyp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFlt;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdt;
        private System.Windows.Forms.Button buttonDlt;
        private System.Windows.Forms.Button buttonDst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDst;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.ComboBox comboBoxStdTyp;
    }
}

