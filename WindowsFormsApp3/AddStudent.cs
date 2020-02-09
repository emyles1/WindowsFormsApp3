using System;
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

          
        }
        private void rbEditStudent_CheckedChanged(object sender, EventArgs e)
        {
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

            labelradio = new Labels("Eamon", "Surname", "Email", "Phone", "123 Fakestreet");
            MessageBox.Show(labelradio.Firstname);
        }

        private void rbDeleteStudent_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}