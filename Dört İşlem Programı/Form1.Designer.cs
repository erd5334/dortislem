
namespace Dört_İşlem_Programı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbToplama = new System.Windows.Forms.RadioButton();
            this.rbCikarma = new System.Windows.Forms.RadioButton();
            this.rbCarpma = new System.Windows.Forms.RadioButton();
            this.rbBolme = new System.Windows.Forms.RadioButton();
            this.lblX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbToplama
            // 
            this.rbToplama.AutoSize = true;
            this.rbToplama.BackColor = System.Drawing.Color.Blue;
            this.rbToplama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbToplama.ForeColor = System.Drawing.SystemColors.Control;
            this.rbToplama.Location = new System.Drawing.Point(37, 33);
            this.rbToplama.Name = "rbToplama";
            this.rbToplama.Size = new System.Drawing.Size(87, 24);
            this.rbToplama.TabIndex = 0;
            this.rbToplama.Text = "Toplama";
            this.rbToplama.UseVisualStyleBackColor = false;
            this.rbToplama.CheckedChanged += new System.EventHandler(this.islemRadio_CheckedChanged);
            // 
            // rbCikarma
            // 
            this.rbCikarma.AutoSize = true;
            this.rbCikarma.BackColor = System.Drawing.Color.Blue;
            this.rbCikarma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCikarma.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCikarma.Location = new System.Drawing.Point(145, 33);
            this.rbCikarma.Name = "rbCikarma";
            this.rbCikarma.Size = new System.Drawing.Size(84, 24);
            this.rbCikarma.TabIndex = 1;
            this.rbCikarma.Text = "Çıkarma";
            this.rbCikarma.UseVisualStyleBackColor = false;
            this.rbCikarma.CheckedChanged += new System.EventHandler(this.islemRadio_CheckedChanged);
            // 
            // rbCarpma
            // 
            this.rbCarpma.AutoSize = true;
            this.rbCarpma.BackColor = System.Drawing.Color.Blue;
            this.rbCarpma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCarpma.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCarpma.Location = new System.Drawing.Point(255, 33);
            this.rbCarpma.Name = "rbCarpma";
            this.rbCarpma.Size = new System.Drawing.Size(81, 24);
            this.rbCarpma.TabIndex = 2;
            this.rbCarpma.Text = "Çarpma";
            this.rbCarpma.UseVisualStyleBackColor = false;
            this.rbCarpma.CheckedChanged += new System.EventHandler(this.islemRadio_CheckedChanged);
            // 
            // rbBolme
            // 
            this.rbBolme.AutoSize = true;
            this.rbBolme.BackColor = System.Drawing.Color.Blue;
            this.rbBolme.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBolme.ForeColor = System.Drawing.SystemColors.Control;
            this.rbBolme.Location = new System.Drawing.Point(364, 33);
            this.rbBolme.Name = "rbBolme";
            this.rbBolme.Size = new System.Drawing.Size(72, 24);
            this.rbBolme.TabIndex = 3;
            this.rbBolme.Text = "Bölme";
            this.rbBolme.UseVisualStyleBackColor = false;
            this.rbBolme.CheckedChanged += new System.EventHandler(this.islemRadio_CheckedChanged);
            // 
            // lblX
            // 
            this.lblX.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblX.Location = new System.Drawing.Point(178, 101);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(113, 50);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "197";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "İşlem Türü";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblY
            // 
            this.lblY.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblY.Location = new System.Drawing.Point(178, 131);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(113, 50);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "16";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(167, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "________________________";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(337, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(142, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 144);
            this.panel1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(451, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.rbBolme);
            this.Controls.Add(this.rbCarpma);
            this.Controls.Add(this.rbCikarma);
            this.Controls.Add(this.rbToplama);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dört İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbToplama;
        private System.Windows.Forms.RadioButton rbCikarma;
        private System.Windows.Forms.RadioButton rbCarpma;
        private System.Windows.Forms.RadioButton rbBolme;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

