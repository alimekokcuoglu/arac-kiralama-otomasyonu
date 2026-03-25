namespace AracKiralama
{
    partial class Form_User_Login_cs
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
            this.txt_ad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.txt_ehliyet_no = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_new_user_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_city = new System.Windows.Forms.ComboBox();
            this.txt_city_name = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.AutoSize = true;
            this.txt_ad.Location = new System.Drawing.Point(47, 130);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(49, 16);
            this.txt_ad.TabIndex = 0;
            this.txt_ad.Text = "Adınız :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.AutoSize = true;
            this.txt_soyad.Location = new System.Drawing.Point(47, 183);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(72, 16);
            this.txt_soyad.TabIndex = 1;
            this.txt_soyad.Text = "Soyadınız :";
            this.txt_soyad.Click += new System.EventHandler(this.txt_soyad_Click);
            // 
            // txt_telefon
            // 
            this.txt_telefon.AutoSize = true;
            this.txt_telefon.Location = new System.Drawing.Point(47, 230);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(59, 16);
            this.txt_telefon.TabIndex = 2;
            this.txt_telefon.Text = "Telefon :";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(47, 280);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(47, 16);
            this.txt_email.TabIndex = 3;
            this.txt_email.Text = "Email :";
            // 
            // txt_ehliyet_no
            // 
            this.txt_ehliyet_no.AutoSize = true;
            this.txt_ehliyet_no.Location = new System.Drawing.Point(47, 324);
            this.txt_ehliyet_no.Name = "txt_ehliyet_no";
            this.txt_ehliyet_no.Size = new System.Drawing.Size(74, 16);
            this.txt_ehliyet_no.TabIndex = 4;
            this.txt_ehliyet_no.Text = "Ehliyet No :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 318);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 22);
            this.textBox4.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(142, 227);
            this.maskedTextBox1.Mask = "(999) 999 99 99 ";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(224, 22);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // btn_new_user_add
            // 
            this.btn_new_user_add.Location = new System.Drawing.Point(494, 371);
            this.btn_new_user_add.Name = "btn_new_user_add";
            this.btn_new_user_add.Size = new System.Drawing.Size(131, 37);
            this.btn_new_user_add.TabIndex = 10;
            this.btn_new_user_add.Text = "KAYDOL";
            this.btn_new_user_add.UseVisualStyleBackColor = true;
            this.btn_new_user_add.Click += new System.EventHandler(this.btn_new_user_add_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(294, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // combo_city
            // 
            this.combo_city.FormattingEnabled = true;
            this.combo_city.Location = new System.Drawing.Point(142, 378);
            this.combo_city.Name = "combo_city";
            this.combo_city.Size = new System.Drawing.Size(224, 24);
            this.combo_city.TabIndex = 12;
            this.combo_city.SelectedIndexChanged += new System.EventHandler(this.combo_city_SelectedIndexChanged);
            // 
            // txt_city_name
            // 
            this.txt_city_name.AutoSize = true;
            this.txt_city_name.Location = new System.Drawing.Point(47, 381);
            this.txt_city_name.Name = "txt_city_name";
            this.txt_city_name.Size = new System.Drawing.Size(49, 16);
            this.txt_city_name.TabIndex = 13;
            this.txt_city_name.Text = "Adres :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(197, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 299);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(546, 209);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // Form_User_Login_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txt_city_name);
            this.Controls.Add(this.combo_city);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_new_user_add);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_ehliyet_no);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Name = "Form_User_Login_cs";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form_User_Login_cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_ad;
        private System.Windows.Forms.Label txt_soyad;
        private System.Windows.Forms.Label txt_telefon;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Label txt_ehliyet_no;
        private System.Windows.Forms.Label txt_city_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btn_new_user_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_city;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}