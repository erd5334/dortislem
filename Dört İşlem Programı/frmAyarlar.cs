using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dört_İşlem_Programı
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbToplama.Checked)
            {
                Properties.Settings.Default.toplananSayi1 = int.Parse(nmrSayi1.Value.ToString());
                Properties.Settings.Default.toplananSayi2 = int.Parse(nmrSayi2.Value.ToString());
                Properties.Settings.Default.toplayanSayi1 = int.Parse(nmrSayi3.Value.ToString());
                Properties.Settings.Default.toplayanSayi2 = int.Parse(nmrSayi4.Value.ToString());
            }
            if (rbCikarma.Checked)
            {
                Properties.Settings.Default.eksilenSayi1 = int.Parse(nmrSayi1.Value.ToString());
                Properties.Settings.Default.eksilenSayi2 = int.Parse(nmrSayi2.Value.ToString());
                Properties.Settings.Default.cikanSayi1 = int.Parse(nmrSayi3.Value.ToString());
                Properties.Settings.Default.cikanSayi2 = int.Parse(nmrSayi4.Value.ToString());
            }
            if (rbCarpma.Checked)
            {
                Properties.Settings.Default.carpilanSayi1 = int.Parse(nmrSayi1.Value.ToString());
                Properties.Settings.Default.carpilanSayi2 = int.Parse(nmrSayi2.Value.ToString());
                Properties.Settings.Default.carpanSayi1 = int.Parse(nmrSayi3.Value.ToString());
                Properties.Settings.Default.carpanSayi2 = int.Parse(nmrSayi4.Value.ToString());
            }
            if (rbBolme.Checked)
            {
                Properties.Settings.Default.bolunenSayi1 = int.Parse(nmrSayi1.Value.ToString());
                Properties.Settings.Default.bolunenSayi2 = int.Parse(nmrSayi2.Value.ToString());
                Properties.Settings.Default.bolenSayi1 = int.Parse(nmrSayi3.Value.ToString());
                Properties.Settings.Default.bolenSayi2 = int.Parse(nmrSayi4.Value.ToString());
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("Ayarlkar Kaydedildi...");
        }

        private void islemRadio(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return; //false ise sallama

    
            switch (rb.Name)
            {
                case "rbToplama":
                    nmrSayi1.Value = Properties.Settings.Default.toplananSayi1;
                    nmrSayi2.Value = Properties.Settings.Default.toplananSayi2;
                    nmrSayi3.Value = Properties.Settings.Default.toplayanSayi1;
                    nmrSayi4.Value = Properties.Settings.Default.toplayanSayi2;
                    break;
                case "rbCikarma":
                    nmrSayi1.Value = Properties.Settings.Default.eksilenSayi1;
                    nmrSayi2.Value = Properties.Settings.Default.eksilenSayi2;
                    nmrSayi3.Value = Properties.Settings.Default.cikanSayi1;
                    nmrSayi4.Value = Properties.Settings.Default.cikanSayi2;
                    break;
                case "rbCarpma":
                    nmrSayi1.Value = Properties.Settings.Default.carpilanSayi1;
                    nmrSayi2.Value = Properties.Settings.Default.carpilanSayi2;
                    nmrSayi3.Value = Properties.Settings.Default.carpanSayi1;
                    nmrSayi4.Value = Properties.Settings.Default.carpanSayi2;
                    break;
                case "rbBolme":
                    nmrSayi1.Value = Properties.Settings.Default.bolunenSayi1;
                    nmrSayi2.Value = Properties.Settings.Default.bolunenSayi2;
                    nmrSayi3.Value = Properties.Settings.Default.bolenSayi1;
                    nmrSayi4.Value = Properties.Settings.Default.bolenSayi2;
                    break;
                default:
                    break;
            }

       

        }
    }
}
