namespace WindowsFormsApp3
{
    partial class AddStudent
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
            this.rbAddStudent = new System.Windows.Forms.RadioButton();
            this.rbEditStudent = new System.Windows.Forms.RadioButton();
            this.rbDeleteStudent = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.DBSurname = new System.Windows.Forms.TextBox();
            this.DBFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DBEmail = new System.Windows.Forms.TextBox();
            this.DBPhone = new System.Windows.Forms.TextBox();
            this.DBAddress1 = new System.Windows.Forms.TextBox();
            this.DBAddress2 = new System.Windows.Forms.TextBox();
            this.DBCity = new System.Windows.Forms.TextBox();
            this.DBCounty = new System.Windows.Forms.TextBox();
            this.DBLevel = new System.Windows.Forms.TextBox();
            this.DBCourse = new System.Windows.Forms.TextBox();
            this.DBStudNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // rbAddStudent
            // 
            this.rbAddStudent.AutoSize = true;
            this.rbAddStudent.Location = new System.Drawing.Point(872, 17);
            this.rbAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAddStudent.Name = "rbAddStudent";
            this.rbAddStudent.Size = new System.Drawing.Size(107, 21);
            this.rbAddStudent.TabIndex = 2;
            this.rbAddStudent.TabStop = true;
            this.rbAddStudent.Text = "Add Student";
            this.rbAddStudent.UseVisualStyleBackColor = true;
            this.rbAddStudent.CheckedChanged += new System.EventHandler(this.rbAddStudent_CheckedChanged);
            // 
            // rbEditStudent
            // 
            this.rbEditStudent.AutoSize = true;
            this.rbEditStudent.Location = new System.Drawing.Point(872, 46);
            this.rbEditStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEditStudent.Name = "rbEditStudent";
            this.rbEditStudent.Size = new System.Drawing.Size(106, 21);
            this.rbEditStudent.TabIndex = 3;
            this.rbEditStudent.TabStop = true;
            this.rbEditStudent.Text = "Edit Student";
            this.rbEditStudent.UseVisualStyleBackColor = true;
            // 
            // rbDeleteStudent
            // 
            this.rbDeleteStudent.AutoSize = true;
            this.rbDeleteStudent.Location = new System.Drawing.Point(872, 74);
            this.rbDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDeleteStudent.Name = "rbDeleteStudent";
            this.rbDeleteStudent.Size = new System.Drawing.Size(123, 21);
            this.rbDeleteStudent.TabIndex = 4;
            this.rbDeleteStudent.TabStop = true;
            this.rbDeleteStudent.Text = "Delete Student";
            this.rbDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(696, 405);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DBSurname
            // 
            this.DBSurname.Location = new System.Drawing.Point(281, 160);
            this.DBSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBSurname.Name = "DBSurname";
            this.DBSurname.Size = new System.Drawing.Size(132, 22);
            this.DBSurname.TabIndex = 6;
            this.DBSurname.Text = "Surname";
            // 
            // DBFirstName
            // 
            this.DBFirstName.Location = new System.Drawing.Point(281, 112);
            this.DBFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBFirstName.Name = "DBFirstName";
            this.DBFirstName.Size = new System.Drawing.Size(132, 22);
            this.DBFirstName.TabIndex = 7;
            this.DBFirstName.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "label10";
            // 
            // DBEmail
            // 
            this.DBEmail.Location = new System.Drawing.Point(281, 207);
            this.DBEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBEmail.Name = "DBEmail";
            this.DBEmail.Size = new System.Drawing.Size(132, 22);
            this.DBEmail.TabIndex = 17;
            this.DBEmail.Text = "Email";
            // 
            // DBPhone
            // 
            this.DBPhone.Location = new System.Drawing.Point(281, 255);
            this.DBPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBPhone.Name = "DBPhone";
            this.DBPhone.Size = new System.Drawing.Size(132, 22);
            this.DBPhone.TabIndex = 16;
            this.DBPhone.Text = "Phone";
            // 
            // DBAddress1
            // 
            this.DBAddress1.Location = new System.Drawing.Point(281, 295);
            this.DBAddress1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBAddress1.Name = "DBAddress1";
            this.DBAddress1.Size = new System.Drawing.Size(132, 22);
            this.DBAddress1.TabIndex = 19;
            this.DBAddress1.Text = "Address Line 1";
            // 
            // DBAddress2
            // 
            this.DBAddress2.Location = new System.Drawing.Point(281, 343);
            this.DBAddress2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBAddress2.Name = "DBAddress2";
            this.DBAddress2.Size = new System.Drawing.Size(132, 22);
            this.DBAddress2.TabIndex = 18;
            this.DBAddress2.Text = "Address Line 2";
            // 
            // DBCity
            // 
            this.DBCity.Location = new System.Drawing.Point(663, 111);
            this.DBCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBCity.Name = "DBCity";
            this.DBCity.Size = new System.Drawing.Size(132, 22);
            this.DBCity.TabIndex = 21;
            this.DBCity.Text = "City";
            // 
            // DBCounty
            // 
            this.DBCounty.Location = new System.Drawing.Point(663, 159);
            this.DBCounty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBCounty.Name = "DBCounty";
            this.DBCounty.Size = new System.Drawing.Size(132, 22);
            this.DBCounty.TabIndex = 20;
            this.DBCounty.Text = "County";
            // 
            // DBLevel
            // 
            this.DBLevel.Location = new System.Drawing.Point(663, 210);
            this.DBLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBLevel.Name = "DBLevel";
            this.DBLevel.Size = new System.Drawing.Size(132, 22);
            this.DBLevel.TabIndex = 23;
            this.DBLevel.Text = "Level";
            // 
            // DBCourse
            // 
            this.DBCourse.Location = new System.Drawing.Point(663, 258);
            this.DBCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBCourse.Name = "DBCourse";
            this.DBCourse.Size = new System.Drawing.Size(132, 22);
            this.DBCourse.TabIndex = 22;
            this.DBCourse.Text = "Course";
            // 
            // DBStudNo
            // 
            this.DBStudNo.Location = new System.Drawing.Point(663, 304);
            this.DBStudNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DBStudNo.Name = "DBStudNo";
            this.DBStudNo.Size = new System.Drawing.Size(132, 22);
            this.DBStudNo.TabIndex = 25;
            this.DBStudNo.Text = "Student No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 313);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "label11";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DBStudNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DBLevel);
            this.Controls.Add(this.DBCourse);
            this.Controls.Add(this.DBCity);
            this.Controls.Add(this.DBCounty);
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
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbDeleteStudent);
            this.Controls.Add(this.rbEditStudent);
            this.Controls.Add(this.rbAddStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAddStudent;
        private System.Windows.Forms.RadioButton rbEditStudent;
        private System.Windows.Forms.RadioButton rbDeleteStudent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox DBSurname;
        private System.Windows.Forms.TextBox DBFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DBEmail;
        private System.Windows.Forms.TextBox DBPhone;
        private System.Windows.Forms.TextBox DBAddress1;
        private System.Windows.Forms.TextBox DBAddress2;
        private System.Windows.Forms.TextBox DBCity;
        private System.Windows.Forms.TextBox DBCounty;
        private System.Windows.Forms.TextBox DBLevel;
        private System.Windows.Forms.TextBox DBCourse;
        private System.Windows.Forms.TextBox DBStudNo;
        private System.Windows.Forms.Label label11;
    }
}