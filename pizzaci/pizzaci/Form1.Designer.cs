namespace pizzaci
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnsiparisver = new System.Windows.Forms.Button();
            this.cbpizzalar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmantar = new System.Windows.Forms.CheckBox();
            this.cbdomates = new System.Windows.Forms.CheckBox();
            this.cbbiber = new System.Windows.Forms.CheckBox();
            this.cbzeytin = new System.Windows.Forms.CheckBox();
            this.cbsosis = new System.Windows.Forms.CheckBox();
            this.cbsalam = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pizzaci.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(22, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "PİZZACI";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(252, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(451, 356);
            this.listBox1.TabIndex = 2;
            // 
            // btnsiparisver
            // 
            this.btnsiparisver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsiparisver.Location = new System.Drawing.Point(22, 492);
            this.btnsiparisver.Name = "btnsiparisver";
            this.btnsiparisver.Size = new System.Drawing.Size(210, 58);
            this.btnsiparisver.TabIndex = 3;
            this.btnsiparisver.Text = "SİPARİŞ VER";
            this.btnsiparisver.UseVisualStyleBackColor = true;
            this.btnsiparisver.Click += new System.EventHandler(this.btnsiparisver_Click);
            // 
            // cbpizzalar
            // 
            this.cbpizzalar.FormattingEnabled = true;
            this.cbpizzalar.Location = new System.Drawing.Point(22, 255);
            this.cbpizzalar.Name = "cbpizzalar";
            this.cbpizzalar.Size = new System.Drawing.Size(204, 24);
            this.cbpizzalar.TabIndex = 4;
            this.cbpizzalar.SelectedIndexChanged += new System.EventHandler(this.cbpizzalar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PİZZALAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmantar);
            this.groupBox1.Controls.Add(this.cbdomates);
            this.groupBox1.Controls.Add(this.cbbiber);
            this.groupBox1.Controls.Add(this.cbzeytin);
            this.groupBox1.Controls.Add(this.cbsosis);
            this.groupBox1.Controls.Add(this.cbsalam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(26, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra";
            // 
            // cbmantar
            // 
            this.cbmantar.AutoSize = true;
            this.cbmantar.Location = new System.Drawing.Point(101, 93);
            this.cbmantar.Name = "cbmantar";
            this.cbmantar.Size = new System.Drawing.Size(83, 24);
            this.cbmantar.TabIndex = 5;
            this.cbmantar.Text = "Mantar";
            this.cbmantar.UseVisualStyleBackColor = true;
            this.cbmantar.CheckedChanged += new System.EventHandler(this.cbmantar_CheckedChanged);
            // 
            // cbdomates
            // 
            this.cbdomates.AutoSize = true;
            this.cbdomates.Location = new System.Drawing.Point(101, 59);
            this.cbdomates.Name = "cbdomates";
            this.cbdomates.Size = new System.Drawing.Size(99, 24);
            this.cbdomates.TabIndex = 4;
            this.cbdomates.Text = "Domates";
            this.cbdomates.UseVisualStyleBackColor = true;
            this.cbdomates.CheckedChanged += new System.EventHandler(this.cbdomates_CheckedChanged);
            // 
            // cbbiber
            // 
            this.cbbiber.AutoSize = true;
            this.cbbiber.Location = new System.Drawing.Point(101, 29);
            this.cbbiber.Name = "cbbiber";
            this.cbbiber.Size = new System.Drawing.Size(71, 24);
            this.cbbiber.TabIndex = 3;
            this.cbbiber.Text = "Biber";
            this.cbbiber.UseVisualStyleBackColor = true;
            this.cbbiber.CheckedChanged += new System.EventHandler(this.cbbiber_CheckedChanged);
            // 
            // cbzeytin
            // 
            this.cbzeytin.AutoSize = true;
            this.cbzeytin.Location = new System.Drawing.Point(9, 93);
            this.cbzeytin.Name = "cbzeytin";
            this.cbzeytin.Size = new System.Drawing.Size(75, 24);
            this.cbzeytin.TabIndex = 2;
            this.cbzeytin.Text = "Zeytin";
            this.cbzeytin.UseVisualStyleBackColor = true;
            this.cbzeytin.CheckedChanged += new System.EventHandler(this.cbzeytin_CheckedChanged);
            // 
            // cbsosis
            // 
            this.cbsosis.AutoSize = true;
            this.cbsosis.Location = new System.Drawing.Point(9, 59);
            this.cbsosis.Name = "cbsosis";
            this.cbsosis.Size = new System.Drawing.Size(73, 24);
            this.cbsosis.TabIndex = 1;
            this.cbsosis.Text = "Sosis";
            this.cbsosis.UseVisualStyleBackColor = true;
            this.cbsosis.CheckedChanged += new System.EventHandler(this.cbsosis_CheckedChanged);
            // 
            // cbsalam
            // 
            this.cbsalam.AutoSize = true;
            this.cbsalam.Location = new System.Drawing.Point(9, 29);
            this.cbsalam.Name = "cbsalam";
            this.cbsalam.Size = new System.Drawing.Size(78, 24);
            this.cbsalam.TabIndex = 0;
            this.cbsalam.Text = "Salam";
            this.cbsalam.UseVisualStyleBackColor = true;
            this.cbsalam.CheckedChanged += new System.EventHandler(this.cbsalam_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(250, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam Tutar : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(538, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(407, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "SİPARİŞİ TAMAMLA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(447, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbpizzalar);
            this.Controls.Add(this.btnsiparisver);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnsiparisver;
        private System.Windows.Forms.ComboBox cbpizzalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbmantar;
        private System.Windows.Forms.CheckBox cbdomates;
        private System.Windows.Forms.CheckBox cbbiber;
        private System.Windows.Forms.CheckBox cbzeytin;
        private System.Windows.Forms.CheckBox cbsosis;
        private System.Windows.Forms.CheckBox cbsalam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

