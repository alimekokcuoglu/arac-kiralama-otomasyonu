using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace AracKiralamAutomationExample
{
    public partial class Form_User_Login : Form
    {
        private string connectionString;
        public Form_User_Login()
        {
            InitializeComponent();
            connectionString =
                ConfigurationManager.ConnectionStrings["AracKiralamaConnectionString"].ConnectionString;
        }
        private void ComboLoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)
)
                {
                    string query1 = "SELECT DISTINCT Pozisyon FROM Table_Personeller";

                    SqlDataAdapter da1 = new SqlDataAdapter(query1, connection);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    combo_orientation.DataSource = dt1;
                    combo_orientation.DisplayMember = "Pozisyon";
                    combo_orientation.ValueMember = "Pozisyon";


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata=" + ex);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string p_name = txt_name.Text.ToString();
            string p_surname = txt_surname.Text.ToString();
            string p_tel = masked_tel.Text.ToString();
            p_tel = p_tel.Replace("(", "").Replace(")", "").Replace("_", "");
            p_tel = "0" + p_tel;
            string p_orientation = combo_orientation.Text.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)
)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Personeller_Insert_Into", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@personel_ad", p_name);
                        cmd.Parameters.AddWithValue("@personel_soyad", p_surname);
                        cmd.Parameters.AddWithValue("@personel_telefon", p_tel);
                        cmd.Parameters.AddWithValue("@personel_pozisyon", p_orientation);

                        connection.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt başarıyla eklendi!");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata = + ex");
            }

        }

        private void Form_User_Login_Load(object sender, EventArgs e)
        {

            combo_orientation.DataSource = null;
            combo_orientation.Items.Clear();

            ComboLoadData();
            combo_orientation.SelectedIndex = -1;
        }


        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Personeller_Select", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        connection.Open();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata = " + ex);
            }
        }

        private void btn_starting_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int p_id = int.Parse(selectedRow.Cells[0].Value.ToString());
                string p_name = selectedRow.Cells[1].Value.ToString();
                string p_surname = selectedRow.Cells[2].Value.ToString();
                string p_tel = selectedRow.Cells[3].Value.ToString();
                string p_orientation = selectedRow.Cells[4].Value.ToString();

                if (p_tel.StartsWith("0"))
                {
                    p_tel = p_tel.Remove(0, 1);
                    p_tel = p_tel.Replace("(", "").Replace(")", "").Replace("_", "").Replace(" ", "");
                }
                try
                {
                    txt_name.Text = p_name;
                    txt_surname.Text = p_surname;
                    combo_orientation.SelectedIndex = combo_orientation.FindStringExact(p_orientation);
                    masked_tel.Text = p_tel;




                }


                catch (Exception ex)
                {
                    MessageBox.Show("Aktarma işlemi esnasında hata oluştu: " + ex.Message);
                }
            }
            else
            {

                MessageBox.Show("Lütfen, güncellemek için bir kayıt seçiniz");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int selected_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            string p_name = txt_name.Text;
            string p_surname = txt_surname.Text;
            string selectedValue_orientation = combo_orientation.SelectedItem.ToString();
            string p_orientation = combo_orientation.Text;
            int selectedIndex_orientation = combo_orientation.SelectedIndex + 1;

            string p_tel = masked_tel.Text.ToString();

            p_tel = p_tel.Replace("(", "").Replace(")", "").Replace("_", "").Replace(" ", "");
            if (!p_tel.StartsWith("0"))
            {
                p_tel = "0" + p_tel;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Personeller_Update", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonelId", selected_ID);
                        cmd.Parameters.AddWithValue("@personel_ad", p_name);
                        cmd.Parameters.AddWithValue("@personel_soyad", p_surname);
                        cmd.Parameters.AddWithValue("@personel_pozisyon", combo_orientation.Text);
                        cmd.Parameters.AddWithValue("@personel_telefon", p_tel);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi esnasında hata oluştu: " + ex.Message);

            }

        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Table_Personel_Delete", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Silme işlemi esnasında bir sorun oluştu: " + ex.Message);
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?");

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Table_Personeller_Delete", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@PersonelID", selectedRowID);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kayıt Silme işlemi başarıyla gerçekleşti!");

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Silme işlemi esnasında bir sorun oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir kayıt seçiniz.");


            }
        }

        private void rb_max_price_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_max_price.Checked)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_EnCokKiralamaYapanMusteri", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

        }

        private void rb_most_rent_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_most_rent.Checked)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_EnYuksekTutarliKiralama", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void combo_orientation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





