using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LIMAN_YONETIM
{
    class Yonetici:personel
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BETUL;Initial Catalog=dbLiman;Integrated Security=True");
        SqlCommand command;
        SqlDataReader oku;
        private void PersonelBilgiGöruntule()
        {

        }
        private void KayitEkle()
        {
            personel pp = new personel();
            //pp.Ad=

        }
        private void PersonelGörevlendir()
        {

        }
        private void DepartmanEkle()
        {

        }
        private void GemiBilgileriGoruntule()
        {

        }
        private void GuvenlikRaporuGoruntule()
        {

        }

        public void PersonelEkle(string Ad, string Soyad, string Maas, string DogumTarihi, string DogumYeri,
            string Yas, string Telefon, string E_Mail, string EvAdresi, string CocukSayisi, string MedeniDurum, Form frmPersonelEkle)
        {
            
            baglanti.Open();
            oku = command.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Bu kayit mevcut lütfen başka bir kayıt giriniz...");

            }
            else
            {
                oku.Close();
                SqlCommand kayit = new SqlCommand("insert into personel(Ad,Soyad,Maas,DogumTarihi,DogumYeri,Yas,Telefon,E_Mail,EvAdresi,CocukSayisi,MedeniDurum) values( '" + Ad + "' ,'" + Soyad + "','" + Maas + "' ,'" + DogumTarihi + "',    '" + DogumYeri + "','" + Yas + "','" + Telefon + "', '" + E_Mail + "' ,'" + EvAdresi + "','" + CocukSayisi + "', '" + MedeniDurum + "')", baglanti);
                kayit.ExecuteNonQuery();
                MessageBox.Show("KAyit Başarılı");
                frmPersonelEkle ac = new frmPersonelEkle();
                ac.Show();

            }
            baglanti.Close();
            command.Dispose();
        }
        private void PersonelCıkar()
        {

        }
    }
}
