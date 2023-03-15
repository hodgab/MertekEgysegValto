using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertekEgysegValto
{
    public partial class KonyhaControl : UserControl
    {
        public KonyhaControl()
        {
            InitializeComponent();
        }

        public double atvaltas(String errol, String erre, double mennyiseg)
        {
            double valtoszam = 0;
            if((errol == "TK" && erre == "g") || (errol == "TK" && erre == "ml"))
            {
                if(erre == "g")
                {
                    valtoszam = 4.2;
                    return mennyiseg * valtoszam;
                }
                else
                {
                    valtoszam = 5.0;
                    return mennyiseg * valtoszam;
                }
            }
            else if((errol == "EK" && erre == "g") || (errol == "EK" && erre == "ml"))
            {
                if(erre == "g")
                {
                    valtoszam = 12.6;
                    return mennyiseg * valtoszam;
                }
                else
                {
                    valtoszam = 15.0;
                    return mennyiseg * valtoszam;
                }
            }
            return 1;
        }

        private void btn_atvaltas_Click(object sender, EventArgs e)
        {
            double eredmeny = 0;
            double mennyiseg = Convert.ToDouble(txt_mennyiseg.Text);
            String atvalto_mert = cbx_errol.Text;
            String atvaltando_mert = cbx_erre.Text;

            if(atvalto_mert == atvaltando_mert)
            {
                lbl_atvaltott.Text = "Átváltott mennyiség: " + mennyiseg + " " + atvaltando_mert;
            }
            else
            {
                eredmeny = atvaltas(atvalto_mert, atvaltando_mert, mennyiseg);
                lbl_atvaltott.Text = "Átváltott mennyiség: " + eredmeny + " " + atvaltando_mert;
            }
        }
    }
}
