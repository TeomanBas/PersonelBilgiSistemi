namespace PersonelBilgiSistemi
{
    partial class PersonelBlgiEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelBlgiEkrani));
            groupBox1 = new GroupBox();
            button1 = new Button();
            mtxttc = new MaskedTextBox();
            cmbmeslek = new ComboBox();
            cmbsehir = new ComboBox();
            btntemizle = new Button();
            btnguncelle = new Button();
            btnpersil = new Button();
            btnperekle = new Button();
            rbbekar = new RadioButton();
            rbevli = new RadioButton();
            txtmaas = new TextBox();
            txtsoyad = new TextBox();
            txtad = new TextBox();
            txtid = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnmeslekguncelle = new Button();
            btnmesleksil = new Button();
            btnmeslekekle = new Button();
            label10 = new Label();
            label9 = new Label();
            txtmeslek = new TextBox();
            txtmid = new TextBox();
            groupBox3 = new GroupBox();
            btnara = new Button();
            txtara = new TextBox();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(mtxttc);
            groupBox1.Controls.Add(cmbmeslek);
            groupBox1.Controls.Add(cmbsehir);
            groupBox1.Controls.Add(btntemizle);
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(btnpersil);
            groupBox1.Controls.Add(btnperekle);
            groupBox1.Controls.Add(rbbekar);
            groupBox1.Controls.Add(rbevli);
            groupBox1.Controls.Add(txtmaas);
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 344);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // button1
            // 
            button1.Location = new Point(314, 186);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "İstatistik";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mtxttc
            // 
            mtxttc.Location = new Point(124, 147);
            mtxttc.Mask = "00000000000";
            mtxttc.Name = "mtxttc";
            mtxttc.Size = new Size(130, 23);
            mtxttc.TabIndex = 24;
            mtxttc.ValidatingType = typeof(int);
            // 
            // cmbmeslek
            // 
            cmbmeslek.FormattingEnabled = true;
            cmbmeslek.Location = new Point(124, 222);
            cmbmeslek.Name = "cmbmeslek";
            cmbmeslek.Size = new Size(130, 23);
            cmbmeslek.TabIndex = 23;
            // 
            // cmbsehir
            // 
            cmbsehir.FormattingEnabled = true;
            cmbsehir.Items.AddRange(new object[] { "izmir" });
            cmbsehir.Location = new Point(124, 187);
            cmbsehir.Name = "cmbsehir";
            cmbsehir.Size = new Size(130, 23);
            cmbsehir.TabIndex = 22;
            // 
            // btntemizle
            // 
            btntemizle.Location = new Point(314, 146);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(75, 23);
            btntemizle.TabIndex = 20;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = true;
            btntemizle.Click += btntemizle_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.Location = new Point(314, 107);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(75, 23);
            btnguncelle.TabIndex = 19;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnpersil
            // 
            btnpersil.Location = new Point(314, 68);
            btnpersil.Name = "btnpersil";
            btnpersil.Size = new Size(75, 23);
            btnpersil.TabIndex = 18;
            btnpersil.Text = "Sil";
            btnpersil.UseVisualStyleBackColor = true;
            btnpersil.Click += btnpersil_Click;
            // 
            // btnperekle
            // 
            btnperekle.Location = new Point(314, 29);
            btnperekle.Name = "btnperekle";
            btnperekle.Size = new Size(75, 23);
            btnperekle.TabIndex = 17;
            btnperekle.Text = "Ekle";
            btnperekle.UseVisualStyleBackColor = true;
            btnperekle.Click += btnperekle_Click;
            // 
            // rbbekar
            // 
            rbbekar.AutoSize = true;
            rbbekar.Location = new Point(173, 304);
            rbbekar.Name = "rbbekar";
            rbbekar.Size = new Size(54, 19);
            rbbekar.TabIndex = 16;
            rbbekar.TabStop = true;
            rbbekar.Text = "Bekar";
            rbbekar.UseVisualStyleBackColor = true;
            rbbekar.CheckedChanged += rbbekar_CheckedChanged;
            // 
            // rbevli
            // 
            rbevli.AutoSize = true;
            rbevli.Location = new Point(124, 304);
            rbevli.Name = "rbevli";
            rbevli.Size = new Size(43, 19);
            rbevli.TabIndex = 15;
            rbevli.TabStop = true;
            rbevli.Text = "Evli";
            rbevli.UseVisualStyleBackColor = true;
            rbevli.CheckedChanged += rbevli_CheckedChanged;
            // 
            // txtmaas
            // 
            txtmaas.Location = new Point(124, 267);
            txtmaas.Name = "txtmaas";
            txtmaas.Size = new Size(130, 23);
            txtmaas.TabIndex = 14;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(124, 107);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(130, 23);
            txtsoyad.TabIndex = 10;
            // 
            // txtad
            // 
            txtad.Location = new Point(124, 67);
            txtad.Name = "txtad";
            txtad.Size = new Size(130, 23);
            txtad.TabIndex = 9;
            // 
            // txtid
            // 
            txtid.Location = new Point(124, 27);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(130, 23);
            txtid.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 308);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 7;
            label8.Text = "Personel Durum : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 270);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 6;
            label7.Text = "Personel Maaş : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 230);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Meslek : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 195);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Şehir : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 150);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 3;
            label4.Text = "T.C. Kimlik No : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 110);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyadınız : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 70);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Adınız : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 30);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Personel ID : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(btnmeslekguncelle);
            groupBox2.Controls.Add(btnmesleksil);
            groupBox2.Controls.Add(btnmeslekekle);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtmeslek);
            groupBox2.Controls.Add(txtmid);
            groupBox2.Location = new Point(452, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 420);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Meslek Ekle";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 279);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnmeslekguncelle
            // 
            btnmeslekguncelle.Location = new Point(168, 102);
            btnmeslekguncelle.Name = "btnmeslekguncelle";
            btnmeslekguncelle.Size = new Size(75, 23);
            btnmeslekguncelle.TabIndex = 6;
            btnmeslekguncelle.Text = "Güncelle";
            btnmeslekguncelle.UseVisualStyleBackColor = true;
            btnmeslekguncelle.Click += btnmeslekguncelle_Click;
            // 
            // btnmesleksil
            // 
            btnmesleksil.Location = new Point(87, 102);
            btnmesleksil.Name = "btnmesleksil";
            btnmesleksil.Size = new Size(75, 23);
            btnmesleksil.TabIndex = 5;
            btnmesleksil.Text = "Sil";
            btnmesleksil.UseVisualStyleBackColor = true;
            btnmesleksil.Click += btnmesleksil_Click;
            // 
            // btnmeslekekle
            // 
            btnmeslekekle.Location = new Point(6, 102);
            btnmeslekekle.Name = "btnmeslekekle";
            btnmeslekekle.Size = new Size(75, 23);
            btnmeslekekle.TabIndex = 4;
            btnmeslekekle.Text = "Ekle";
            btnmeslekekle.UseVisualStyleBackColor = true;
            btnmeslekekle.Click += btnmeslekekle_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 68);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 3;
            label10.Text = "Meslek : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 29);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 2;
            label9.Text = "Personel ID : ";
            // 
            // txtmeslek
            // 
            txtmeslek.Location = new Point(87, 67);
            txtmeslek.Name = "txtmeslek";
            txtmeslek.Size = new Size(156, 23);
            txtmeslek.TabIndex = 1;
            // 
            // txtmid
            // 
            txtmid.Location = new Point(87, 26);
            txtmid.Name = "txtmid";
            txtmid.ReadOnly = true;
            txtmid.Size = new Size(156, 23);
            txtmid.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnara);
            groupBox3.Controls.Add(txtara);
            groupBox3.Location = new Point(12, 362);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(420, 70);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Arama";
            // 
            // btnara
            // 
            btnara.Location = new Point(339, 22);
            btnara.Name = "btnara";
            btnara.Size = new Size(75, 23);
            btnara.TabIndex = 1;
            btnara.Text = "Ara";
            btnara.UseVisualStyleBackColor = true;
            btnara.Click += btnara_Click;
            // 
            // txtara
            // 
            txtara.Location = new Point(6, 22);
            txtara.Name = "txtara";
            txtara.Size = new Size(318, 23);
            txtara.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(12, 438);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(700, 200);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Personel Bilgi Tablosu";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(677, 172);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // PersonelBlgiEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(723, 650);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PersonelBlgiEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Bilgi Sistemi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rbbekar;
        private RadioButton rbevli;
        private TextBox txtmaas;
        private TextBox txtsoyad;
        private TextBox txtad;
        private TextBox txtid;
        private Label label8;
        private Button button5;
        private Button btntemizle;
        private Button btnguncelle;
        private Button btnpersil;
        private Button btnperekle;
        private GroupBox groupBox2;
        private TextBox txtmid;
        private DataGridView dataGridView1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Label label10;
        private Button btnmeslekekle;
        private Button btnmesleksil;
        private Button btnmeslekguncelle;
        private Label label9;
        private TextBox txtmeslek;
        private GroupBox groupBox3;
        private Button btnara;
        private TextBox txtara;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private ComboBox cmbmeslek;
        private ComboBox cmbsehir;
        private MaskedTextBox mtxttc;
        private Button button1;
    }
}