
namespace Dört_İşlem_Programı
{
    partial class frmAyarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbBolme = new System.Windows.Forms.RadioButton();
            this.rbCarpma = new System.Windows.Forms.RadioButton();
            this.rbCikarma = new System.Windows.Forms.RadioButton();
            this.rbToplama = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nmrSayi2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrSayi4 = new System.Windows.Forms.NumericUpDown();
            this.nmrSayi3 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi3)).BeginInit();
            this.SuspendLayout();
            // 
            // rbBolme
            // 
            this.rbBolme.AutoSize = true;
            this.rbBolme.BackColor = System.Drawing.Color.Blue;
            this.rbBolme.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBolme.ForeColor = System.Drawing.SystemColors.Control;
            this.rbBolme.Location = new System.Drawing.Point(341, 19);
            this.rbBolme.Name = "rbBolme";
            this.rbBolme.Size = new System.Drawing.Size(72, 24);
            this.rbBolme.TabIndex = 7;
            this.rbBolme.Text = "Bölme";
            this.rbBolme.UseVisualStyleBackColor = false;
            this.rbBolme.CheckedChanged += new System.EventHandler(this.islemRadio);
            // 
            // rbCarpma
            // 
            this.rbCarpma.AutoSize = true;
            this.rbCarpma.BackColor = System.Drawing.Color.Blue;
            this.rbCarpma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCarpma.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCarpma.Location = new System.Drawing.Point(232, 19);
            this.rbCarpma.Name = "rbCarpma";
            this.rbCarpma.Size = new System.Drawing.Size(81, 24);
            this.rbCarpma.TabIndex = 6;
            this.rbCarpma.Text = "Çarpma";
            this.rbCarpma.UseVisualStyleBackColor = false;
            this.rbCarpma.CheckedChanged += new System.EventHandler(this.islemRadio);
            // 
            // rbCikarma
            // 
            this.rbCikarma.AutoSize = true;
            this.rbCikarma.BackColor = System.Drawing.Color.Blue;
            this.rbCikarma.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCikarma.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCikarma.Location = new System.Drawing.Point(122, 19);
            this.rbCikarma.Name = "rbCikarma";
            this.rbCikarma.Size = new System.Drawing.Size(84, 24);
            this.rbCikarma.TabIndex = 5;
            this.rbCikarma.Text = "Çıkarma";
            this.rbCikarma.UseVisualStyleBackColor = false;
            this.rbCikarma.CheckedChanged += new System.EventHandler(this.islemRadio);
            // 
            // rbToplama
            // 
            this.rbToplama.AutoSize = true;
            this.rbToplama.BackColor = System.Drawing.Color.Blue;
            this.rbToplama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbToplama.ForeColor = System.Drawing.SystemColors.Control;
            this.rbToplama.Location = new System.Drawing.Point(14, 19);
            this.rbToplama.Name = "rbToplama";
            this.rbToplama.Size = new System.Drawing.Size(87, 24);
            this.rbToplama.TabIndex = 4;
            this.rbToplama.Text = "Toplama";
            this.rbToplama.UseVisualStyleBackColor = false;
            this.rbToplama.CheckedChanged += new System.EventHandler(this.islemRadio);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sayı 2:";
            // 
            // nmrSayi1
            // 
            this.nmrSayi1.Location = new System.Drawing.Point(167, 99);
            this.nmrSayi1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrSayi1.Name = "nmrSayi1";
            this.nmrSayi1.Size = new System.Drawing.Size(63, 20);
            this.nmrSayi1.TabIndex = 9;
            // 
            // nmrSayi2
            // 
            this.nmrSayi2.Location = new System.Drawing.Point(269, 99);
            this.nmrSayi2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrSayi2.Name = "nmrSayi2";
            this.nmrSayi2.Size = new System.Drawing.Size(63, 20);
            this.nmrSayi2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(192, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sayı Aralığı";
            // 
            // nmrSayi4
            // 
            this.nmrSayi4.Location = new System.Drawing.Point(269, 156);
            this.nmrSayi4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrSayi4.Name = "nmrSayi4";
            this.nmrSayi4.Size = new System.Drawing.Size(63, 20);
            this.nmrSayi4.TabIndex = 13;
            // 
            // nmrSayi3
            // 
            this.nmrSayi3.Location = new System.Drawing.Point(167, 156);
            this.nmrSayi3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrSayi3.Name = "nmrSayi3";
            this.nmrSayi3.Size = new System.Drawing.Size(63, 20);
            this.nmrSayi3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nmrSayi4);
            this.Controls.Add(this.nmrSayi3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrSayi2);
            this.Controls.Add(this.nmrSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbBolme);
            this.Controls.Add(this.rbCarpma);
            this.Controls.Add(this.rbCikarma);
            this.Controls.Add(this.rbToplama);
            this.Name = "frmAyarlar";
            this.Text = "Ayarlar";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBolme;
        private System.Windows.Forms.RadioButton rbCarpma;
        private System.Windows.Forms.RadioButton rbCikarma;
        private System.Windows.Forms.RadioButton rbToplama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrSayi1;
        private System.Windows.Forms.NumericUpDown nmrSayi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrSayi4;
        private System.Windows.Forms.NumericUpDown nmrSayi3;
        private System.Windows.Forms.Button button1;
    }
}