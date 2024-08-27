namespace PlakDükkanı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btn_Albumler = new Button();
            label8 = new Label();
            nud_Indirim = new NumericUpDown();
            btn_Indirimdeki = new Button();
            btn_SonOnAlbum = new Button();
            btn_SatisDevam = new Button();
            btn_SatisDurmus = new Button();
            btn_Güncelle = new Button();
            btn_Ekle = new Button();
            dgw_Albüm = new DataGridView();
            cms_Albüm = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            nud_Fiyatı = new NumericUpDown();
            dtp_CikisTarihi = new DateTimePicker();
            txt_Artist = new TextBox();
            txt_AlbumAdi = new TextBox();
            chk_SatistaMi = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Indirim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Albüm).BeginInit();
            cms_Albüm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Fiyatı).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btn_Albumler);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(nud_Indirim);
            groupBox1.Controls.Add(btn_Indirimdeki);
            groupBox1.Controls.Add(btn_SonOnAlbum);
            groupBox1.Controls.Add(btn_SatisDevam);
            groupBox1.Controls.Add(btn_SatisDurmus);
            groupBox1.Controls.Add(btn_Güncelle);
            groupBox1.Controls.Add(btn_Ekle);
            groupBox1.Controls.Add(dgw_Albüm);
            groupBox1.Controls.Add(nud_Fiyatı);
            groupBox1.Controls.Add(dtp_CikisTarihi);
            groupBox1.Controls.Add(txt_Artist);
            groupBox1.Controls.Add(txt_AlbumAdi);
            groupBox1.Controls.Add(chk_SatistaMi);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(-1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 527);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dedemin Plakları";
            // 
            // btn_Albumler
            // 
            btn_Albumler.BackColor = Color.FromArgb(128, 255, 255);
            btn_Albumler.FlatStyle = FlatStyle.Flat;
            btn_Albumler.Location = new Point(312, 426);
            btn_Albumler.Name = "btn_Albumler";
            btn_Albumler.Size = new Size(75, 62);
            btn_Albumler.TabIndex = 21;
            btn_Albumler.Text = "Albümler";
            btn_Albumler.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 195);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 20;
            label8.Text = "Satışta mı?";
            // 
            // nud_Indirim
            // 
            nud_Indirim.BackColor = SystemColors.ActiveCaption;
            nud_Indirim.BorderStyle = BorderStyle.FixedSingle;
            nud_Indirim.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nud_Indirim.Location = new Point(175, 156);
            nud_Indirim.Name = "nud_Indirim";
            nud_Indirim.Size = new Size(212, 23);
            nud_Indirim.TabIndex = 19;
            // 
            // btn_Indirimdeki
            // 
            btn_Indirimdeki.BackColor = Color.FromArgb(255, 128, 0);
            btn_Indirimdeki.FlatStyle = FlatStyle.Flat;
            btn_Indirimdeki.Location = new Point(154, 426);
            btn_Indirimdeki.Name = "btn_Indirimdeki";
            btn_Indirimdeki.Size = new Size(138, 23);
            btn_Indirimdeki.TabIndex = 18;
            btn_Indirimdeki.Text = "İndirimdeki Albümler";
            btn_Indirimdeki.UseVisualStyleBackColor = false;
            // 
            // btn_SonOnAlbum
            // 
            btn_SonOnAlbum.BackColor = Color.FromArgb(128, 128, 255);
            btn_SonOnAlbum.FlatStyle = FlatStyle.Flat;
            btn_SonOnAlbum.Location = new Point(154, 465);
            btn_SonOnAlbum.Name = "btn_SonOnAlbum";
            btn_SonOnAlbum.Size = new Size(138, 23);
            btn_SonOnAlbum.TabIndex = 15;
            btn_SonOnAlbum.Text = "Eklenen Son 10 Albüm";
            btn_SonOnAlbum.UseVisualStyleBackColor = false;
            // 
            // btn_SatisDevam
            // 
            btn_SatisDevam.BackColor = Color.Lime;
            btn_SatisDevam.FlatStyle = FlatStyle.Flat;
            btn_SatisDevam.Location = new Point(17, 426);
            btn_SatisDevam.Name = "btn_SatisDevam";
            btn_SatisDevam.Size = new Size(105, 23);
            btn_SatisDevam.TabIndex = 14;
            btn_SatisDevam.Text = "Satışı Devam ";
            btn_SatisDevam.UseVisualStyleBackColor = false;
            // 
            // btn_SatisDurmus
            // 
            btn_SatisDurmus.BackColor = Color.Red;
            btn_SatisDurmus.FlatStyle = FlatStyle.Flat;
            btn_SatisDurmus.Location = new Point(17, 465);
            btn_SatisDurmus.Name = "btn_SatisDurmus";
            btn_SatisDurmus.Size = new Size(105, 23);
            btn_SatisDurmus.TabIndex = 13;
            btn_SatisDurmus.Text = "Satışı Durmuş";
            btn_SatisDurmus.UseVisualStyleBackColor = false;
            // 
            // btn_Güncelle
            // 
            btn_Güncelle.BackColor = SystemColors.ActiveBorder;
            btn_Güncelle.Location = new Point(233, 235);
            btn_Güncelle.Name = "btn_Güncelle";
            btn_Güncelle.Size = new Size(154, 34);
            btn_Güncelle.TabIndex = 12;
            btn_Güncelle.Text = "Güncelle";
            btn_Güncelle.UseVisualStyleBackColor = false;
            // 
            // btn_Ekle
            // 
            btn_Ekle.BackColor = SystemColors.ActiveBorder;
            btn_Ekle.Location = new Point(17, 235);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(150, 34);
            btn_Ekle.TabIndex = 11;
            btn_Ekle.Text = "Ekle";
            btn_Ekle.UseVisualStyleBackColor = false;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // dgw_Albüm
            // 
            dgw_Albüm.BackgroundColor = SystemColors.ActiveCaption;
            dgw_Albüm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Albüm.ContextMenuStrip = cms_Albüm;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgw_Albüm.DefaultCellStyle = dataGridViewCellStyle1;
            dgw_Albüm.Location = new Point(6, 275);
            dgw_Albüm.MultiSelect = false;
            dgw_Albüm.Name = "dgw_Albüm";
            dgw_Albüm.ReadOnly = true;
            dgw_Albüm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Albüm.Size = new Size(560, 145);
            dgw_Albüm.TabIndex = 10;
            // 
            // cms_Albüm
            // 
            cms_Albüm.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem });
            cms_Albüm.Name = "cms_Albüm";
            cms_Albüm.Size = new Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(120, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(120, 22);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // nud_Fiyatı
            // 
            nud_Fiyatı.BackColor = SystemColors.ActiveCaption;
            nud_Fiyatı.BorderStyle = BorderStyle.FixedSingle;
            nud_Fiyatı.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nud_Fiyatı.Location = new Point(175, 119);
            nud_Fiyatı.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_Fiyatı.Name = "nud_Fiyatı";
            nud_Fiyatı.Size = new Size(212, 23);
            nud_Fiyatı.TabIndex = 9;
            // 
            // dtp_CikisTarihi
            // 
            dtp_CikisTarihi.CalendarForeColor = Color.Coral;
            dtp_CikisTarihi.CalendarMonthBackground = SystemColors.ActiveCaption;
            dtp_CikisTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtp_CikisTarihi.Location = new Point(175, 91);
            dtp_CikisTarihi.Name = "dtp_CikisTarihi";
            dtp_CikisTarihi.Size = new Size(212, 23);
            dtp_CikisTarihi.TabIndex = 8;
            // 
            // txt_Artist
            // 
            txt_Artist.BackColor = SystemColors.ActiveCaption;
            txt_Artist.BorderStyle = BorderStyle.FixedSingle;
            txt_Artist.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_Artist.Location = new Point(175, 62);
            txt_Artist.Name = "txt_Artist";
            txt_Artist.Size = new Size(212, 23);
            txt_Artist.TabIndex = 7;
            // 
            // txt_AlbumAdi
            // 
            txt_AlbumAdi.BackColor = SystemColors.ActiveCaption;
            txt_AlbumAdi.BorderStyle = BorderStyle.FixedSingle;
            txt_AlbumAdi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_AlbumAdi.Location = new Point(175, 32);
            txt_AlbumAdi.Name = "txt_AlbumAdi";
            txt_AlbumAdi.Size = new Size(212, 23);
            txt_AlbumAdi.TabIndex = 6;
            // 
            // chk_SatistaMi
            // 
            chk_SatistaMi.AutoSize = true;
            chk_SatistaMi.BackgroundImageLayout = ImageLayout.Zoom;
            chk_SatistaMi.Location = new Point(175, 195);
            chk_SatistaMi.Name = "chk_SatistaMi";
            chk_SatistaMi.Size = new Size(48, 19);
            chk_SatistaMi.TabIndex = 5;
            chk_SatistaMi.Text = "Evet";
            chk_SatistaMi.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 156);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 4;
            label9.Text = "İndirim:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 123);
            label10.Name = "label10";
            label10.Size = new Size(77, 15);
            label10.TabIndex = 3;
            label10.Text = "Albüm Fiyatı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 94);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 2;
            label11.Text = "Albüm Çıkış Tarihi:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 70);
            label12.Name = "label12";
            label12.Size = new Size(109, 15);
            label12.TabIndex = 1;
            label12.Text = "Albümün Sanatçısı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 40);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 0;
            label13.Text = "Albüm Adı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 534);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Indirim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Albüm).EndInit();
            cms_Albüm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud_Fiyatı).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Albumler;
        private Label label8;
        private NumericUpDown nud_Indirim;
        private Button btn_Indirimdeki;
        private Button btn_SonOnAlbum;
        private Button btn_SatisDevam;
        private Button btn_SatisDurmus;
        private Button btn_Güncelle;
        private Button btn_Ekle;
        private DataGridView dgw_Albüm;
        private NumericUpDown nud_Fiyatı;
        private DateTimePicker dtp_CikisTarihi;
        private TextBox txt_Artist;
        private TextBox txt_AlbumAdi;
        private CheckBox chk_SatistaMi;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ContextMenuStrip cms_Albüm;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
    }
}
