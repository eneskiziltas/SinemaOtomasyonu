using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriparkOopDegerlendirme2
{
    public partial class Form3 : Form
    {
        public Form3(int izleyiciSayisi, int ErkekIzleyiciSayisi, int KadinIzleyiciSayisi)
        {
            

            InitializeComponent();

            lblErkekIzleyiciSayisi.Text = Convert.ToString(ErkekIzleyiciSayisi);
            lblIzleyiciSayisi.Text = Convert.ToString(izleyiciSayisi);
            lblKadinIzleyiciSayisi.Text = Convert.ToString(KadinIzleyiciSayisi);

            
        }
    }
}
