﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddStudent : Form
    {
        SqlConnection conn;
        Labels labelradio = new Labels();
        public AddStudent()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["orderline"].ConnectionString);
          
        }


        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void rbAddStudent_CheckedChanged(object sender, EventArgs e)
        {
            labelValue(2);

   

          
        }
        private void rbEditStudent_CheckedChanged(object sender, EventArgs e)
        {

             labelValue(1);
         
       
        }

        private void rbDeleteStudent_CheckedChanged(object sender, EventArgs e)
        {

            labelValue(3);
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Student " +
                    "VALUES(@FirstName, @Surname,@Email,@Phone,@AddressL1,@AddressL2,@City,@County,@Level)", conn);
                //cmd.Parameters.AddWithValue("@ID", DBStudNo.Text);
                cmd.Parameters.AddWithValue("@FirstName", DBFirstName.Text);
                cmd.Parameters.AddWithValue("@Surname", DBSurname.Text);
                cmd.Parameters.AddWithValue("@Email", DBEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", DBPhone.Text);
                cmd.Parameters.AddWithValue("@AddressL1", DBAddress1.Text);
                cmd.Parameters.AddWithValue("@AddressL2", DBAddress2.Text);
                cmd.Parameters.AddWithValue("@City", DBCity.Text);
                cmd.Parameters.AddWithValue("@County", DBCounty.Text);
                cmd.Parameters.AddWithValue("@Level", comboxLevel.SelectedItem);



                if (conn.State == ConnectionState.Closed
                    || conn.State == ConnectionState.Broken)
                    conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added");
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void labelValue(int value)
        {

            //better to user a switch statment here
            if (value == 1)
            {

                txtStudID.Visible = true;
                btnLoadStd.Visible = true;
                label11.Visible = true;

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
                label11.Text = "Load Student ID";

                DBAddress1.Enabled = false;
                DBFirstName.Enabled = false;
                DBSurname.Enabled = false;
                DBEmail.Enabled = false;
                DBPhone.Enabled = false;
                DBAddress2.Enabled = false;
                DBCity.Enabled = false;
                DBCounty.Enabled = false;
                DBCourse.Enabled = false;
                comboxLevel.Enabled = false;
            }

            else if (value == 2)
            {
                label11.Visible = false;
                txtStudID.Visible = false;
                btnLoadStd.Visible = false;

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
            

                DBAddress1.Enabled = true;
                DBFirstName.Enabled = true;
                DBSurname.Enabled = true;
                DBEmail.Enabled = true;
                DBPhone.Enabled = true;
                DBAddress2.Enabled = true;
                DBCity.Enabled = true;
                DBCounty.Enabled = true;
                DBCourse.Enabled = true;
                comboxLevel.Enabled = true;
            }

            else if (value == 3)
                    {
                txtStudID.Visible = true;
                btnLoadStd.Visible = true;
                label11.Visible = true;

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
                label11.Text = "Load Student ID";

                DBAddress1.Enabled = false;
                DBFirstName.Enabled = false;
                DBSurname.Enabled = false;
                DBEmail.Enabled = false;
                DBPhone.Enabled = false;
                DBAddress2.Enabled = false;
                DBCity.Enabled = false;
                DBCounty.Enabled = false;
                DBCourse.Enabled = false;
                comboxLevel.Enabled = false;
            }
                    
                

           


        }

        private void btnLoadStd_Click(object sender, EventArgs e)
        {

        }
    }
}