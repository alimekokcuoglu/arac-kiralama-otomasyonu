namespace AracKiralamAutomationExample
{
    partial class Form_User_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.masked_tel = new System.Windows.Forms.MaskedTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_orientation = new System.Windows.Forms.ComboBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_starting_update = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.rb_max_price = new System.Windows.Forms.RadioButton();
            this.rb_most_rent = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pozisyon :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(134, 211);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(202, 22);
            this.txt_name.TabIndex = 4;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(134, 263);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(202, 22);
            this.txt_surname.TabIndex = 5;
            // 
            // masked_tel
            // 
            this.masked_tel.Location = new System.Drawing.Point(134, 307);
            this.masked_tel.Mask = "(999) 999 99 99";
            this.masked_tel.Name = "masked_tel";
            this.masked_tel.Size = new System.Drawing.Size(202, 22);
            this.masked_tel.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.Location = new System.Drawing.Point(87, 435);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(202, 86);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "KAYDOL";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 177);
            this.dataGridView1.TabIndex = 9;
            // 
            // combo_orientation
            // 
            this.combo_orientation.FormattingEnabled = true;
            this.combo_orientation.Items.AddRange(new object[] {
            "Operasyon Sorumlusu",
            "Muhasebe Personeli"});
            this.combo_orientation.Location = new System.Drawing.Point(134, 363);
            this.combo_orientation.Name = "combo_orientation";
            this.combo_orientation.Size = new System.Drawing.Size(202, 24);
            this.combo_orientation.TabIndex = 10;
            this.combo_orientation.SelectedIndexChanged += new System.EventHandler(this.combo_orientation_SelectedIndexChanged);
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_select.Location = new System.Drawing.Point(606, 213);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(177, 37);
            this.btn_select.TabIndex = 11;
            this.btn_select.Text = "LİSTELE";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.Location = new System.Drawing.Point(606, 363);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(177, 45);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_starting_update
            // 
            this.btn_starting_update.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_starting_update.Location = new System.Drawing.Point(606, 435);
            this.btn_starting_update.Name = "btn_starting_update";
            this.btn_starting_update.Size = new System.Drawing.Size(177, 91);
            this.btn_starting_update.TabIndex = 13;
            this.btn_starting_update.Text = "GÜNCELLEME BAŞLAT";
            this.btn_starting_update.UseVisualStyleBackColor = true;
            this.btn_starting_update.Click += new System.EventHandler(this.btn_starting_update_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(606, 286);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(177, 43);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // rb_max_price
            // 
            this.rb_max_price.AutoSize = true;
            this.rb_max_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_max_price.Location = new System.Drawing.Point(947, 286);
            this.rb_max_price.Name = "rb_max_price";
            this.rb_max_price.Size = new System.Drawing.Size(190, 24);
            this.rb_max_price.TabIndex = 15;
            this.rb_max_price.TabStop = true;
            this.rb_max_price.Text = "En Pahalı Kiralama";
            this.rb_max_price.UseVisualStyleBackColor = true;
            this.rb_max_price.CheckedChanged += new System.EventHandler(this.rb_max_price_CheckedChanged);
            // 
            // rb_most_rent
            // 
            this.rb_most_rent.AutoSize = true;
            this.rb_most_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_most_rent.Location = new System.Drawing.Point(947, 381);
            this.rb_most_rent.Name = "rb_most_rent";
            this.rb_most_rent.Size = new System.Drawing.Size(165, 24);
            this.rb_most_rent.TabIndex = 16;
            this.rb_most_rent.TabStop = true;
            this.rb_most_rent.Text = "En Aktif Müşteri";
            this.rb_most_rent.UseVisualStyleBackColor = true;
            this.rb_most_rent.CheckedChanged += new System.EventHandler(this.rb_most_rent_CheckedChanged);
            // 
            // Form_User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracKiralamAutomationExample.Properties.Resources.Ekran_görüntüsü_2025_12_24_032804;
            this.ClientSize = new System.Drawing.Size(1211, 578);
            this.Controls.Add(this.rb_most_rent);
            this.Controls.Add(this.rb_max_price);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_starting_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.combo_orientation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.masked_tel);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_User_Login";
            this.Text = "Form_User_Login";
            this.Load += new System.EventHandler(this.Form_User_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.MaskedTextBox masked_tel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_orientation;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_starting_update;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.RadioButton rb_max_price;
        private System.Windows.Forms.RadioButton rb_most_rent;
    }
}