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
    public partial class FizikaControl : UserControl
    {
        public FizikaControl()
        {
            InitializeComponent();
        }

        public static double atvaltas(String errol, String erre, double mennyiseg)
        {
            double valtoszam = 0;
            if((errol == "KPH" && erre == "MPH") || (errol == "MPH" && erre == "KPH"))
            {
                if(errol == "KPH")
                {
                    valtoszam = 1.61;
                }
                else
                {
                    valtoszam = 1.0 / 1.61;
                }
            }
            else if((errol == "KG" && erre == "LB") || (errol == "LB" && erre == "KG"))
            {
                if(errol == "KG")
                {
                    valtoszam = 2.20;
                }
                else
                {
                    valtoszam = 1 / 2.20;
                }
            }
            else
            {
                
                return 0;
            }
            return mennyiseg*valtoszam;
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
               if(eredmeny == 0)
                {
                    lbl_atvaltott.Text = "Nem lehet átváltani!";
                }
                else
                {
                    lbl_atvaltott.Text = "Átváltott mennyiség: " + Math.Round(eredmeny, 2) + " " + atvaltando_mert;
                }
               

            }
            
            
            
        }
    }
}
