using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelBilgiSistemi
{
    public partial class FormGiris : Form
    {
        SqlBaglanti Baglan = new SqlBaglanti();
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand autsql = new SqlCommand("SELECT 'OK' FROM TBL_Giris WHERE KullaniciAdi=@p1 AND KullaniciSifre=@p2;", Baglan.SqlBaglan());
            autsql.Parameters.AddWithValue("@p1", textBox1.Text);
            autsql.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader autresult = autsql.ExecuteReader();
            var dene = "";


            while (autresult.Read())
            {
                dene = (string)autresult[0];
            }


            if (dene == "OK")
            {
                PersonelBlgiEkrani pnl = new PersonelBlgiEkrani();
                pnl.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Kullanıcı id veya şifre hatalı!", "GİRİŞ BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }

        }
    }
}
