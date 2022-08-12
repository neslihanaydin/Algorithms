namespace Neslihan300359919Bicycle
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblNumOfDays = new System.Windows.Forms.Label();
            this.pictureBoxBicycle = new System.Windows.Forms.PictureBox();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.textBoxNumOfDays = new System.Windows.Forms.TextBox();
            this.grpBoxModels = new System.Windows.Forms.GroupBox();
            this.radioModel3 = new System.Windows.Forms.RadioButton();
            this.radioModel2 = new System.Windows.Forms.RadioButton();
            this.radioModel1 = new System.Windows.Forms.RadioButton();
            this.checkSenior = new System.Windows.Forms.CheckBox();
            this.checkMember = new System.Windows.Forms.CheckBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblComputeResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBicycle)).BeginInit();
            this.grpBoxModels.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(281, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(226, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Bicycle Rentals";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(48, 96);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(137, 21);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblNumOfDays
            // 
            this.lblNumOfDays.AutoSize = true;
            this.lblNumOfDays.Font = new System.Drawing.Font("Elephant", 12F);
            this.lblNumOfDays.Location = new System.Drawing.Point(47, 155);
            this.lblNumOfDays.Name = "lblNumOfDays";
            this.lblNumOfDays.Size = new System.Drawing.Size(138, 21);
            this.lblNumOfDays.TabIndex = 2;
            this.lblNumOfDays.Text = "Number of Days";
            // 
            // pictureBoxBicycle
            // 
            this.pictureBoxBicycle.Image = global::Neslihan300359919Bicycle.Properties.Resources.Model1;
            this.pictureBoxBicycle.Location = new System.Drawing.Point(51, 202);
            this.pictureBoxBicycle.Name = "pictureBoxBicycle";
            this.pictureBoxBicycle.Size = new System.Drawing.Size(229, 165);
            this.pictureBoxBicycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBicycle.TabIndex = 3;
            this.pictureBoxBicycle.TabStop = false;
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(331, 96);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(402, 20);
            this.textBoxCustName.TabIndex = 4;
            // 
            // textBoxNumOfDays
            // 
            this.textBoxNumOfDays.Location = new System.Drawing.Point(331, 157);
            this.textBoxNumOfDays.Name = "textBoxNumOfDays";
            this.textBoxNumOfDays.Size = new System.Drawing.Size(402, 20);
            this.textBoxNumOfDays.TabIndex = 5;
            this.textBoxNumOfDays.TextChanged += new System.EventHandler(this.textBoxNumOfDays_TextChanged);
            // 
            // grpBoxModels
            // 
            this.grpBoxModels.Controls.Add(this.radioModel3);
            this.grpBoxModels.Controls.Add(this.radioModel2);
            this.grpBoxModels.Controls.Add(this.radioModel1);
            this.grpBoxModels.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxModels.Location = new System.Drawing.Point(331, 202);
            this.grpBoxModels.Name = "grpBoxModels";
            this.grpBoxModels.Size = new System.Drawing.Size(402, 118);
            this.grpBoxModels.TabIndex = 8;
            this.grpBoxModels.TabStop = false;
            this.grpBoxModels.Text = "Bicycle Models";
            // 
            // radioModel3
            // 
            this.radioModel3.AutoSize = true;
            this.radioModel3.Font = new System.Drawing.Font("Elephant", 9.75F);
            this.radioModel3.Location = new System.Drawing.Point(300, 54);
            this.radioModel3.Name = "radioModel3";
            this.radioModel3.Size = new System.Drawing.Size(78, 21);
            this.radioModel3.TabIndex = 2;
            this.radioModel3.TabStop = true;
            this.radioModel3.Text = "Model 3";
            this.radioModel3.UseVisualStyleBackColor = true;
            this.radioModel3.CheckedChanged += new System.EventHandler(this.radioModel3_CheckedChanged);
            // 
            // radioModel2
            // 
            this.radioModel2.AutoSize = true;
            this.radioModel2.Font = new System.Drawing.Font("Elephant", 9.75F);
            this.radioModel2.Location = new System.Drawing.Point(164, 54);
            this.radioModel2.Name = "radioModel2";
            this.radioModel2.Size = new System.Drawing.Size(79, 21);
            this.radioModel2.TabIndex = 1;
            this.radioModel2.TabStop = true;
            this.radioModel2.Text = "Model 2";
            this.radioModel2.UseVisualStyleBackColor = true;
            this.radioModel2.CheckedChanged += new System.EventHandler(this.radioModel2_CheckedChanged);
            // 
            // radioModel1
            // 
            this.radioModel1.AutoSize = true;
            this.radioModel1.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioModel1.Location = new System.Drawing.Point(26, 54);
            this.radioModel1.Name = "radioModel1";
            this.radioModel1.Size = new System.Drawing.Size(76, 21);
            this.radioModel1.TabIndex = 0;
            this.radioModel1.TabStop = true;
            this.radioModel1.Text = "Model 1";
            this.radioModel1.UseVisualStyleBackColor = true;
            this.radioModel1.CheckedChanged += new System.EventHandler(this.radioModel1_CheckedChanged);
            // 
            // checkSenior
            // 
            this.checkSenior.AutoSize = true;
            this.checkSenior.Font = new System.Drawing.Font("Elephant", 9.75F);
            this.checkSenior.ForeColor = System.Drawing.Color.Black;
            this.checkSenior.Location = new System.Drawing.Point(379, 343);
            this.checkSenior.Name = "checkSenior";
            this.checkSenior.Size = new System.Drawing.Size(117, 21);
            this.checkSenior.TabIndex = 9;
            this.checkSenior.Text = "Senior Citizen";
            this.checkSenior.UseVisualStyleBackColor = true;
            // 
            // checkMember
            // 
            this.checkMember.AutoSize = true;
            this.checkMember.Font = new System.Drawing.Font("Elephant", 9.75F);
            this.checkMember.Location = new System.Drawing.Point(551, 343);
            this.checkMember.Name = "checkMember";
            this.checkMember.Size = new System.Drawing.Size(82, 21);
            this.checkMember.TabIndex = 10;
            this.checkMember.Text = "Member";
            this.checkMember.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.White;
            this.btnCompute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCompute.Location = new System.Drawing.Point(96, 384);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(149, 40);
            this.btnCompute.TabIndex = 11;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblComputeResult
            // 
            this.lblComputeResult.AutoSize = true;
            this.lblComputeResult.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputeResult.Location = new System.Drawing.Point(281, 384);
            this.lblComputeResult.Name = "lblComputeResult";
            this.lblComputeResult.Size = new System.Drawing.Size(0, 21);
            this.lblComputeResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComputeResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.checkMember);
            this.Controls.Add(this.checkSenior);
            this.Controls.Add(this.grpBoxModels);
            this.Controls.Add(this.textBoxNumOfDays);
            this.Controls.Add(this.textBoxCustName);
            this.Controls.Add(this.pictureBoxBicycle);
            this.Controls.Add(this.lblNumOfDays);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBicycle)).EndInit();
            this.grpBoxModels.ResumeLayout(false);
            this.grpBoxModels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblNumOfDays;
        private System.Windows.Forms.PictureBox pictureBoxBicycle;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.TextBox textBoxNumOfDays;
        private System.Windows.Forms.GroupBox grpBoxModels;
        private System.Windows.Forms.RadioButton radioModel3;
        private System.Windows.Forms.RadioButton radioModel2;
        private System.Windows.Forms.RadioButton radioModel1;
        private System.Windows.Forms.CheckBox checkSenior;
        private System.Windows.Forms.CheckBox checkMember;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblComputeResult;
    }
}

