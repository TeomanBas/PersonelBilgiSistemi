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
        /// DATAGRIDVIEW LER ���N DATABASE DEN VER� �EK�LEN METOT
        /// </summary>
        /// 
        // sql ba�lant�s�na ula�mak i�in bir nesne tan�mlamas� yap�ld�
        SqlBaglanti Baglanti = new SqlBaglanti();
        void listele()
        {
            /////////datatablosu 2
            // datatablosu tipinde bir nesne olu�turduk
            DataTable dt = new DataTable();
            // veritaban�na sql sorgusunu g�nderdik
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_Personel;", Baglanti.SqlBaglan());
            // da i�erisindeki veriyi dt datatablosu na ge�irdik
            da.Fill(dt);
            // dt i�erisindeki datatable tipindeki veriyi form i�erisindeki datagridview i�erisine yerle�tirdik
            dataGridView2.DataSource = dt;
            ////////////////////////////////////////

            /////////datatablosu 1
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBL_Meslek;", Baglanti.SqlBaglan());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            ////////////////////////////////////////


            ///meslekler combobox � g�ncellemek i�in fonksiyon �a�r�ld�
            combmeslekguncelle();
            ////////////////////////////////////////

        }

        /// <summary>
        /// MESLEK EKLEME METODU
        /// </summary>
        /// <param name="meslek">meslekler tablosuna eklenecek meslek ad�d�r.</param>
        void MeslekEkle(string meslek)
        {
            if (meslek != "")
            {
                SqlCommand sqlqueryinsert = new SqlCommand("INSERT INTO TBL_Meslek (MeslekAd) values (@p1)", Baglanti.SqlBaglan());
                sqlqueryinsert.Parameters.AddWithValue("@p1", meslek);
                // sql query si db ye g�nderildi
                sqlqueryinsert.ExecuteNonQuery();
                Baglanti.SqlBaglan().Close();
                sqlqueryinsert.Parameters.Clear();
                listele();
                MessageBox.Show("Meslek Eklendi", "B�LG�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L�TFEN B�R MESLEK ADI YAZINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// MESLEK S�LME METODU
        /// </summary>
        /// <param name="meslek">meslekler tablosundan silinecek meslek ad�d�r.</param>
        void MeslekSil(string id)
        {

            SqlCommand sqlqueryinsert = new SqlCommand("DELETE FROM TBL_Meslek WHERE id=@p1", Baglanti.SqlBaglan());
            sqlqueryinsert.Parameters.AddWithValue("@p1", id);
            sqlqueryinsert.ExecuteNonQuery();
            Baglanti.SqlBaglan().Close();
            sqlqueryinsert.Parameters.Clear();
            listele();
            MessageBox.Show("Meslek Silindi", "B�LG�", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// MESLEK G�NCELLEME METODU
        /// </summary>
        /// <param name="meslek">g�ncel meslek ad�d�r.</param>
        /// <param name="mid">meslekler tablosunda meslek ad� g�ncellecek id de�eridir</param>
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
                MessageBox.Show($"'{id}' ID NUMARASINA A�T SATIRDAK� MESLEK ADI '{meslek}' �LE G�NCELLEND�", "B�LG�", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("L�TFEN B�R MESLEK ADI YAZINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void combmeslekguncelle()
        {
            cmbmeslek.Items.Clear();
            SqlCommand cmbguncsql = new SqlCommand("SELECT MeslekAd FROM TBL_Meslek", Baglanti.SqlBaglan());
            // sql query sini db ye g�nderip d�nen datay� okuyor ve mslkdata i�erisine at�yor
            // burada ExecuteNonQuery() fonksiyonunu kullanmad�k ��nk� tablo i�erisinde de�i�iklik yap�lm�yor
            // tablo i�erisinde de�i�iklik yap�lsayd� �rn bir sat�r eklenseydi ExecuteNonquery() kullanmam�z gerekirdi.
            SqlDataReader mslkdata = cmbguncsql.ExecuteReader();
            while (mslkdata.Read())
            {
                //d�nen data i�erisinden 0 �nc� indisteki sat�lar� combobox i�erisine at�yor.
                cmbmeslek.Items.Add(mslkdata[0]);
            }
            Baglanti.SqlBaglan().Close();

        }
        //durum de�i�knei i�in tan�mlama
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
            MessageBox.Show("PERSONEL EKLEND�", "B�LG�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //buradaki kodlar herhangibir butona t�kland���n bir i� yap�ld���nda tekrar �al��t�r�l�r
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
            MessageBox.Show("PERSONEL S�L�ND�", "B�LG�", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("PERSONEL B�LG�LER� G�NCELLEND�", "B�LG�", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // istatistik butonuna t�klan�nca istatistik formu a��lmas� gerekli
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