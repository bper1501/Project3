namespace ResidentHall
{
    partial class NewResident
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
            this.ResType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.DormLabel = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.tbDorm = new System.Windows.Forms.TextBox();
            this.floorsList = new System.Windows.Forms.ComboBox();
            this.FloorLabel = new System.Windows.Forms.Label();
            this.studentlbl = new System.Windows.Forms.Label();
            this.feeLbl = new System.Windows.Forms.Label();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.warningLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResType
            // 
            this.ResType.AllowDrop = true;
            this.ResType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResType.FormattingEnabled = true;
            this.ResType.Items.AddRange(new object[] {
            "Scholarship",
            "Athlete",
            "Student Worker"});
            this.ResType.Location = new System.Drawing.Point(124, 71);
            this.ResType.Name = "ResType";
            this.ResType.Size = new System.Drawing.Size(121, 24);
            this.ResType.TabIndex = 0;
            this.ResType.SelectedIndexChanged += new System.EventHandler(this.ResType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID#:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.firstNameLabel.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(37, 155);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(114, 25);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.LastNamelabel.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelabel.Location = new System.Drawing.Point(37, 186);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(111, 25);
            this.LastNamelabel.TabIndex = 3;
            this.LastNamelabel.Text = "Last Name:";
            // 
            // DormLabel
            // 
            this.DormLabel.AutoSize = true;
            this.DormLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.DormLabel.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DormLabel.Location = new System.Drawing.Point(40, 220);
            this.DormLabel.Name = "DormLabel";
            this.DormLabel.Size = new System.Drawing.Size(83, 25);
            this.DormLabel.TabIndex = 4;
            this.DormLabel.Text = "Dorm #:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(157, 155);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(146, 22);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(157, 186);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(146, 22);
            this.tbLastName.TabIndex = 8;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(89, 124);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(196, 22);
            this.tbID.TabIndex = 9;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Location = new System.Drawing.Point(129, 371);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Location = new System.Drawing.Point(228, 371);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // tbDorm
            // 
            this.tbDorm.Location = new System.Drawing.Point(129, 220);
            this.tbDorm.Name = "tbDorm";
            this.tbDorm.Size = new System.Drawing.Size(100, 22);
            this.tbDorm.TabIndex = 12;
            // 
            // floorsList
            // 
            this.floorsList.FormattingEnabled = true;
            this.floorsList.Items.AddRange(new object[] {
            "1-3",
            "4-6",
            "7-8"});
            this.floorsList.Location = new System.Drawing.Point(124, 248);
            this.floorsList.Name = "floorsList";
            this.floorsList.Size = new System.Drawing.Size(121, 24);
            this.floorsList.TabIndex = 13;
            // 
            // FloorLabel
            // 
            this.FloorLabel.AutoSize = true;
            this.FloorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.FloorLabel.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorLabel.Location = new System.Drawing.Point(40, 250);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(76, 25);
            this.FloorLabel.TabIndex = 14;
            this.FloorLabel.Text = "Floor #";
            // 
            // studentlbl
            // 
            this.studentlbl.AutoSize = true;
            this.studentlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.studentlbl.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlbl.Location = new System.Drawing.Point(119, 43);
            this.studentlbl.Name = "studentlbl";
            this.studentlbl.Size = new System.Drawing.Size(130, 25);
            this.studentlbl.TabIndex = 15;
            this.studentlbl.Text = "Student Type";
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.feeLbl.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeLbl.Location = new System.Drawing.Point(40, 288);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(128, 25);
            this.feeLbl.TabIndex = 16;
            this.feeLbl.Text = "Hourly Wage";
            // 
            // tbFee
            // 
            this.tbFee.Location = new System.Drawing.Point(174, 288);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(100, 22);
            this.tbFee.TabIndex = 17;
            // 
            // warningLBL
            // 
            this.warningLBL.AutoSize = true;
            this.warningLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(169)))), ((int)(((byte)(172)))));
            this.warningLBL.Location = new System.Drawing.Point(280, 295);
            this.warningLBL.Name = "warningLBL";
            this.warningLBL.Size = new System.Drawing.Size(177, 17);
            this.warningLBL.TabIndex = 18;
            this.warningLBL.Text = "*For Student Workers Only";
            // 
            // NewResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(468, 436);
            this.Controls.Add(this.warningLBL);
            this.Controls.Add(this.tbFee);
            this.Controls.Add(this.feeLbl);
            this.Controls.Add(this.studentlbl);
            this.Controls.Add(this.FloorLabel);
            this.Controls.Add(this.floorsList);
            this.Controls.Add(this.tbDorm);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.DormLabel);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResType);
            this.Name = "NewResident";
            this.Text = "NewResident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ResType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.Label DormLabel;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox tbDorm;
        private System.Windows.Forms.ComboBox floorsList;
        private System.Windows.Forms.Label FloorLabel;
        private System.Windows.Forms.Label studentlbl;
        private System.Windows.Forms.Label feeLbl;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.Label warningLBL;
    }
}