using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
namespace LIMAN_YONETIM
{
    class limanyonetimi
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BETUL;Initial Catalog=dbLiman;Integrated Security=True");
        SqlCommand command;
        SqlDataReader Reader;

        public void girisyap(string kulaniciad, string sifre, Form frmyoneticidogrulama)
        {
            command = new SqlCommand("Select *From giris where kullaniciad='" + kulaniciad + "' and sifre='" + sifre + "'", baglanti);
            baglanti.Open();
            Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                frmyonetici ac = new frmyonetici();
                ac.Show();

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmyoneticidogrulama ac = new frmyoneticidogrulama();
                ac.Show();

            }
            baglanti.Close();
            command.Dispose();
        }
    }
}


