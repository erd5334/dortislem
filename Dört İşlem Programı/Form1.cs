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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int sayi1 = 0, sayi2 = 0;

        void carpmaHazirlik()
        {
            panel1.Left = label4.Left;
            panel1.Width = label4.Width;

            int x = 0,y = 20;
            int[] ySonuclar = new int[sayi2.ToString().Length];
            int yX = 0;
            for (int i = sayi2.ToString().Length - 1; i >= 0; i--)
            {
                ySonuclar[yX] = sayi1 * int.Parse(sayi2.ToString()[i].ToString());
                yX++;
            }

            int genelSonuc = sayi1 * sayi2;

            for (int i = 0; i < ySonuclar.Length; i++) //satırları dönüyor
            {
                x = panel1.Width - (25 * (i + 1));
                string s = ySonuclar[i].ToString();
                var a = sayi2.ToString()[ySonuclar.Length - (i + 1)].ToString();
                if (a == "0")
                {
                    for (int t = 0; t < sayi2.ToString().Length; t++)
                    {
                        TextBoxOlustur(x, y, "0");
                        x -= 25;
                    }
                    y += 25;
                    continue;
                }


                for (int r = s.Length - 1; r >= 0; r--) // satırdaki textboxların yani basamakları donüyor
                {
                    char sc = s[r];
                    TextBoxOlustur(x, y, sc.ToString());
                    x -= 25;
                }
                y += 25;
            }

            x = panel1.Width - 25;
            for (int i = genelSonuc.ToString().Length - 1; i >= 0; i--)
            {
                TextBoxOlustur(x, y+10, genelSonuc.ToString()[i].ToString()   );
                x -= 25;
            }


        }
        void toplamaHazirlik()
        {
            panel1.Left = label4.Left;
            panel1.Width = label4.Width;

            int x = 0, y = 20;
            int genelSonuc = sayi1 + sayi2;
            x = panel1.Width - 25;
            for (int i = genelSonuc.ToString().Length - 1; i >= 0; i--)
            {
                TextBoxOlustur(x, y, genelSonuc.ToString()[i].ToString());
                x -= 25;
            }
        }
        void cikarmaHazirlik()
        {
            panel1.Left = label4.Left;
            panel1.Width = label4.Width;

            int x = 0, y = 20;
            int genelSonuc = sayi1 - sayi2;
            x = panel1.Width - 25;
            for (int i = genelSonuc.ToString().Length - 1; i >= 0; i--)
            {
                TextBoxOlustur(x, y, genelSonuc.ToString()[i].ToString());
                x -= 25;
            }
        }
        void TextBoxOlustur(int x, int y, string deger)
        {
            Font font = new Font("Segoe UI", 9.0f, FontStyle.Bold);

            TextBox txt = new TextBox
            {
                Name = "txt" + y.ToString() + x.ToString(),
                Location = new Point(x, y),
                Width = 20,
                Height = 20,
                TextAlign = HorizontalAlignment.Center,
                Font = font,
                ForeColor = Color.White,
                Tag = deger
            };
            txt.TextChanged += Txt_TextChanged;
            panel1.Controls.Add(txt);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblX.Visible = label2.Visible = lblY.Visible = label4.Visible = false;
            
        }

        private void islemRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return; //false ise sallama

            foreach (Control item in panel1.Controls)
            {
                item.Dispose();
            }

            panel1.Controls.Clear();

            lblX.Visible = label2.Visible =  lblY.Visible = label4.Visible = true;
            switch (rb.Name)
            {
                case "rbToplama":
                    sayi1 = rnd.Next(Properties.Settings.Default.toplananSayi1, Properties.Settings.Default.toplananSayi2);
                    sayi2 = rnd.Next(Properties.Settings.Default.toplayanSayi1, Properties.Settings.Default.toplayanSayi2);
                    toplamaHazirlik();
                    label2.Text = "+";
                    break;
                case "rbCikarma":
                    sayi1 = rnd.Next(Properties.Settings.Default.eksilenSayi1, Properties.Settings.Default.eksilenSayi2);
                    sayi2 = rnd.Next(Properties.Settings.Default.cikanSayi1, Properties.Settings.Default.cikanSayi2);
                    cikarmaHazirlik();
                    label2.Text = "-";
                    break;
                case "rbCarpma":
                    sayi1 = rnd.Next(Properties.Settings.Default.carpilanSayi1, Properties.Settings.Default.carpilanSayi2);
                    sayi2 = rnd.Next(Properties.Settings.Default.carpanSayi1, Properties.Settings.Default.carpanSayi2);
                    label2.Text = "x";
                    carpmaHazirlik();
                    break;
                case "rbBolme":
                    sayi1 = rnd.Next(Properties.Settings.Default.bolunenSayi1, Properties.Settings.Default.bolunenSayi2);
                    sayi2 = rnd.Next(Properties.Settings.Default.bolenSayi1, Properties.Settings.Default.bolenSayi2);
                    label2.Text = "÷";
                    break;
                default:
                    break;
            }

            lblX.Text = sayi1.ToString();
            lblY.Text = sayi2.ToString();


        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyarlar fr = new frmAyarlar();
            fr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                item.Dispose();
            }

            panel1.Controls.Clear();
            lblX.Visible = label2.Visible = lblY.Visible = label4.Visible = true;
            if (rbToplama.Checked)
            {
                sayi1 = rnd.Next(Properties.Settings.Default.toplananSayi1, Properties.Settings.Default.toplananSayi2);
                sayi2 = rnd.Next(Properties.Settings.Default.toplayanSayi1, Properties.Settings.Default.toplayanSayi2);
                toplamaHazirlik();
                label2.Text = "+";
            }
            if (rbCikarma.Checked)
            {
                sayi1 = rnd.Next(Properties.Settings.Default.eksilenSayi1, Properties.Settings.Default.eksilenSayi2);
                sayi2 = rnd.Next(Properties.Settings.Default.cikanSayi1, Properties.Settings.Default.cikanSayi2);
                cikarmaHazirlik();
                
            }
            if (rbCarpma.Checked)
            {
                sayi1 = rnd.Next(Properties.Settings.Default.carpilanSayi1, Properties.Settings.Default.carpilanSayi2);
                sayi2 = rnd.Next(Properties.Settings.Default.carpanSayi1, Properties.Settings.Default.carpanSayi2);
                label2.Text = "x";
                carpmaHazirlik();
            }
            if (rbBolme.Checked)
            {
                sayi1 = rnd.Next(Properties.Settings.Default.bolunenSayi1, Properties.Settings.Default.bolunenSayi2);
                sayi2 = rnd.Next(Properties.Settings.Default.bolenSayi1, Properties.Settings.Default.bolenSayi2);
                label2.Text = "÷";
            }
            
            lblX.Text = sayi1.ToString();
            lblY.Text = sayi2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Mod = 0;
            Mod = sayi1 % sayi2;
            if (Mod==0)
            {
                MessageBox.Show((sayi1 / sayi2).ToString());
            }
            else
            {
                MessageBox.Show(Mod.ToString());
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag.ToString() == ((TextBox)sender).Text)
            {
                ((TextBox)sender).BackColor = Color.Green;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }
    }
}
