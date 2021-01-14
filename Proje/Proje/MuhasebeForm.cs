using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proje
{
    public partial class MuhasebeForm : Form
    {
        int MouseX, MouseY;
        bool MouseM;
        public MuhasebeForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //
            // Faturalar
            //
            lblFaturaArama.BackColor = Color.FromArgb(100, Color.Black);
            btnFaturaSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnFaturaArama.BackColor = Color.FromArgb(100, Color.Black);
            btnOdendi.BackColor = Color.FromArgb(100, Color.Black);
            btnGeriAl.BackColor = Color.FromArgb(100, Color.Black);
            beyin();
            //
            // Kurum Faturalar
            //
            lblKFaturaArama.BackColor = Color.FromArgb(100, Color.Black);
            lblAbone.BackColor = Color.FromArgb(100, Color.Black);
            lblKurumAdi.BackColor = Color.FromArgb(100, Color.Black);
            lblFaturaIBAN.BackColor = Color.FromArgb(100, Color.Black);
            lblTutar.BackColor = Color.FromArgb(100, Color.Black);
            btnEkle.BackColor = Color.FromArgb(100, Color.Black);
            btnOdendi.BackColor = Color.FromArgb(100, Color.Black);
            btnGeriAl.BackColor = Color.FromArgb(100, Color.Black);
            btnOdendi2.BackColor = Color.FromArgb(100, Color.Black);
            btnGeriAl2.BackColor = Color.FromArgb(100, Color.Black);
            btnYazilariSil.BackColor = Color.FromArgb(100, Color.Black);
            faruk();
            //
            // Çalışanlar
            //
            lblCAramaYap.BackColor = Color.FromArgb(100, Color.Black);
            btnCSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnCAra.BackColor = Color.FromArgb(100, Color.Black);
            sirdan();
        }
        //
        // Kapatma ve alta alma tuşu
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            LogingForm nextForm = new LogingForm();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseX = e.X;
            MouseY = e.Y;
            MouseM = true;
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseM = false;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseM)
            {
                SetDesktopLocation(MousePosition.X - MouseX, MousePosition.Y - MouseY);
            }
        }
        //
        // Faturalar tabı
        //
        private void btnFaturaSifirla_Click(object sender, EventArgs e)
        {
            tbFaturaArama.Text = "";
            beyin();
        }
        private void dgvFaturalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFaturalar.Rows[e.RowIndex];
                tbSaatKontrol.Text= row.Cells[10].Value.ToString(); 
            }
        }
        private void btnOdendi_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            connection.Open();
            OracleCommand a = new OracleCommand("ODENDI_YAP", connection);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Connection = connection;
            a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSaatKontrol.Text;
            a.ExecuteNonQuery();
            connection.Close();
            beyin();
        } // Ödendi Tuşu
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            connection.Open();
            OracleCommand a = new OracleCommand("GERI_AL", connection);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Connection = connection;
            a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSaatKontrol.Text;
            a.ExecuteNonQuery();
            connection.Close();
            beyin();
        } //Geri Alma Tuşu
            //
            // Faturalara bilgi çeken
            //
        public void beyin()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI,URUN_TURU,MIKTAR,MIKTAR_TURU,KISI_ADI AS AD,KISI_SOYADI AS SOYAD,IBAN,TEL_NO,TARIH AS İŞLEM_TARİHİ,SAAT AS İŞLEM_SAATİ,ODENDI_BILGISI,ODENDIGI_TARIH,ODENDIGI_SAAT FROM FATURALAR";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvFaturalar.DataSource = dt;
            connection.Close();
        }
                //
                // Faturalarda arayan
                //
        private void btnFaturaArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI,URUN_TURU,MIKTAR,MIKTAR_TURU,KISI_ADI AS AD,KISI_SOYADI AS SOYAD,IBAN,TEL_NO,TARIH AS İŞLEM_TARİHİ,SAAT AS İŞLEM_SAATİ,ODENDI_BILGISI,ODENDIGI_TARIH,ODENDIGI_SAAT FROM FATURALAR WHERE URUN_ID LIKE '%" + tbFaturaArama.Text + "%' or URUN_ADI LIKE '%" + tbFaturaArama.Text + "%' or URUN_TURU LIKE '%" + tbFaturaArama.Text + "%' or MIKTAR LIKE '%" + tbFaturaArama.Text + "%' or KISI_ADI LIKE '%" + tbFaturaArama.Text + "%' or KISI_SOYADI LIKE '%" + tbFaturaArama.Text + "%' or IBAN LIKE '%" + tbFaturaArama.Text + "%' or TEL_NO LIKE '%" + tbFaturaArama.Text + "%' or TARIH LIKE '%" + tbFaturaArama.Text + "%' or SAAT LIKE '%" + tbFaturaArama.Text + "%' or ODENDI_BILGISI LIKE '%" + tbFaturaArama.Text + "%' or ODENDIGI_TARIH LIKE '%" + tbFaturaArama.Text + "%' or ODENDIGI_SAAT LIKE '%" + tbFaturaArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvFaturalar.DataSource = dt;
            connection.Close();
        }
        //
        // Kurumsal Faturalar tabı
        //
        private void btnKFaturaSifirla_Click(object sender, EventArgs e)
        {
            tbKFaturaArama.Text = "";
            faruk();
        }
        private void dgvKFaturalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKFaturalar.Rows[e.RowIndex];
                tbAbone.Text= row.Cells[0].Value.ToString();
                tbKurumAdi.Text= row.Cells[1].Value.ToString();
                tbIBAN.Text= row.Cells[2].Value.ToString();
                tbTutar.Text= row.Cells[3].Value.ToString();
                tbSaatKontrol2.Text = row.Cells[7].Value.ToString();
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(tbAbone.Text=="" || tbKurumAdi.Text=="" || tbIBAN.Text=="" || tbTutar.Text=="")
            {
                MessageBox.Show("Gerekli Alanları Lütfen Doldurunuz!");
            }
            else
            {
                OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
                OracleCommand command = new OracleCommand();
                connection.Open();
                OracleCommand a = new OracleCommand("KURUM_FATURA_EKLE", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Connection = connection;
                a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbAbone.Text;
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbKurumAdi.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbIBAN.Text;
                a.Parameters.Add("X4", OracleDbType.Double).Value = double.Parse(tbTutar.Text);
                a.ExecuteNonQuery();
                connection.Close();
                faruk();
            }
            
        } // Ekleyen
        private void btnOdendi2_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            connection.Open();
            OracleCommand a = new OracleCommand("KURUM_ODENDI_YAP", connection);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Connection = connection;
            a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSaatKontrol2.Text;
            a.ExecuteNonQuery();
            connection.Close();
            faruk();
        } //Ödeyen
        private void btnGeriAl2_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            connection.Open();
            OracleCommand a = new OracleCommand("KURUM_GERI_AL", connection);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Connection = connection;
            a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSaatKontrol2.Text;
            a.ExecuteNonQuery();
            connection.Close();
            faruk();
        } // Ödemeyi geri alan
        private void btnYazilariSil_Click(object sender, EventArgs e)
        {
            tbAbone.Text = "";
            tbKurumAdi.Text = "";
            tbIBAN.Text = "";
            tbTutar.Text = "";
        }
            //
            // Kurumsal Faturalara bilgi çeken
            //
        public void faruk()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ABONE_NO,KURUM_ADI,FATURA_IBAN,TUTAR,ODENDI_BILGISI,ODENDIGI_TARIH,ODENDIGI_SAAT,GECICI FROM KURUM_FATURALARI";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvKFaturalar.DataSource = dt;
            connection.Close();
        }
                //
                // Kurumsal Faturalarında arayan
                //
        private void btnKFaturaArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ABONE_NO,KURUM_ADI,FATURA_IBAN,TUTAR,ODENDI_BILGISI,ODENDIGI_TARIH,ODENDIGI_SAAT FROM KURUM_FATURALARI WHERE ABONE_NO LIKE '%" + tbKFaturaArama.Text + "%' or KURUM_ADI LIKE '%" + tbKFaturaArama.Text + "%' or FATURA_IBAN LIKE '%" + tbKFaturaArama.Text + "%' or ODENDIGI_TARIH LIKE '%" + tbKFaturaArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvKFaturalar.DataSource = dt;
            connection.Close();
        }
        //
        // Çalışanlar tabı
        //
        private void btnCSifirla_Click(object sender, EventArgs e)
        {
            tbCArama.Text = "";
            sirdan();
        }
            //
            // Çalışanlara bilgi çeken
            //
        public void sirdan()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD,SOYAD,EMAIL,TELEFON_NO,MAAS,CALISAN_IBAN FROM KULLANICI_BILGILERI WHERE ID!=1";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvCalisanlar.DataSource = dt;
            connection.Close();
        } //ADMİN İ LİSTEDEN BURADA GİZLİYORUZ
                //
                // Çalışanlarda Arayan
                //
        private void btnCAra_Click(object sender, EventArgs e)
        {

            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD,SOYAD,EMAIL,TELEFON_NO,MAAS,CALISAN_IBAN FROM KULLANICI_BILGILERI WHERE ID LIKE '%" + tbCArama.Text + "%' or AD LIKE '%" + tbCArama.Text + "%' or SOYAD LIKE '%" + tbCArama.Text + "%' or EMAIL LIKE '%" + tbCArama.Text + "%' or TELEFON_NO LIKE '%" + tbCArama.Text + "%' or MAAS LIKE '%" + tbCArama.Text + "%' or CALISAN_IBAN LIKE '%" + tbCArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvCalisanlar.DataSource = dt;
            connection.Close();
        }
    }
}
