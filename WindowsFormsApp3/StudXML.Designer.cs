namespace WindowsFormsApp3
{
    partial class StudXML
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSaveTo = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.DBAddress1 = new System.Windows.Forms.TextBox();
            this.DBAddress2 = new System.Windows.Forms.TextBox();
            this.DBEmail = new System.Windows.Forms.TextBox();
            this.DBPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DBFirstName = new System.Windows.Forms.TextBox();
            this.DBSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxLevel = new System.Windows.Forms.ComboBox();
            this.DBCourse = new System.Windows.Forms.TextBox();
            this.DBCity = new System.Windows.Forms.TextBox();
            this.DBCounty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(559, 93);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(151, 25);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load from Database";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(331, 93);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 22);
            this.txtID.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(174, 101);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(110, 17);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Enter Student Id";
            // 
            // lblSaveTo
            // 
            this.lblSaveTo.AutoSize = true;
            this.lblSaveTo.Location = new System.Drawing.Point(494, 503);
            this.lblSaveTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveTo.Name = "lblSaveTo";
            this.lblSaveTo.Size = new System.Drawing.Size(88, 17);
            this.lblSaveTo.TabIndex = 3;
            this.lblSaveTo.Text = "Save XML to";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(651, 498);
            this.txtFN.Margin = new System.Windows.Forms.Padding(4);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(175, 22);
            this.txtFN.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(879, 498);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save to";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(87, 37);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 151);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "label11";
            // 
            // txtStudID
            // 
            this.txtStudID.Location = new System.Drawing.Point(358, 151);
            this.txtStudID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(132, 22);
            this.txtStudID.TabIndex = 45;
            // 
            // DBAddress1
            // 
            this.DBAddress1.Location = new System.Drawing.Point(358, 373);
            this.DBAddress1.Margin = new System.Windows.Forms.Padding(4);
            this.DBAddress1.Name = "DBAddress1";
            this.DBAddress1.Size = new System.Drawing.Size(132, 22);
            this.DBAddress1.TabIndex = 43;
            // 
            // DBAddress2
            // 
            this.DBAddress2.Location = new System.Drawing.Point(358, 421);
            this.DBAddress2.Margin = new System.Windows.Forms.Padding(4);
            this.DBAddress2.Name = "DBAddress2";
            this.DBAddress2.Size = new System.Drawing.Size(132, 22);
            this.DBAddress2.TabIndex = 44;
            // 
            // DBEmail
            // 
            this.DBEmail.Location = new System.Drawing.Point(358, 285);
            this.DBEmail.Margin = new System.Windows.Forms.Padding(4);
            this.DBEmail.Name = "DBEmail";
            this.DBEmail.Size = new System.Drawing.Size(132, 22);
            this.DBEmail.TabIndex = 41;
            // 
            // DBPhone
            // 
            this.DBPhone.Location = new System.Drawing.Point(358, 333);
            this.DBPhone.Margin = new System.Windows.Forms.Padding(4);
            this.DBPhone.Name = "DBPhone";
            this.DBPhone.Size = new System.Drawing.Size(132, 22);
            this.DBPhone.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 345);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 297);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "label3";
            // 
            // DBFirstName
            // 
            this.DBFirstName.Location = new System.Drawing.Point(358, 190);
            this.DBFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.DBFirstName.Name = "DBFirstName";
            this.DBFirstName.Size = new System.Drawing.Size(132, 22);
            this.DBFirstName.TabIndex = 39;
            // 
            // DBSurname
            // 
            this.DBSurname.Location = new System.Drawing.Point(358, 238);
            this.DBSurname.Margin = new System.Windows.Forms.Padding(4);
            this.DBSurname.Name = "DBSurname";
            this.DBSurname.Size = new System.Drawing.Size(132, 22);
            this.DBSurname.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // comboxLevel
            // 
            this.comboxLevel.FormattingEnabled = true;
            this.comboxLevel.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboxLevel.Location = new System.Drawing.Point(651, 293);
            this.comboxLevel.Margin = new System.Windows.Forms.Padding(4);
            this.comboxLevel.Name = "comboxLevel";
            this.comboxLevel.Size = new System.Drawing.Size(132, 24);
            this.comboxLevel.TabIndex = 49;
            // 
            // DBCourse
            // 
            this.DBCourse.Location = new System.Drawing.Point(651, 344);
            this.DBCourse.Margin = new System.Windows.Forms.Padding(4);
            this.DBCourse.Name = "DBCourse";
            this.DBCourse.Size = new System.Drawing.Size(132, 22);
            this.DBCourse.TabIndex = 50;
            // 
            // DBCity
            // 
            this.DBCity.Location = new System.Drawing.Point(651, 197);
            this.DBCity.Margin = new System.Windows.Forms.Padding(4);
            this.DBCity.Name = "DBCity";
            this.DBCity.Size = new System.Drawing.Size(132, 22);
            this.DBCity.TabIndex = 47;
            // 
            // DBCounty
            // 
            this.DBCounty.Location = new System.Drawing.Point(651, 245);
            this.DBCounty.Margin = new System.Windows.Forms.Padding(4);
            this.DBCounty.Name = "DBCounty";
            this.DBCounty.Size = new System.Drawing.Size(132, 22);
            this.DBCounty.TabIndex = 48;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(879, 101);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(879, 191);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 28);
            this.btnView.TabIndex = 52;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // StudXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboxLevel);
            this.Controls.Add(this.DBCourse);
            this.Controls.Add(this.DBCity);
            this.Controls.Add(this.DBCounty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStudID);
            this.Controls.Add(this.DBAddress1);
            this.Controls.Add(this.DBAddress2);
            this.Controls.Add(this.DBEmail);
            this.Controls.Add(this.DBPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DBFirstName);
            this.Controls.Add(this.DBSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblSaveTo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudXML";
            this.Text = "StudXML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSaveTo;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.TextBox DBAddress1;
        private System.Windows.Forms.TextBox DBAddress2;
        private System.Windows.Forms.TextBox DBEmail;
        private System.Windows.Forms.TextBox DBPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DBFirstName;
        private System.Windows.Forms.TextBox DBSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxLevel;
        private System.Windows.Forms.TextBox DBCourse;
        private System.Windows.Forms.TextBox DBCity;
        private System.Windows.Forms.TextBox DBCounty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
    }
}