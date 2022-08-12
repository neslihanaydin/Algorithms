namespace PracticeTestForFinal
{
    partial class Discount
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
            this.buttonBck = new System.Windows.Forms.Button();
            this.buttonDlt = new System.Windows.Forms.Button();
            this.buttonEdt = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewDiscount = new System.Windows.Forms.ListView();
            this.columnNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNumDstPrcnt = new System.Windows.Forms.TextBox();
            this.textBoxStdNam = new System.Windows.Forms.TextBox();
            this.textBoxStdNm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBck
            // 
            this.buttonBck.Location = new System.Drawing.Point(432, 464);
            this.buttonBck.Name = "buttonBck";
            this.buttonBck.Size = new System.Drawing.Size(104, 23);
            this.buttonBck.TabIndex = 27;
            this.buttonBck.Text = "Back to Main";
            this.buttonBck.UseVisualStyleBackColor = true;
            this.buttonBck.Click += new System.EventHandler(this.buttonBck_Click);
            // 
            // buttonDlt
            // 
            this.buttonDlt.Location = new System.Drawing.Point(344, 464);
            this.buttonDlt.Name = "buttonDlt";
            this.buttonDlt.Size = new System.Drawing.Size(75, 23);
            this.buttonDlt.TabIndex = 26;
            this.buttonDlt.Text = "Delete";
            this.buttonDlt.UseVisualStyleBackColor = true;
            this.buttonDlt.Click += new System.EventHandler(this.buttonDlt_Click);
            // 
            // buttonEdt
            // 
            this.buttonEdt.Location = new System.Drawing.Point(256, 464);
            this.buttonEdt.Name = "buttonEdt";
            this.buttonEdt.Size = new System.Drawing.Size(75, 23);
            this.buttonEdt.TabIndex = 25;
            this.buttonEdt.Text = "Edit";
            this.buttonEdt.UseVisualStyleBackColor = true;
            this.buttonEdt.Click += new System.EventHandler(this.buttonEdt_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(168, 464);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewDiscount
            // 
            this.listViewDiscount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNum,
            this.columnNam,
            this.columnDst});
            this.listViewDiscount.HideSelection = false;
            this.listViewDiscount.Location = new System.Drawing.Point(88, 208);
            this.listViewDiscount.Name = "listViewDiscount";
            this.listViewDiscount.Size = new System.Drawing.Size(512, 232);
            this.listViewDiscount.TabIndex = 23;
            this.listViewDiscount.UseCompatibleStateImageBehavior = false;
            this.listViewDiscount.View = System.Windows.Forms.View.Details;
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
            // columnDst
            // 
            this.columnDst.Text = "Discount";
            this.columnDst.Width = 135;
            // 
            // textBoxNumDstPrcnt
            // 
            this.textBoxNumDstPrcnt.Location = new System.Drawing.Point(320, 120);
            this.textBoxNumDstPrcnt.Name = "textBoxNumDstPrcnt";
            this.textBoxNumDstPrcnt.Size = new System.Drawing.Size(280, 20);
            this.textBoxNumDstPrcnt.TabIndex = 21;
            // 
            // textBoxStdNam
            // 
            this.textBoxStdNam.Location = new System.Drawing.Point(320, 80);
            this.textBoxStdNam.Name = "textBoxStdNam";
            this.textBoxStdNam.Size = new System.Drawing.Size(280, 20);
            this.textBoxStdNam.TabIndex = 20;
            // 
            // textBoxStdNm
            // 
            this.textBoxStdNm.Location = new System.Drawing.Point(320, 40);
            this.textBoxStdNm.Name = "textBoxStdNm";
            this.textBoxStdNm.Size = new System.Drawing.Size(280, 20);
            this.textBoxStdNm.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enter the discount percent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter the student name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter the student number";
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.buttonBck);
            this.Controls.Add(this.buttonDlt);
            this.Controls.Add(this.buttonEdt);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDiscount);
            this.Controls.Add(this.textBoxNumDstPrcnt);
            this.Controls.Add(this.textBoxStdNam);
            this.Controls.Add(this.textBoxStdNm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Discount";
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.Discount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBck;
        private System.Windows.Forms.Button buttonDlt;
        private System.Windows.Forms.Button buttonEdt;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewDiscount;
        private System.Windows.Forms.ColumnHeader columnNum;
        private System.Windows.Forms.ColumnHeader columnNam;
        private System.Windows.Forms.ColumnHeader columnDst;
        private System.Windows.Forms.TextBox textBoxNumDstPrcnt;
        private System.Windows.Forms.TextBox textBoxStdNam;
        private System.Windows.Forms.TextBox textBoxStdNm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}