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


namespace AracKiralama
{
    public partial class Form_User_Login_cs : Form
    {
        private string connectionString;
        public Form_User_Login_cs()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString;
        }

        private void ComboLoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)
)
                {
                    string query1 = "SELECT city_name FROM Table_Cities";
                    SqlDataAdapter da1 = new SqlDataAdapter (query1, connection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    combo_city.DataSource = dt1;
                    combo_city.DisplayMember = "city_name";
                    combo_city.ValueMember = "city_name";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata = " +ex);
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string c_name = txt_ad.Text.ToString();
            string c_surname = txt_soyad.Text.ToString();
            string c_city = combo_city.SelectedValue.ToString();
            int c_city_id = combo_city.SelectedIndex + 1;
            string c_tel = txt_telefon.Text.ToString();
            c_tel = c_tel.Replace("(", "").Replace(")", "").Replace("_", "");
            c_tel = "0" + c_tel;
            string c_mail = txt_email.Text.ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmdMusteri = new SqlCommand("sp_new_Insert_Into_Table_Musteriler", connection)
)
                    {
                        cmdMusteri.CommandType = CommandType.StoredProcedure;
                        cmdMusteri.Parameters.AddWithValue("@ad", c_name);
                        cmdMusteri.Parameters.AddWithValue("@soyad", c_surname);
                        cmdMusteri.Parameters.AddWithValue("@telefon", c_tel);
                        cmdMusteri.Parameters.AddWithValue("@mail", c_mail);

                        cmdMusteri.ExecuteNonQuery();

                    }
                    using (SqlCommand cmdCity = new SqlCommand("sp_new_insert_Table_Cities", connection))
                    {

                        cmdCity.CommandType = CommandType.StoredProcedure;
                        cmdCity.Parameters.AddWithValue("city_name", c_city_id);



                        cmdCity.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla eklendi!");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata=" + ex);

            }
        }

        private void btn_new_user_add_Click (object sender, EventArgs e)
        {
            ComboLoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void combo_city_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_soyad_Click(object sender, EventArgs e)
        {

        }
    }
}
