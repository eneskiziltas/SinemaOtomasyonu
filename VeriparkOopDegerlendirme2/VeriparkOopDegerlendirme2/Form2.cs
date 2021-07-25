using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriparkOopDegerlendirme2.Properties;

namespace VeriparkOopDegerlendirme2
{
    public partial class Form2 : Form
    {

        Koltuk koltuk;

        public Form2(Koltuk Koltuk)
        {

            koltuk = Koltuk;

            InitializeComponent();

            string[] cinsiyet = { "Bay", "Bayan" };


            for (int i = 0; i < cinsiyet.Length; i++)
            {
                foreach (Control cont in this.Controls)
                {
                    if (cont is RadioButton)
                    {
                        RadioButton rb = (RadioButton)cont;
                        if (rb.Text == "" || rb.Text == null)
                        {

                            rb.Text = cinsiyet[i];
                            break;
                        }

                    }
                }
            }

            if (koltuk.Cinsiyet == "E")
            {
                rdbtnBay.Checked = true;
            }

            txtAdSoyad.Text = Koltuk.AdSoyad;
            txtTc.Text = Koltuk.Tc;

            
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {


            string message = "Rezervasyanu iptal etmek istiyor musunuz?";
            string title = "İptal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                koltuk.AdSoyad = "";
                koltuk.Cinsiyet = "";
                koltuk.Durum = true;
                koltuk.Tc = "";

                Button btn = (Button)koltuk.Button;
                btn.BackgroundImage = Resources.bos_koltuk1;
                this.Close();
            }
          



        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {

            if (txtAdSoyad.Text != "" && txtTc.Text != "")
            {
                koltuk.AdSoyad = txtAdSoyad.Text;
                koltuk.Tc = txtTc.Text;
                koltuk.Durum = false;

                if (rdbtnBay.Checked)
                {
                    koltuk.Cinsiyet = "E";
                }
                else
                {
                    koltuk.Cinsiyet = "K";
                }

                Button btn = (Button)koltuk.Button;
                btn.BackgroundImage = Resources.dolu_koltuk;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tüm Bilgileri Doldurunuz");
            }


        }
    }
}
