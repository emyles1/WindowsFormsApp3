using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddAdminForm : Form
    {
        SqlConnection conn;
        public AddAdminForm(System.Data.SqlClient.SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Admin " +
                    "VALUES(@ID,@Name)", conn);
                cmd.Parameters.AddWithValue("@ID", txtAddAdminPass.Text);
                cmd.Parameters.AddWithValue("@Name", txtAdminName.Text);

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
    }
}
