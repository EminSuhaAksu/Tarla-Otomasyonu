
namespace Proje
{
    partial class MuhasebeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuhasebeForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.tbMuhasebe = new System.Windows.Forms.TabControl();
            this.tbFaturalar = new System.Windows.Forms.TabPage();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.tbSaatKontrol = new System.Windows.Forms.RichTextBox();
            this.btnOdendi = new System.Windows.Forms.Button();
            this.btnFaturaSifirla = new System.Windows.Forms.Button();
            this.lblFaturaArama = new System.Windows.Forms.Label();
            this.btnFaturaArama = new System.Windows.Forms.Button();
            this.tbFaturaArama = new System.Windows.Forms.RichTextBox();
            this.dgvFaturalar = new System.Windows.Forms.DataGridView();
            this.tbKFaturalar = new System.Windows.Forms.TabPage();
            this.btnYazilariSil = new System.Windows.Forms.Button();
            this.tbSaatKontrol2 = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbTutar = new System.Windows.Forms.RichTextBox();
            this.tbIBAN = new System.Windows.Forms.RichTextBox();
            this.tbKurumAdi = new System.Windows.Forms.RichTextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblFaturaIBAN = new System.Windows.Forms.Label();
            this.lblKurumAdi = new System.Windows.Forms.Label();
            this.lblAbone = new System.Windows.Forms.Label();
            this.tbAbone = new System.Windows.Forms.RichTextBox();
            this.btnGeriAl2 = new System.Windows.Forms.Button();
            this.btnOdendi2 = new System.Windows.Forms.Button();
            this.btnKFaturaSifirla = new System.Windows.Forms.Button();
            this.lblKFaturaArama = new System.Windows.Forms.Label();
            this.btnKFaturaArama = new System.Windows.Forms.Button();
            this.tbKFaturaArama = new System.Windows.Forms.RichTextBox();
            this.dgvKFaturalar = new System.Windows.Forms.DataGridView();
            this.tbCalisanlar = new System.Windows.Forms.TabPage();
            this.btnCSifirla = new System.Windows.Forms.Button();
            this.lblCAramaYap = new System.Windows.Forms.Label();
            this.btnCAra = new System.Windows.Forms.Button();
            this.tbCArama = new System.Windows.Forms.RichTextBox();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.tbMuhasebe.SuspendLayout();
            this.tbFaturalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).BeginInit();
            this.tbKFaturalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKFaturalar)).BeginInit();
            this.tbCalisanlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 35);
            this.panel2.TabIndex = 10;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Location = new System.Drawing.Point(1255, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.TabIndex = 9;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1295, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbMuhasebe
            // 
            this.tbMuhasebe.Controls.Add(this.tbFaturalar);
            this.tbMuhasebe.Controls.Add(this.tbKFaturalar);
            this.tbMuhasebe.Controls.Add(this.tbCalisanlar);
            this.tbMuhasebe.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMuhasebe.Location = new System.Drawing.Point(75, 97);
            this.tbMuhasebe.Name = "tbMuhasebe";
            this.tbMuhasebe.SelectedIndex = 0;
            this.tbMuhasebe.Size = new System.Drawing.Size(1180, 570);
            this.tbMuhasebe.TabIndex = 11;
            // 
            // tbFaturalar
            // 
            this.tbFaturalar.BackColor = System.Drawing.Color.Transparent;
            this.tbFaturalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbFaturalar.BackgroundImage")));
            this.tbFaturalar.Controls.Add(this.btnGeriAl);
            this.tbFaturalar.Controls.Add(this.tbSaatKontrol);
            this.tbFaturalar.Controls.Add(this.btnOdendi);
            this.tbFaturalar.Controls.Add(this.btnFaturaSifirla);
            this.tbFaturalar.Controls.Add(this.lblFaturaArama);
            this.tbFaturalar.Controls.Add(this.btnFaturaArama);
            this.tbFaturalar.Controls.Add(this.tbFaturaArama);
            this.tbFaturalar.Controls.Add(this.dgvFaturalar);
            this.tbFaturalar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbFaturalar.Location = new System.Drawing.Point(4, 28);
            this.tbFaturalar.Name = "tbFaturalar";
            this.tbFaturalar.Padding = new System.Windows.Forms.Padding(3);
            this.tbFaturalar.Size = new System.Drawing.Size(1172, 538);
            this.tbFaturalar.TabIndex = 0;
            this.tbFaturalar.Text = "Faturalar";
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriAl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeriAl.Location = new System.Drawing.Point(1062, 132);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(70, 30);
            this.btnGeriAl.TabIndex = 39;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // tbSaatKontrol
            // 
            this.tbSaatKontrol.Location = new System.Drawing.Point(982, 201);
            this.tbSaatKontrol.Name = "tbSaatKontrol";
            this.tbSaatKontrol.Size = new System.Drawing.Size(150, 28);
            this.tbSaatKontrol.TabIndex = 38;
            this.tbSaatKontrol.Text = "";
            this.tbSaatKontrol.Visible = false;
            // 
            // btnOdendi
            // 
            this.btnOdendi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdendi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdendi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdendi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdendi.Location = new System.Drawing.Point(982, 132);
            this.btnOdendi.Name = "btnOdendi";
            this.btnOdendi.Size = new System.Drawing.Size(70, 30);
            this.btnOdendi.TabIndex = 37;
            this.btnOdendi.Text = "Ödendi";
            this.btnOdendi.UseVisualStyleBackColor = true;
            this.btnOdendi.Click += new System.EventHandler(this.btnOdendi_Click);
            // 
            // btnFaturaSifirla
            // 
            this.btnFaturaSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaSifirla.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaSifirla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFaturaSifirla.Location = new System.Drawing.Point(982, 96);
            this.btnFaturaSifirla.Name = "btnFaturaSifirla";
            this.btnFaturaSifirla.Size = new System.Drawing.Size(70, 30);
            this.btnFaturaSifirla.TabIndex = 36;
            this.btnFaturaSifirla.Text = "Sıfırla";
            this.btnFaturaSifirla.UseVisualStyleBackColor = true;
            this.btnFaturaSifirla.Click += new System.EventHandler(this.btnFaturaSifirla_Click);
            // 
            // lblFaturaArama
            // 
            this.lblFaturaArama.AutoSize = true;
            this.lblFaturaArama.BackColor = System.Drawing.Color.Transparent;
            this.lblFaturaArama.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaArama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFaturaArama.Location = new System.Drawing.Point(982, 40);
            this.lblFaturaArama.Name = "lblFaturaArama";
            this.lblFaturaArama.Size = new System.Drawing.Size(89, 19);
            this.lblFaturaArama.TabIndex = 35;
            this.lblFaturaArama.Text = "Arama Yap :";
            // 
            // btnFaturaArama
            // 
            this.btnFaturaArama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturaArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaArama.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaArama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFaturaArama.Location = new System.Drawing.Point(1062, 96);
            this.btnFaturaArama.Name = "btnFaturaArama";
            this.btnFaturaArama.Size = new System.Drawing.Size(70, 30);
            this.btnFaturaArama.TabIndex = 34;
            this.btnFaturaArama.Text = "Ara";
            this.btnFaturaArama.UseVisualStyleBackColor = true;
            this.btnFaturaArama.Click += new System.EventHandler(this.btnFaturaArama_Click);
            // 
            // tbFaturaArama
            // 
            this.tbFaturaArama.Location = new System.Drawing.Point(982, 62);
            this.tbFaturaArama.Name = "tbFaturaArama";
            this.tbFaturaArama.Size = new System.Drawing.Size(150, 28);
            this.tbFaturaArama.TabIndex = 33;
            this.tbFaturaArama.Text = "";
            // 
            // dgvFaturalar
            // 
            this.dgvFaturalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFaturalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFaturalar.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturalar.Location = new System.Drawing.Point(0, 0);
            this.dgvFaturalar.Name = "dgvFaturalar";
            this.dgvFaturalar.ReadOnly = true;
            this.dgvFaturalar.Size = new System.Drawing.Size(942, 540);
            this.dgvFaturalar.TabIndex = 1;
            this.dgvFaturalar.Tag = "";
            this.dgvFaturalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaturalar_CellClick);
            // 
            // tbKFaturalar
            // 
            this.tbKFaturalar.BackColor = System.Drawing.Color.Transparent;
            this.tbKFaturalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbKFaturalar.BackgroundImage")));
            this.tbKFaturalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbKFaturalar.Controls.Add(this.btnYazilariSil);
            this.tbKFaturalar.Controls.Add(this.tbSaatKontrol2);
            this.tbKFaturalar.Controls.Add(this.btnEkle);
            this.tbKFaturalar.Controls.Add(this.tbTutar);
            this.tbKFaturalar.Controls.Add(this.tbIBAN);
            this.tbKFaturalar.Controls.Add(this.tbKurumAdi);
            this.tbKFaturalar.Controls.Add(this.lblTutar);
            this.tbKFaturalar.Controls.Add(this.lblFaturaIBAN);
            this.tbKFaturalar.Controls.Add(this.lblKurumAdi);
            this.tbKFaturalar.Controls.Add(this.lblAbone);
            this.tbKFaturalar.Controls.Add(this.tbAbone);
            this.tbKFaturalar.Controls.Add(this.btnGeriAl2);
            this.tbKFaturalar.Controls.Add(this.btnOdendi2);
            this.tbKFaturalar.Controls.Add(this.btnKFaturaSifirla);
            this.tbKFaturalar.Controls.Add(this.lblKFaturaArama);
            this.tbKFaturalar.Controls.Add(this.btnKFaturaArama);
            this.tbKFaturalar.Controls.Add(this.tbKFaturaArama);
            this.tbKFaturalar.Controls.Add(this.dgvKFaturalar);
            this.tbKFaturalar.Location = new System.Drawing.Point(4, 28);
            this.tbKFaturalar.Name = "tbKFaturalar";
            this.tbKFaturalar.Padding = new System.Windows.Forms.Padding(3);
            this.tbKFaturalar.Size = new System.Drawing.Size(1172, 538);
            this.tbKFaturalar.TabIndex = 1;
            this.tbKFaturalar.Text = "Kurumsal Faturalar";
            // 
            // btnYazilariSil
            // 
            this.btnYazilariSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazilariSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazilariSil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazilariSil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYazilariSil.Location = new System.Drawing.Point(956, 297);
            this.btnYazilariSil.Name = "btnYazilariSil";
            this.btnYazilariSil.Size = new System.Drawing.Size(90, 30);
            this.btnYazilariSil.TabIndex = 56;
            this.btnYazilariSil.Text = "Yazıları Sil";
            this.btnYazilariSil.UseVisualStyleBackColor = true;
            this.btnYazilariSil.Click += new System.EventHandler(this.btnYazilariSil_Click);
            // 
            // tbSaatKontrol2
            // 
            this.tbSaatKontrol2.Location = new System.Drawing.Point(1016, 504);
            this.tbSaatKontrol2.Name = "tbSaatKontrol2";
            this.tbSaatKontrol2.Size = new System.Drawing.Size(150, 28);
            this.tbSaatKontrol2.TabIndex = 55;
            this.tbSaatKontrol2.Text = "";
            this.tbSaatKontrol2.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEkle.Location = new System.Drawing.Point(702, 297);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(70, 30);
            this.btnEkle.TabIndex = 54;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbTutar
            // 
            this.tbTutar.Location = new System.Drawing.Point(876, 253);
            this.tbTutar.Name = "tbTutar";
            this.tbTutar.Size = new System.Drawing.Size(150, 28);
            this.tbTutar.TabIndex = 53;
            this.tbTutar.Text = "";
            // 
            // tbIBAN
            // 
            this.tbIBAN.Location = new System.Drawing.Point(702, 253);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.Size = new System.Drawing.Size(150, 28);
            this.tbIBAN.TabIndex = 52;
            this.tbIBAN.Text = "";
            // 
            // tbKurumAdi
            // 
            this.tbKurumAdi.Location = new System.Drawing.Point(876, 196);
            this.tbKurumAdi.Name = "tbKurumAdi";
            this.tbKurumAdi.Size = new System.Drawing.Size(150, 28);
            this.tbKurumAdi.TabIndex = 51;
            this.tbKurumAdi.Text = "";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTutar.Location = new System.Drawing.Point(876, 231);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(56, 19);
            this.lblTutar.TabIndex = 50;
            this.lblTutar.Text = "Tutar :";
            // 
            // lblFaturaIBAN
            // 
            this.lblFaturaIBAN.AutoSize = true;
            this.lblFaturaIBAN.BackColor = System.Drawing.Color.Transparent;
            this.lblFaturaIBAN.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaIBAN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFaturaIBAN.Location = new System.Drawing.Point(698, 231);
            this.lblFaturaIBAN.Name = "lblFaturaIBAN";
            this.lblFaturaIBAN.Size = new System.Drawing.Size(45, 19);
            this.lblFaturaIBAN.TabIndex = 49;
            this.lblFaturaIBAN.Text = "IBAN";
            // 
            // lblKurumAdi
            // 
            this.lblKurumAdi.AutoSize = true;
            this.lblKurumAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKurumAdi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurumAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKurumAdi.Location = new System.Drawing.Point(876, 174);
            this.lblKurumAdi.Name = "lblKurumAdi";
            this.lblKurumAdi.Size = new System.Drawing.Size(87, 19);
            this.lblKurumAdi.TabIndex = 48;
            this.lblKurumAdi.Text = "Kurum Adı :";
            // 
            // lblAbone
            // 
            this.lblAbone.AutoSize = true;
            this.lblAbone.BackColor = System.Drawing.Color.Transparent;
            this.lblAbone.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAbone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbone.Location = new System.Drawing.Point(702, 174);
            this.lblAbone.Name = "lblAbone";
            this.lblAbone.Size = new System.Drawing.Size(84, 19);
            this.lblAbone.TabIndex = 47;
            this.lblAbone.Text = "Abone No :";
            // 
            // tbAbone
            // 
            this.tbAbone.Location = new System.Drawing.Point(702, 196);
            this.tbAbone.Name = "tbAbone";
            this.tbAbone.Size = new System.Drawing.Size(150, 28);
            this.tbAbone.TabIndex = 46;
            this.tbAbone.Text = "";
            // 
            // btnGeriAl2
            // 
            this.btnGeriAl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriAl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAl2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriAl2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeriAl2.Location = new System.Drawing.Point(880, 297);
            this.btnGeriAl2.Name = "btnGeriAl2";
            this.btnGeriAl2.Size = new System.Drawing.Size(70, 30);
            this.btnGeriAl2.TabIndex = 45;
            this.btnGeriAl2.Text = "Geri Al";
            this.btnGeriAl2.UseVisualStyleBackColor = true;
            this.btnGeriAl2.Click += new System.EventHandler(this.btnGeriAl2_Click);
            // 
            // btnOdendi2
            // 
            this.btnOdendi2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdendi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdendi2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdendi2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdendi2.Location = new System.Drawing.Point(782, 297);
            this.btnOdendi2.Name = "btnOdendi2";
            this.btnOdendi2.Size = new System.Drawing.Size(70, 30);
            this.btnOdendi2.TabIndex = 44;
            this.btnOdendi2.Text = "Ödendi";
            this.btnOdendi2.UseVisualStyleBackColor = true;
            this.btnOdendi2.Click += new System.EventHandler(this.btnOdendi2_Click);
            // 
            // btnKFaturaSifirla
            // 
            this.btnKFaturaSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKFaturaSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKFaturaSifirla.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKFaturaSifirla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKFaturaSifirla.Location = new System.Drawing.Point(702, 96);
            this.btnKFaturaSifirla.Name = "btnKFaturaSifirla";
            this.btnKFaturaSifirla.Size = new System.Drawing.Size(70, 30);
            this.btnKFaturaSifirla.TabIndex = 43;
            this.btnKFaturaSifirla.Text = "Sıfırla";
            this.btnKFaturaSifirla.UseVisualStyleBackColor = true;
            this.btnKFaturaSifirla.Click += new System.EventHandler(this.btnKFaturaSifirla_Click);
            // 
            // lblKFaturaArama
            // 
            this.lblKFaturaArama.AutoSize = true;
            this.lblKFaturaArama.BackColor = System.Drawing.Color.Transparent;
            this.lblKFaturaArama.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKFaturaArama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKFaturaArama.Location = new System.Drawing.Point(702, 40);
            this.lblKFaturaArama.Name = "lblKFaturaArama";
            this.lblKFaturaArama.Size = new System.Drawing.Size(89, 19);
            this.lblKFaturaArama.TabIndex = 42;
            this.lblKFaturaArama.Text = "Arama Yap :";
            // 
            // btnKFaturaArama
            // 
            this.btnKFaturaArama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKFaturaArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKFaturaArama.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKFaturaArama.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKFaturaArama.Location = new System.Drawing.Point(782, 96);
            this.btnKFaturaArama.Name = "btnKFaturaArama";
            this.btnKFaturaArama.Size = new System.Drawing.Size(70, 30);
            this.btnKFaturaArama.TabIndex = 41;
            this.btnKFaturaArama.Text = "Ara";
            this.btnKFaturaArama.UseVisualStyleBackColor = true;
            this.btnKFaturaArama.Click += new System.EventHandler(this.btnKFaturaArama_Click);
            // 
            // tbKFaturaArama
            // 
            this.tbKFaturaArama.Location = new System.Drawing.Point(702, 62);
            this.tbKFaturaArama.Name = "tbKFaturaArama";
            this.tbKFaturaArama.Size = new System.Drawing.Size(150, 28);
            this.tbKFaturaArama.TabIndex = 40;
            this.tbKFaturaArama.Text = "";
            // 
            // dgvKFaturalar
            // 
            this.dgvKFaturalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKFaturalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKFaturalar.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvKFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKFaturalar.Location = new System.Drawing.Point(0, 0);
            this.dgvKFaturalar.Name = "dgvKFaturalar";
            this.dgvKFaturalar.ReadOnly = true;
            this.dgvKFaturalar.Size = new System.Drawing.Size(662, 540);
            this.dgvKFaturalar.TabIndex = 2;
            this.dgvKFaturalar.Tag = "";
            this.dgvKFaturalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKFaturalar_CellClick);
            // 
            // tbCalisanlar
            // 
            this.tbCalisanlar.BackColor = System.Drawing.Color.Transparent;
            this.tbCalisanlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbCalisanlar.BackgroundImage")));
            this.tbCalisanlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCalisanlar.Controls.Add(this.btnCSifirla);
            this.tbCalisanlar.Controls.Add(this.lblCAramaYap);
            this.tbCalisanlar.Controls.Add(this.btnCAra);
            this.tbCalisanlar.Controls.Add(this.tbCArama);
            this.tbCalisanlar.Controls.Add(this.dgvCalisanlar);
            this.tbCalisanlar.Location = new System.Drawing.Point(4, 28);
            this.tbCalisanlar.Name = "tbCalisanlar";
            this.tbCalisanlar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCalisanlar.Size = new System.Drawing.Size(1172, 538);
            this.tbCalisanlar.TabIndex = 2;
            this.tbCalisanlar.Text = "Çalışanlar";
            // 
            // btnCSifirla
            // 
            this.btnCSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSifirla.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCSifirla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCSifirla.Location = new System.Drawing.Point(983, 88);
            this.btnCSifirla.Name = "btnCSifirla";
            this.btnCSifirla.Size = new System.Drawing.Size(70, 30);
            this.btnCSifirla.TabIndex = 40;
            this.btnCSifirla.Text = "Sıfırla";
            this.btnCSifirla.UseVisualStyleBackColor = true;
            this.btnCSifirla.Click += new System.EventHandler(this.btnCSifirla_Click);
            // 
            // lblCAramaYap
            // 
            this.lblCAramaYap.AutoSize = true;
            this.lblCAramaYap.BackColor = System.Drawing.Color.Transparent;
            this.lblCAramaYap.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCAramaYap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCAramaYap.Location = new System.Drawing.Point(983, 32);
            this.lblCAramaYap.Name = "lblCAramaYap";
            this.lblCAramaYap.Size = new System.Drawing.Size(89, 19);
            this.lblCAramaYap.TabIndex = 39;
            this.lblCAramaYap.Text = "Arama Yap :";
            // 
            // btnCAra
            // 
            this.btnCAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCAra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCAra.Location = new System.Drawing.Point(1063, 88);
            this.btnCAra.Name = "btnCAra";
            this.btnCAra.Size = new System.Drawing.Size(70, 30);
            this.btnCAra.TabIndex = 38;
            this.btnCAra.Text = "Ara";
            this.btnCAra.UseVisualStyleBackColor = true;
            this.btnCAra.Click += new System.EventHandler(this.btnCAra_Click);
            // 
            // tbCArama
            // 
            this.tbCArama.Location = new System.Drawing.Point(983, 54);
            this.tbCArama.Name = "tbCArama";
            this.tbCArama.Size = new System.Drawing.Size(150, 28);
            this.tbCArama.TabIndex = 37;
            this.tbCArama.Text = "";
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalisanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvCalisanlar.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(0, 0);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.ReadOnly = true;
            this.dgvCalisanlar.Size = new System.Drawing.Size(942, 540);
            this.dgvCalisanlar.TabIndex = 2;
            this.dgvCalisanlar.Tag = "";
            // 
            // MuhasebeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 770);
            this.Controls.Add(this.tbMuhasebe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuhasebeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MuhasebeForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.tbMuhasebe.ResumeLayout(false);
            this.tbFaturalar.ResumeLayout(false);
            this.tbFaturalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).EndInit();
            this.tbKFaturalar.ResumeLayout(false);
            this.tbKFaturalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKFaturalar)).EndInit();
            this.tbCalisanlar.ResumeLayout(false);
            this.tbCalisanlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.TabControl tbMuhasebe;
        private System.Windows.Forms.TabPage tbFaturalar;
        private System.Windows.Forms.TabPage tbKFaturalar;
        private System.Windows.Forms.TabPage tbCalisanlar;
        public System.Windows.Forms.DataGridView dgvFaturalar;
        private System.Windows.Forms.Button btnFaturaSifirla;
        private System.Windows.Forms.Label lblFaturaArama;
        private System.Windows.Forms.Button btnFaturaArama;
        private System.Windows.Forms.RichTextBox tbFaturaArama;
        private System.Windows.Forms.Button btnOdendi;
        private System.Windows.Forms.RichTextBox tbSaatKontrol;
        private System.Windows.Forms.Button btnGeriAl;
        public System.Windows.Forms.DataGridView dgvKFaturalar;
        private System.Windows.Forms.Button btnGeriAl2;
        private System.Windows.Forms.Button btnOdendi2;
        private System.Windows.Forms.Button btnKFaturaSifirla;
        private System.Windows.Forms.Label lblKFaturaArama;
        private System.Windows.Forms.Button btnKFaturaArama;
        private System.Windows.Forms.RichTextBox tbKFaturaArama;
        private System.Windows.Forms.RichTextBox tbTutar;
        private System.Windows.Forms.RichTextBox tbIBAN;
        private System.Windows.Forms.RichTextBox tbKurumAdi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblFaturaIBAN;
        private System.Windows.Forms.Label lblKurumAdi;
        private System.Windows.Forms.Label lblAbone;
        private System.Windows.Forms.RichTextBox tbAbone;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox tbSaatKontrol2;
        private System.Windows.Forms.Button btnYazilariSil;
        private System.Windows.Forms.Button btnCSifirla;
        private System.Windows.Forms.Label lblCAramaYap;
        private System.Windows.Forms.Button btnCAra;
        private System.Windows.Forms.RichTextBox tbCArama;
        public System.Windows.Forms.DataGridView dgvCalisanlar;
    }
}