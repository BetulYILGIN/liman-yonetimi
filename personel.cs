using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMAN_YONETIM
{
    class personel
    {
        private const int cocukparasi = 300;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //public string Departman { get; set; }
        protected int Maas { get; set; }
        public int maas { get
            {
                return Maas;
            }
        }
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public int Yas { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public string EvAdresi { get; set; }
        public int CocukSayisi { get; set; }
        public string MedeniDurum { get; set; }

        public virtual void MaasHesapla()
        {
            Maas = maas + CocukSayisi * cocukparasi;
        }
        
        public enum Departman
        {
            muhasebe,
            buro,
            guvenlik,
            bilgi_islem
        }
    }
}
