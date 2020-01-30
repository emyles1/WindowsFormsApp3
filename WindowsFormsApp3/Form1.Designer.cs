namespace WindowsFormsApp3
{
    partial class btnCreateAdminDB
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
            this.buttonCreateTables = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonShowCustomer = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnAdminCreateDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateTables
            // 
            this.buttonCreateTables.Location = new System.Drawing.Point(42, 42);
            this.buttonCreateTables.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateTables.Name = "buttonCreateTables";
            this.buttonCreateTables.Size = new System.Drawing.Size(127, 28);
            this.buttonCreateTables.TabIndex = 0;
            this.buttonCreateTables.Text = "Create Student DB";
            this.buttonCreateTables.UseVisualStyleBackColor = true;
            this.buttonCreateTables.Click += new System.EventHandler(this.buttonCreateTables_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(51, 94);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(127, 28);
            this.buttonAddCustomer.TabIndex = 1;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonShowCustomer
            // 
            this.buttonShowCustomer.Location = new System.Drawing.Point(51, 145);
            this.buttonShowCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowCustomer.Name = "buttonShowCustomer";
            this.buttonShowCustomer.Size = new System.Drawing.Size(127, 28);
            this.buttonShowCustomer.TabIndex = 2;
            this.buttonShowCustomer.Text = "Show Customers";
            this.buttonShowCustomer.UseVisualStyleBackColor = true;
            this.buttonShowCustomer.Click += new System.EventHandler(this.buttonShowCustomer_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(267, 42);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(175, 28);
            this.btnAddAdmin.TabIndex = 3;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnAdminCreateDB
            // 
            this.btnAdminCreateDB.Location = new System.Drawing.Point(267, 94);
            this.btnAdminCreateDB.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminCreateDB.Name = "btnAdminCreateDB";
            this.btnAdminCreateDB.Size = new System.Drawing.Size(175, 28);
            this.btnAdminCreateDB.TabIndex = 4;
            this.btnAdminCreateDB.Text = "Create Admin DB";
            this.btnAdminCreateDB.UseVisualStyleBackColor = true;
            this.btnAdminCreateDB.Click += new System.EventHandler(this.btnAdminCreateDB_Click);
            // 
            // btnCreateAdminDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 390);
            this.Controls.Add(this.btnAdminCreateDB);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.buttonShowCustomer);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.buttonCreateTables);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "btnCreateAdminDB";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTables;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonShowCustomer;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnAdminCreateDB;
    }
}

