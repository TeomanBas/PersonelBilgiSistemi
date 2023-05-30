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
    public partial class Istatistik : Form
    {
        SqlBaglanti Baglan = new SqlBaglanti();
        public Istatistik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelBlgiEkrani perbek = new PersonelBlgiEkrani();
            this.Hide();
            perbek.Show();
        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM TBL_Personel", Baglan.SqlBaglan());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbltopper.Text = dr1[0].ToString();
            }

            SqlCommand komut2 = new SqlCommand("SELECT COUNT(DISTINCT(PerMeslek)) FROM TBL_Personel", Baglan.SqlBaglan());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbltopmes.Text = dr2[0].ToString();
            }

            SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM TBL_Personel WHERE PerDurum=1", Baglan.SqlBaglan());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblevlipersay.Text = dr3[0].ToString();
            }

            SqlCommand komut4 = new SqlCommand("SELECT COUNT(*) FROM TBL_Personel WHERE PerDurum=0", Baglan.SqlBaglan());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblbeksay.Text = dr4[0].ToString();
            }

            SqlCommand komut5 = new SqlCommand("SELECT COUNT(DISTINCT(PerSehir)) FROM TBL_Personel", Baglan.SqlBaglan());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltopseh.Text = dr5[0].ToString();
            }

            SqlCommand komut6 = new SqlCommand("SELECT SUM(PerMaas) FROM TBL_Personel", Baglan.SqlBaglan());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lbltopmaas.Text = dr6[0].ToString();
            }

            SqlCommand komut7 = new SqlCommand("SELECT AVG(PerMaas) FROM TBL_Personel", Baglan.SqlBaglan());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblortmaas.Text = dr7[0].ToString();
            }

            Baglan.SqlBaglan().Close();

        }
    }
}
