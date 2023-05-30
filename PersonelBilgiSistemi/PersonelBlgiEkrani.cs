using System.Data;
using System.Data.SqlClient;

namespace PersonelBilgiSistemi
{


    public partial class PersonelBlgiEkrani : Form
    {
        public PersonelBlgiEkrani()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DATAGRIDVIEW LER ÝÇÝN DATABASE DEN VERÝ ÇEKÝLEN METOT
        /// </summary>
        /// 
        // sql baðlantýsýna ulaþmak için bir nesne tanýmlamasý yapýldý
        SqlBaglanti Baglanti = new SqlBaglanti();
        void listele()
        {
            /////////datatablosu 2
            // datatablosu tipinde bir nesne oluþturduk
            DataTable dt = new DataTable();
            // veritabanýna sql sorgusunu gönderdik
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_Personel;", Baglanti.SqlBaglan());
            // da içerisindeki veriyi dt datatablosu na geçirdik
            da.Fill(dt);
            // dt içerisindeki datatable tipindeki veriyi form içerisindeki datagridview içerisine yerleþtirdik
            dataGridView2.DataSource = dt;
            ////////////////////////////////////////

            /////////datatablosu 1
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBL_Meslek;", Baglanti.SqlBaglan());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            ////////////////////////////////////////


            ///meslekler combobox ý güncellemek için fonksiyon çaðrýldý
            combmeslekguncelle();
            ////////////////////////////////////////

        }

