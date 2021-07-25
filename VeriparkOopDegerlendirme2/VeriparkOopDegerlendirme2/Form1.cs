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
    public partial class Form1 : Form
    {

        Image doluImage = Resources.dolu_koltuk;
        Image bosImage = Resources.bos_koltuk1;
        int sayac;
        int erkekIzleyiciSayisi;
        int bayanIzleyeciSayisi;
        int izleyiciSayisi;

        public Form1()
        {
            InitializeComponent();

            sayac = 1;
            for (int i = 0; i < 6; i++)
            {

                if (i%2 == 0)
                {
                    for (int j = 0; j < 8; j++)
                    {

                        Button btn = new Button();
                        btn.Size = new Size(50, 50);
                        btn.Location = new Point(j * 50 + 130, i * 50 + 20);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Name = sayac.ToString();
                        btn.Click += new EventHandler(btnTıkla);
                        btn.BackgroundImage = Resources.bos_koltuk1;
                        btn.Text = sayac.ToString();
                        Koltuk koltuk = new Koltuk("", "","", btn);
                        btn.Tag = koltuk;
                        this.pnlKoltuklar.Controls.Add(btn);
                        sayac++;
                        

                    }
                }
                else
                {
                    for (int j = 0; j < 12; j++)
                    {

                        Button btn = new Button();
                        btn.Size = new Size(50, 50);
                        btn.Location = new Point(j * 50 + 30, i * 50 + 20);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Name = sayac.ToString();
                        btn.Click += new EventHandler(btnTıkla);
                        btn.BackgroundImage = Resources.bos_koltuk1;
                        btn.Text = sayac.ToString();
                        Koltuk koltuk = new Koltuk("","","",btn);
                        btn.Tag = koltuk;
                        this.pnlKoltuklar.Controls.Add(btn);
                        sayac++;

                       

                    }
                   

                }
            }

        }

        void btnTıkla(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Koltuk koltuk = (Koltuk)btn.Tag;

            Form2 form2 = new Form2(koltuk);
            form2.ShowDialog();

        }

       

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            izleyiciSayisi = 0;
            bayanIzleyeciSayisi = 0;
            erkekIzleyiciSayisi = 0;

            foreach (Control control in this.pnlKoltuklar.Controls)
            {
                if(control is Button)
                {
                    Button btn = (Button)control;
                    Koltuk koltuk = (Koltuk)btn.Tag;

                    if(koltuk.Durum == false)
                    {
                        izleyiciSayisi++;
                    }

                    if (koltuk.Cinsiyet == "K")
                    {
                        bayanIzleyeciSayisi++;
                    }

                    if (koltuk.Cinsiyet == "E")
                    {
                        erkekIzleyiciSayisi++;
                    }
                    
                }
            }

            //MessageBox.Show(izleyiciSayisi.ToString());

           Form3 form3 = new Form3(izleyiciSayisi, erkekIzleyiciSayisi, bayanIzleyeciSayisi);
            form3.ShowDialog();
        }
    }
}
