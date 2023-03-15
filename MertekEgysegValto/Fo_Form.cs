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
    public partial class Fo_Form : Form
    {
        public Fo_Form()
        {
            InitializeComponent();
            btn_fizika.BackColor = Color.FromArgb(59, 60, 54);
            btn_fizika.ForeColor = Color.FromArgb(235, 156, 92);
            fizikaControl1.BringToFront();
        }

        public void menu_allitas(Button gomb)
        {
            foreach (Control c in pnl_fejlec.Controls.OfType<Button>())
            {
                if (c.Name != gomb.Name)
                {
                    c.BackColor = Color.FromArgb(83, 145, 126);
                    c.ForeColor = Color.Black;
                    
                }
            }
        }

        private void btn_fizika_Click(object sender, EventArgs e)
        {
            btn_fizika.BackColor = Color.FromArgb(59, 60, 54);
            btn_fizika.ForeColor = Color.FromArgb(235, 156, 92);
            Button akt_gomb = (Button)sender;
            
            menu_allitas(akt_gomb);
            fizikaControl1.BringToFront();

        }

        private void btn_kemia_Click(object sender, EventArgs e)
        {
            btn_kemia.BackColor = Color.FromArgb(59, 60, 54);
            btn_kemia.ForeColor = Color.FromArgb(235, 156, 92);
            Button akt_gomb = (Button)sender;
            
            menu_allitas(akt_gomb);
            kemiaControl1.BringToFront();
        }

        private void btn_konyha_Click(object sender, EventArgs e)
        {
            btn_konyha.BackColor = Color.FromArgb(59, 60, 54);
            btn_konyha.ForeColor = Color.FromArgb(235, 156, 92);
            Button akt_gomb = (Button)sender;
            
            menu_allitas(akt_gomb);
            konyhaControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
