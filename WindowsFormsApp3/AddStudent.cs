﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void rbAddStudent_CheckedChanged(object sender, EventArgs e)
        {
      
                RadioButton radioBtn = this.Controls.OfType<RadioButton>().Where(x => x.Checked).First();
            
               // if (radioBtn.Enabled == true)
               
               // {

                    
                    switch (radioBtn.Name)
                    {

                        case "rbAddStudent":

                            label1.Text = "Add First Name";
                            label2.Text = "Add Surname";
                            label3.Text = "Add Email";
                            label4.Text = "Add Phone";
                            label5.Text = "Add Address Line 1";
                            label6.Text = "Add Address Line 2";
                            label7.Text = "Add City";
                            label8.Text = "Add County";
                            label9.Text = "Add Level";
                            label10.Text = "Add Course";
                            //label11.Text = "Add Student No.";
                            label11.Text = radioBtn.Name;

                            break;

                        case "rbEditStudent":

                            label1.Text = "Edit First Name";
                            label2.Text = "Edit Surname";
                            label3.Text = "Edit Email";
                            label4.Text = "Edit Phone";
                            label5.Text = "Edit Address Line 1";
                            label6.Text = "Edit Address Line 2";
                            label7.Text = "Edit City";
                            label8.Text = "Edit County";
                            label9.Text = "Edit Level";
                            label10.Text = "Edit Course";
                            // label11.Text = "Edit Student No.";s
                            label11.Text = radioBtn.Name;
                            break;

                        case "rbDeleteStudent":

                            label1.Text = "Delete First Name";
                            label2.Text = "Delete Surname";
                            label3.Text = "Delete Email";
                            label4.Text = "Delete Phone";
                            label5.Text = "Delete Address Line 1";
                            label6.Text = "Delete Address Line 2";
                            label7.Text = "Delete City";
                            label8.Text = "Delete County";
                            label9.Text = "Delete Level";
                            label10.Text = "Delete Course";
                            //label11.Text = "Delete Student No.";
                            label11.Text = radioBtn.Name;
                            break;
                    }
         

            //  }

        }
    }
}
