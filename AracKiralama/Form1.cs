using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using AracKiralama;


namespace YBSAutomationExample
{
    
    public partial class Form1 : Form
    {
        private string ConnectionString;
        public Form1()
        {

            InitializeComponent();
            ConnectionString = ConfigurationManager
                .ConnectionStrings["AracKiralamaConnectionString"]
                .ConnectionString;

        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString)) 
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MessageBox.Show("1 saniye sonra yönlendirileceksiniz", "Bağlantı AÇIK",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                Thread.Sleep(1000);
                Form_User_Login_cs form2 = new Form_User_Login_cs();
                this.Hide();
                form2.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata =" + ex);
            }
        }
    }
}