        /// <summary>
        /// MESLEK EKLEME METODU
        /// </summary>
        /// <param name="meslek">meslekler tablosuna eklenecek meslek adýdýr.</param>
        void MeslekEkle(string meslek)
        {
            if (meslek != "")
            {
                SqlCommand sqlqueryinsert = new SqlCommand("INSERT INTO TBL_Meslek (MeslekAd) values (@p1)", Baglanti.SqlBaglan());
                sqlqueryinsert.Parameters.AddWithValue("@p1", meslek);
                // sql query si db ye gönderildi
                sqlqueryinsert.ExecuteNonQuery();
                Baglanti.SqlBaglan().Close();
                sqlqueryinsert.Parameters.Clear();
                listele();
                MessageBox.Show("Meslek Eklendi", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LÜTFEN BÝR MESLEK ADI YAZINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// MESLEK SÝLME METODU
        /// </summary>
        /// <param name="meslek">meslekler tablosundan silinecek meslek adýdýr.</param>
        void MeslekSil(string id)
        {

            SqlCommand sqlqueryinsert = new SqlCommand("DELETE FROM TBL_Meslek WHERE id=@p1", Baglanti.SqlBaglan());
            sqlqueryinsert.Parameters.AddWithValue("@p1", id);
            sqlqueryinsert.ExecuteNonQuery();
            Baglanti.SqlBaglan().Close();
            sqlqueryinsert.Parameters.Clear();
            listele();
            MessageBox.Show("Meslek Silindi", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// MESLEK GÜNCELLEME METODU
        /// </summary>
        /// <param name="meslek">güncel meslek adýdýr.</param>
        /// <param name="mid">meslekler tablosunda meslek adý güncellecek id deðeridir</param>
        void MeslekGuncelle(string meslek, string mid)
        {
            int id = Convert.ToInt16(mid);

            if (meslek != "")
            {

                SqlCommand sqlqueryinsert = new SqlCommand("UPDATE TBL_Meslek SET MeslekAd=@p1 WHERE id=@p2", Baglanti.SqlBaglan());
                sqlqueryinsert.Parameters.AddWithValue("@p1", meslek);
                sqlqueryinsert.Parameters.AddWithValue("@p2", id);
                sqlqueryinsert.ExecuteNonQuery();
                Baglanti.SqlBaglan().Close();
                MessageBox.Show($"'{id}' ID NUMARASINA AÝT SATIRDAKÝ MESLEK ADI '{meslek}' ÝLE GÜNCELLENDÝ", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("LÜTFEN BÝR MESLEK ADI YAZINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void combmeslekguncelle()
        {
            cmbmeslek.Items.Clear();
            SqlCommand cmbguncsql = new SqlCommand("SELECT MeslekAd FROM TBL_Meslek", Baglanti.SqlBaglan());
            // sql query sini db ye gönderip dönen datayý okuyor ve mslkdata içerisine atýyor
            // burada ExecuteNonQuery() fonksiyonunu kullanmadýk çünkü tablo içerisinde deðiþiklik yapýlmýyor
            // tablo içerisinde deðiþiklik yapýlsaydý örn bir satýr eklenseydi ExecuteNonquery() kullanmamýz gerekirdi.
            SqlDataReader mslkdata = cmbguncsql.ExecuteReader();
            while (mslkdata.Read())
            {
                //dönen data içerisinden 0 ýncý indisteki satýlarý combobox içerisine atýyor.
                cmbmeslek.Items.Add(mslkdata[0]);
            }
            Baglanti.SqlBaglan().Close();

        }
        //durum deðiþknei için tanýmlama
        public string durum;

        private void rbevli_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";

        }

        private void rbbekar_CheckedChanged(object sender, EventArgs e)
        {
            durum = "";
        }


        void PerEkle()
        {
            SqlCommand pereklesql = new SqlCommand("INSERT INTO TBL_Personel (PerAd,PerSoyad,PerTc,PerSehir,PerMeslek,PerMaas,PerDurum) " +
                "VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", Baglanti.SqlBaglan());
            pereklesql.Parameters.AddWithValue("@p1", txtad.Text);
            pereklesql.Parameters.AddWithValue("@p2", txtsoyad.Text);
            pereklesql.Parameters.AddWithValue("@p3", mtxttc.Text);
            pereklesql.Parameters.AddWithValue("@p4", cmbsehir.Text);
            pereklesql.Parameters.AddWithValue("@p5", cmbmeslek.Text);
            pereklesql.Parameters.AddWithValue("@p6", txtmaas.Text);
            pereklesql.Parameters.AddWithValue("@p7", durum);
            pereklesql.ExecuteNonQuery();
            Baglanti.SqlBaglan().Close();
            MessageBox.Show("PERSONEL EKLENDÝ", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //buradaki kodlar herhangibir butona týklandýðýn bir iþ yapýldýðýnda tekrar çalýþtýrýlýr
            listele();


        }

        private void btnmeslekekle_Click(object sender, EventArgs e)
        {
            MeslekEkle(txtmeslek.Text);
        }

        private void btnmesleksil_Click(object sender, EventArgs e)
        {
            MeslekSil(txtmid.Text);
        }

        private void btnmeslekguncelle_Click(object sender, EventArgs e)
        {
            MeslekGuncelle(txtmeslek.Text, txtmid.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secimindex = dataGridView1.SelectedCells[0].RowIndex;
            txtmid.Text = dataGridView1.Rows[secimindex].Cells[0].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secimindex].Cells[1].Value.ToString();
        }

        private void btnperekle_Click(object sender, EventArgs e)
        {
            PerEkle();
            BtnTemizleme();
        }




        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secimindex = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secimindex].Cells[0].Value.ToString();
            txtad.Text = dataGridView2.Rows[secimindex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView2.Rows[secimindex].Cells[2].Value.ToString();
            mtxttc.Text = dataGridView2.Rows[secimindex].Cells[3].Value.ToString();
            cmbsehir.Text = dataGridView2.Rows[secimindex].Cells[4].Value.ToString();
            cmbmeslek.Text = dataGridView2.Rows[secimindex].Cells[5].Value.ToString();
            txtmaas.Text = dataGridView2.Rows[secimindex].Cells[6].Value.ToString();

            var perdurum = dataGridView2.Rows[secimindex].Cells[7].Value.ToString();

            if (perdurum == "True")
            {

                rbevli.Checked = true;
            }
            else
            {
                rbbekar.Checked = true;
            }
        }

        public void Persil()
        {
            SqlCommand persilsql = new SqlCommand("DELETE FROM TBL_Personel WHERE Perid=@p1", Baglanti.SqlBaglan());
            persilsql.Parameters.AddWithValue("@p1", txtid.Text);
            persilsql.ExecuteNonQuery();
            MessageBox.Show("PERSONEL SÝLÝNDÝ", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void btnpersil_Click(object sender, EventArgs e)
        {
            Persil();
            BtnTemizleme();
        }

        public void PerGuncelle()
        {
            SqlCommand perguncellesql = new SqlCommand("UPDATE TBL_Personel " +
                "SET PerAd=@p1,PerSoyad=@p2,PerTc=@p3,PerSehir=@p4,PerMeslek=@p5,PerMaas=@p6,PerDurum=@p7 " +
                "WHERE Perid=@p8", Baglanti.SqlBaglan());
            perguncellesql.Parameters.AddWithValue("@p1", txtad.Text);
            perguncellesql.Parameters.AddWithValue("@p2", txtsoyad.Text);
            perguncellesql.Parameters.AddWithValue("@p3", mtxttc.Text);
            perguncellesql.Parameters.AddWithValue("@p4", cmbsehir.Text);
            perguncellesql.Parameters.AddWithValue("@p5", cmbmeslek.Text);
            perguncellesql.Parameters.AddWithValue("@p6", txtmaas.Text);
            perguncellesql.Parameters.AddWithValue("@p7", durum);
            perguncellesql.Parameters.AddWithValue("@p8", txtid.Text);
            perguncellesql.ExecuteNonQuery();
            Baglanti.SqlBaglan().Close();
            MessageBox.Show("PERSONEL BÝLGÝLERÝ GÜNCELLENDÝ", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
        public void BtnTemizleme()
        {
            txtid.Clear();
            txtad.Clear();
            txtsoyad.Clear();
            mtxttc.Clear();
            cmbsehir.Text = "";
            cmbmeslek.Text = "";
            txtmaas.Clear();
            rbevli.Checked = false;
            rbbekar.Checked = false;
            listele();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            PerGuncelle();
            BtnTemizleme();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            BtnTemizleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // istatistik butonuna týklanýnca istatistik formu açýlmasý gerekli
            Istatistik istform = new Istatistik();
            //this.Hide();
            istform.Show();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("SELECT * FROM TBL_Personel WHERE PerAd LIKE '"+
                "%"+txtara.Text+"%'"+"OR PerSoyad LIKE '"+"%"+txtara.Text+"%'",
                Baglanti.SqlBaglan());
            DataTable dt1= new DataTable();
            SqlDataAdapter da1= new SqlDataAdapter(komut1);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;


        }
    }
}