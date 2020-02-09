using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class StudXML : Form
    {
        SqlConnection conn;
        public StudXML()
        {
           
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["orderline"].ConnectionString);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {


            try
            {
                conn.Open();
                MessageBox.Show("Connected");
                SqlCommand cmd = new SqlCommand("CREATE TABLE Student(" +
                    "ID int IDENTITY(1,1) PRIMARY KEY, FirstName VARCHAR(20), Surname VARCHAR(20), Email VARCHAR(20), Phone  VARCHAR(10), AddressL1 VARCHAR (50), AddressL2 VARCHAR (50), City VARCHAR (20), County VARCHAR (20), Level INT );", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
