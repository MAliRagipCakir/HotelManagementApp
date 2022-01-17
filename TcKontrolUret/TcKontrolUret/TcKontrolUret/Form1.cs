using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKontrolUret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTcUret_Click(object sender, EventArgs e)
        {
            txtYeniTc.Text = TCKNOUret();
        }
        private string TCKNOUret()
        {
            Random rnd = new Random();
            string tc = "";
            tc += rnd.Next(1, 10);

            for (int i = 0; i < 8; i++)
            {
                tc += rnd.Next(0, 10);
            }
            int tekler = 0;
            int ciftler = 0;

            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                    tekler += Convert.ToInt32(tc[i].ToString());
                else
                    ciftler += Convert.ToInt32(tc[i].ToString());
            }
            int onuncuBasamak = ((tekler * 7) - ciftler) % 10;
            int onbirinciBasamak = (tekler + ciftler + onuncuBasamak) % 10;
            tc += onuncuBasamak;
            tc += onbirinciBasamak;
            Console.WriteLine(tc);
            return tc;
        }

        private void btnTcDogrula_Click(object sender, EventArgs e)
        {
            TCKNODogrula(txtDogrulanacakTc.Text.Trim());
        }
        private void TCKNODogrula(string tc)
        {
            //Her Hanenin Rakam Kontrolü

            try
            {
                long rakamlar = Convert.ToInt64(tc);
            }
            catch (Exception)
            {
                lblGecerliMi.Text ="Geçersiz TC";
                lblGecerliMi.ForeColor = Color.Red;
                return;
            }

            //Toplam 11 Basamak Kontrolü
            bool toplam11Basamak = false;
            if ((tc.Length == 11))
                toplam11Basamak = true;
            else
            {
                lblGecerliMi.Text = "Geçersiz TC";
                lblGecerliMi.ForeColor = Color.Red;
                return;
            }

            //10.Basamak Kontrol
            int tekler = 0;
            int ciftler = 0;
            for (int i = 0; i < 9; i++)//ilk 9 hanenin tekler(1.3.5.7.9. basamaklar) ve çiftler(2.4.6.8. basamaklar)toplamı
                if (i % 2 == 0)
                    tekler += Convert.ToInt32(tc[i].ToString());
                else
                    ciftler += Convert.ToInt32(tc[i].ToString());

            int onuncuBasamak = Convert.ToInt32(tc[9].ToString());
            bool onuncuBasamakKontrol = false;
            if ((tekler * 7 - ciftler) % 10 == onuncuBasamak)
                onuncuBasamakKontrol = true;
            else
                onuncuBasamakKontrol = false;

            //İlk Hane 0 kontrolü
            int ilkHane = Convert.ToInt32(tc[0].ToString()); ;
            bool ilkHaneKontrol = false;
            if (ilkHane != 0)
                ilkHaneKontrol = true;
            else
                ilkHaneKontrol = false;

            //11.Basamak Kontrolü
            int onbirinciBasamak = Convert.ToInt32(tc[10].ToString());
            bool onbirinciBasamakKontrol = false;
            if ((tekler + ciftler + onuncuBasamak) % 10 == onbirinciBasamak)
                onbirinciBasamakKontrol = true;
            else
                onbirinciBasamakKontrol = false;

            //TC Kontrol: diğer tüm durumların doğru olması durumu
            if (toplam11Basamak && ilkHaneKontrol && onuncuBasamakKontrol && onbirinciBasamakKontrol)
            {
                lblGecerliMi.Text = "Girilen TC geçerli";
                lblGecerliMi.ForeColor = Color.Green;
            }
            else
            {
                lblGecerliMi.Text = "Geçersiz TC";
                lblGecerliMi.ForeColor = Color.Red;
            }

        }
    }
}
