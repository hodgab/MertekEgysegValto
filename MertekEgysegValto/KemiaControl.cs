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
    public partial class KemiaControl : UserControl
    {
        public KemiaControl()
        {
            InitializeComponent();
        }

        public static double atvaltas(String errol, String erre, double mennyiseg)
        {
            double valtoszam = 273.15;
            if(errol == "K" && erre == "Cel")
            {
                
                return mennyiseg - valtoszam;
            }
            else
            {
                return mennyiseg + valtoszam;
            }
            return 0;
            
        }

        private void lbl_errol_Click(object sender, EventArgs e)
        {

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
