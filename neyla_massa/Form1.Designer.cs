namespace neyla_massa
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txNilai = new System.Windows.Forms.TextBox();
            this.cbDari = new System.Windows.Forms.ComboBox();
            this.cbKe = new System.Windows.Forms.ComboBox();
            this.txHasil = new System.Windows.Forms.TextBox();
            this.btHasil = new System.Windows.Forms.Button();
            this.btBersih = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konversi Massa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 68);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ke";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasil";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txNilai
            // 
            this.txNilai.Location = new System.Drawing.Point(248, 117);
            this.txNilai.Name = "txNilai";
            this.txNilai.Size = new System.Drawing.Size(209, 20);
            this.txNilai.TabIndex = 6;
            // 
            // cbDari
            // 
            this.cbDari.FormattingEnabled = true;
            this.cbDari.Items.AddRange(new object[] {
            "Kg",
            "Ons",
            "Kw",
            "Ton"});
            this.cbDari.Location = new System.Drawing.Point(248, 152);
            this.cbDari.Name = "cbDari";
            this.cbDari.Size = new System.Drawing.Size(209, 21);
            this.cbDari.TabIndex = 7;
            // 
            // cbKe
            // 
            this.cbKe.FormattingEnabled = true;
            this.cbKe.Items.AddRange(new object[] {
            "Kg",
            "Ons",
            "Kw",
            "Ton"});
            this.cbKe.Location = new System.Drawing.Point(248, 189);
            this.cbKe.Name = "cbKe";
            this.cbKe.Size = new System.Drawing.Size(209, 21);
            this.cbKe.TabIndex = 8;
            // 
            // txHasil
            // 
            this.txHasil.Location = new System.Drawing.Point(248, 228);
            this.txHasil.Multiline = true;
            this.txHasil.Name = "txHasil";
            this.txHasil.Size = new System.Drawing.Size(209, 118);
            this.txHasil.TabIndex = 9;
            // 
            // btHasil
            // 
            this.btHasil.BackColor = System.Drawing.Color.RosyBrown;
            this.btHasil.Location = new System.Drawing.Point(248, 380);
            this.btHasil.Name = "btHasil";
            this.btHasil.Size = new System.Drawing.Size(75, 23);
            this.btHasil.TabIndex = 10;
            this.btHasil.Text = "Proses";
            this.btHasil.UseVisualStyleBackColor = false;
            this.btHasil.Click += new System.EventHandler(this.btHasil_Click);
            // 
            // btBersih
            // 
            this.btBersih.BackColor = System.Drawing.Color.RosyBrown;
            this.btBersih.Location = new System.Drawing.Point(382, 380);
            this.btBersih.Name = "btBersih";
            this.btBersih.Size = new System.Drawing.Size(75, 23);
            this.btBersih.TabIndex = 11;
            this.btBersih.Text = "Bersih";
            this.btBersih.UseVisualStyleBackColor = false;
            this.btBersih.Click += new System.EventHandler(this.btBersih_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.btBersih);
            this.Controls.Add(this.btHasil);
            this.Controls.Add(this.txHasil);
            this.Controls.Add(this.cbKe);
            this.Controls.Add(this.cbDari);
            this.Controls.Add(this.txNilai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNilai;
        private System.Windows.Forms.ComboBox cbDari;
        private System.Windows.Forms.ComboBox cbKe;
        private System.Windows.Forms.TextBox txHasil;
        private System.Windows.Forms.Button btHasil;
        private System.Windows.Forms.Button btBersih;
    }
}

