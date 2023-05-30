using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PersonelBilgiSistemi
{
    public class SqlBaglanti
    {
        // veritabanı bağlantı metodu
        public SqlConnection SqlBaglan()
        {
            // veritabanı bağlantı ayarlaması
            SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-6NBRLG6;
                                                    Initial Catalog=DbPersonelKayitVt;
                                                    Integrated Security=True");
            // bağlantı açılıyor
            Baglanti.Open();
            return Baglanti;

        }
    }
}