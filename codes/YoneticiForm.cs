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
    public partial class YoneticiForm : Form
    {
        int MouseX, MouseY;
        bool MouseM;
        public YoneticiForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //
            // Faturalar
            //
            lblFaturaArama.BackColor = Color.FromArgb(100, Color.Black);
            btnFaturaSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnFaturaArama.BackColor = Color.FromArgb(100, Color.Black);
            yee();
            //
            // Kurumsal Faturalar
            //
            lblKFaturaArama.BackColor = Color.FromArgb(100, Color.Black);
            btnKFaturaSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnKFaturaArama.BackColor = Color.FromArgb(100, Color.Black);
            napim();
            //
            // Ürünler Ve Müşteriler
            //
            lblUrunlerVeMusteriler.BackColor = Color.FromArgb(100, Color.Black);
            btnUrunlerVeMusterilerSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnUrunlerArama.BackColor = Color.FromArgb(100, Color.Black);
            btnMusterilerArama.BackColor = Color.FromArgb(100, Color.Black);
            bilal();
            goregen();
            //
            // Çalışanlar
            //
            lblCalisanlarNot.BackColor = Color.FromArgb(100, Color.Black);
            btnNotKaydet.BackColor = Color.FromArgb(100, Color.Black);
            sibelcan();
            //
            // Eleman 
            //
            pnlAdminKayit.BackColor = Color.FromArgb(100, Color.Black);
            pnlIslem.BackColor = Color.FromArgb(100, Color.Black);
            lblKayitElemaniSecAdmin.BackColor = Color.Transparent;
            lblAdminKayitID.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminSIFRE.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitAD.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitSOYAD.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitDOB.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitEMAIL.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitTELNO.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitGOREV.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitMAAS.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitSID.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitIBAN.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminKayitCHAKKINDA.BackColor = Color.FromArgb(100, Color.Black);
            lblMesaj.BackColor = Color.FromArgb(100, Color.Black);
            lblMesaj2.BackColor = Color.FromArgb(100, Color.Black);
            lblIDIslem.BackColor = Color.FromArgb(100, Color.Black);
            btnKayitAdmin.BackColor = Color.FromArgb(100, Color.Black);
            btnElemanEklemeAdmin.BackColor = Color.FromArgb(100, Color.Black);
            btnGuncelleAdmin.BackColor = Color.FromArgb(100, Color.Black);
            btnSilAdmin.BackColor = Color.FromArgb(100, Color.Black);
            mtbSifreAdminKayit.PasswordChar = '*';
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
        // Faturalar Tabı
        //
        private void btnFaturaSifirla_Click_1(object sender, EventArgs e)
        {
            tbFaturaArama.Text = "";
            yee();
        }
            //
            // Faturalara bilgi çeken
            //
        public void yee()
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
        private void btnFaturaArama_Click_1(object sender, EventArgs e)
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
            napim();
        }
            //
            // Kurumsal Faturalara bilgi çeken
            //
        public void napim()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ABONE_NO,KURUM_ADI,FATURA_IBAN,TUTAR,ODENDI_BILGISI,ODENDIGI_TARIH,ODENDIGI_SAAT FROM KURUM_FATURALARI";
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
        // Ürünler Ve Müşteriler tabı
        //
        private void btnUrunlerVeMusterilerSifirla_Click(object sender, EventArgs e)
        {
            tbUrunlerVeMusteriler.Text = "";
            bilal();
            goregen();
        }
            //
            // Ürünler Ve Müşterilere bilgi çeken
            //
        public void bilal()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD AS ADI,TURU AS TÜR,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ FROM DEPO_TABLOSU";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvDepo.DataSource = dt;
            connection.Close();
        }
        public void goregen()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT AD AS ADI,SOYAD AS SOYADI, IBAN,TEL_NO AS TEL FROM ILISKILER_TABLOSU";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvDepoIlisiler.DataSource = dt;
            connection.Close();
        }
                //
                // Ürünler Ve Müşterilerde arama yapan
                //
        private void btnUrunlerArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD AS ADI,TURU AS TÜR,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ FROM DEPO_TABLOSU WHERE ID LIKE '%" + tbUrunlerVeMusteriler.Text + "%' or AD LIKE '%" + tbUrunlerVeMusteriler.Text + "%' or TURU LIKE '%" + tbUrunlerVeMusteriler.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvDepo.DataSource = dt;
            connection.Close();
        }
        private void btnMusterilerArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT AD AS ADI,SOYAD AS SOYADI,IBAN,TEL_NO AS TEL FROM ILISKILER_TABLOSU WHERE AD like '%" + tbUrunlerVeMusteriler.Text + "%' or SOYAD like '%" + tbUrunlerVeMusteriler.Text + "%' or IBAN like '%" + tbUrunlerVeMusteriler.Text + "%' or TEL_NO like '%" + tbUrunlerVeMusteriler.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvDepoIlisiler.DataSource = dt;
            connection.Close();
        }
        //
        // Çalışanlar Tabı
        //
        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCalisanlar.Rows[e.RowIndex];
                tbIDgizli.Text = row.Cells[0].Value.ToString();
                tbCalisanNotEkle.Text = row.Cells[7].Value.ToString();
            }
        }
        private void btnNotKaydet_Click(object sender, EventArgs e)
        {
            if (tbCalisanNotEkle.Text == "")
            {

            }
            else
            {
                OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
                OracleCommand command = new OracleCommand();
                connection.Open();
                OracleCommand a = new OracleCommand("NOT_EKLE", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Connection = connection;
                a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbIDgizli.Text;
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbCalisanNotEkle.Text;
                a.ExecuteNonQuery();
                connection.Close();
                sibelcan();
                MessageBox.Show("Güncelleme Başarılı!");
            }
            
        }
            //
            // Çalışanlara bilgi çeken
            //
        public void sibelcan()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD AS ADI,SOYAD,KULLANICI_TURU,EMAIL,TELEFON_NO,GOREV,CALISAN_NOTU AS NOTLAR FROM KULLANICI_BILGILERI WHERE KULLANICI_TURU='Çalışan' OR KULLANICI_TURU='Şef' OR KULLANICI_TURU='Muhasebe'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvCalisanlar.DataSource = dt;
            connection.Close();
        }
        //
        // Eleman tabı
        //
        private void tbElemanAdminIDKayit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            if(tbIDIslem.Text=="")
            {

            }
            else
            {
                OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
                OracleCommand command = new OracleCommand();
                connection.Open();
                OracleCommand a = new OracleCommand("KULLANICI_ID_FIND", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X", OracleDbType.Int64).Value = int.Parse(tbIDIslem.Text);
                a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo2 = new DataTable();
                adapter.Fill(tablo2);
                dgvHammut.DataSource = tablo2;
                connection.Close();

                if (tablo2.Rows.Count != 0)
                {
                    tbElemanAdminIDKayit.Text = dgvHammut.Rows[0].Cells[0].Value.ToString();
                    tbElemanAdminADKayit.Text = dgvHammut.Rows[0].Cells[1].Value.ToString();
                    tbElemanAdminSOYADKayit.Text = dgvHammut.Rows[0].Cells[2].Value.ToString();
                    cbElemanKayitTuruSecAdmin.Text = dgvHammut.Rows[0].Cells[3].Value.ToString();
                    dtElemanAdminDOBKayit.Text = dgvHammut.Rows[0].Cells[4].Value.ToString();
                    tbElemanAdminEMAILKayit.Text = dgvHammut.Rows[0].Cells[5].Value.ToString();
                    tbElemanAdminTELNOKayit.Text = dgvHammut.Rows[0].Cells[6].Value.ToString();
                    tbElemanAdminGOREVKayit.Text = dgvHammut.Rows[0].Cells[7].Value.ToString();
                    mtbSifreAdminKayit.Text = dgvHammut.Rows[0].Cells[8].Value.ToString();
                    tbElemanAdminMAASKayit.Text = dgvHammut.Rows[0].Cells[9].Value.ToString();
                    tbElemanAdminIBANKayit.Text = dgvHammut.Rows[0].Cells[10].Value.ToString();
                    tbElemanAdminSIDKayit.Text = dgvHammut.Rows[0].Cells[11].Value.ToString();
                    tbElemanAdminCHAKKINDAKayit.Text = dgvHammut.Rows[0].Cells[14].Value.ToString();
                }
                else
                    MessageBox.Show("Bu ID'ye sahip kullanıcı bulunamadı. ");
                tbIDIslem.Text = "";
            }
        }
        private void btnYazilarİSil_Click(object sender, EventArgs e)
        {
            tbElemanAdminIDKayit.Text = "";
            tbElemanAdminADKayit.Text = "";
            tbElemanAdminSOYADKayit.Text = "";
            cbElemanKayitTuruSecAdmin.SelectedIndex = -1;
            dtElemanAdminDOBKayit.Text = "";
            tbElemanAdminEMAILKayit.Text = "";
            tbElemanAdminTELNOKayit.Text = "";
            tbElemanAdminGOREVKayit.Text = "";
            mtbSifreAdminKayit.Text = "";
            tbElemanAdminMAASKayit.Text = "";
            tbElemanAdminIBANKayit.Text = "";
            tbElemanAdminSIDKayit.Text = "";
            tbElemanAdminCHAKKINDAKayit.Text = "";
        }
        //
        // Ekelme İşlemi
        //
        private void btnKayitAdmin_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            if (cbElemanKayitTuruSecAdmin.SelectedItem == null)
            {
                MessageBox.Show("Kayıt Türü Seçiniz.");
            }
            else if (tbElemanAdminIDKayit.Text == "" || tbElemanAdminADKayit.Text == "" || tbElemanAdminSOYADKayit.Text == "" || cbElemanKayitTuruSecAdmin.Text == "" || tbElemanAdminTELNOKayit.Text == "" || tbElemanAdminGOREVKayit.Text == "" || mtbSifreAdminKayit.Text == "" || tbElemanAdminSIDKayit.Text == "")
            {
                MessageBox.Show("Zorunlu Yerleri Boş Bırakmayınız!");
            }
            else
            {
                if (elemanExist())
                {
                    MessageBox.Show("Bu ID'ye Sahip Biri Vardır!");
                }
                else
                {
                    connection.Open();
                    OracleCommand a = new OracleCommand("ELEMAN_EKLE", connection);
                    a.CommandType = System.Data.CommandType.StoredProcedure;
                    a.Parameters.Add("X1", OracleDbType.Varchar2).Value = cbElemanKayitTuruSecAdmin.SelectedItem.ToString();
                    a.Parameters.Add("X2", OracleDbType.Int64).Value = int.Parse(tbElemanAdminIDKayit.Text);
                    a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = mtbSifreAdminKayit.Text;
                    a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbElemanAdminADKayit.Text;
                    a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbElemanAdminSOYADKayit.Text;
                    a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = dtElemanAdminDOBKayit.Text;
                    a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbElemanAdminEMAILKayit.Text;
                    a.Parameters.Add("X8", OracleDbType.Int64).Value = int.Parse(tbElemanAdminMAASKayit.Text);
                    a.Parameters.Add("X9", OracleDbType.NVarchar2).Value = tbElemanAdminIBANKayit.Text;
                    a.Parameters.Add("X10", OracleDbType.Int64).Value = int.Parse(tbElemanAdminSIDKayit.Text);
                    a.Parameters.Add("X11", OracleDbType.NVarchar2).Value = tbElemanAdminGOREVKayit.Text;
                    a.Parameters.Add("X12", OracleDbType.NVarchar2).Value = tbElemanAdminTELNOKayit.Text;
                    a.Parameters.Add("X13", OracleDbType.NVarchar2).Value = tbElemanAdminCHAKKINDAKayit.Text;
                    OracleDataAdapter adapter = new OracleDataAdapter();
                    adapter.SelectCommand = a;
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);
                    connection.Close();
                    tbElemanAdminIDKayit.Text = "";
                    tbElemanAdminADKayit.Text = "";
                    tbElemanAdminSOYADKayit.Text = "";
                    cbElemanKayitTuruSecAdmin.SelectedIndex = -1;
                    dtElemanAdminDOBKayit.Text = "";
                    tbElemanAdminEMAILKayit.Text = "";
                    tbElemanAdminTELNOKayit.Text = "";
                    tbElemanAdminGOREVKayit.Text = "";
                    mtbSifreAdminKayit.Text = "";
                    tbElemanAdminMAASKayit.Text = "";
                    tbElemanAdminIBANKayit.Text = "";
                    tbElemanAdminSIDKayit.Text = "";
                    tbElemanAdminCHAKKINDAKayit.Text = "";
                    MessageBox.Show("Ekleme Başarılı!");
                }
            }
        }
                //
                // Güncelleme İşlemi
                //
        private void btnGuncelleAdmin_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            if (cbElemanKayitTuruSecAdmin.SelectedItem == null)
            {
                MessageBox.Show("Güncelleme Türü Seçiniz.");
            }
            else
            {
                connection.Open();
                OracleCommand a = new OracleCommand("ELEMAN_GUNCELLE", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.Varchar2).Value = cbElemanKayitTuruSecAdmin.SelectedItem.ToString();
                a.Parameters.Add("X2", OracleDbType.Int64).Value = tbElemanAdminIDKayit.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = mtbSifreAdminKayit.Text;
                a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbElemanAdminADKayit.Text;
                a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbElemanAdminSOYADKayit.Text;
                a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = dtElemanAdminDOBKayit.Text;
                a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbElemanAdminEMAILKayit.Text;
                a.Parameters.Add("X8", OracleDbType.Int64).Value = int.Parse(tbElemanAdminMAASKayit.Text);
                a.Parameters.Add("X9", OracleDbType.NVarchar2).Value = tbElemanAdminIBANKayit.Text;
                a.Parameters.Add("X10", OracleDbType.Int64).Value = tbElemanAdminSIDKayit.Text;
                a.Parameters.Add("X11", OracleDbType.NVarchar2).Value = tbElemanAdminGOREVKayit.Text;
                a.Parameters.Add("X12", OracleDbType.Int64).Value = tbElemanAdminTELNOKayit.Text;
                a.Parameters.Add("X13", OracleDbType.NVarchar2).Value = tbElemanAdminCHAKKINDAKayit.Text;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                connection.Close();
                tbElemanAdminIDKayit.Text = "";
                tbElemanAdminADKayit.Text = "";
                tbElemanAdminSOYADKayit.Text = "";
                cbElemanKayitTuruSecAdmin.SelectedIndex = -1;
                dtElemanAdminDOBKayit.Text = "";
                tbElemanAdminEMAILKayit.Text = "";
                tbElemanAdminTELNOKayit.Text = "";
                tbElemanAdminGOREVKayit.Text = "";
                mtbSifreAdminKayit.Text = "";
                tbElemanAdminMAASKayit.Text = "";
                tbElemanAdminIBANKayit.Text = "";
                tbElemanAdminSIDKayit.Text = "";
                tbElemanAdminCHAKKINDAKayit.Text = "";
                MessageBox.Show("Güncelleme Başarılı!");
            }
        }
                    //
                    // Silme İşlemi
                    //
        private void btnSilAdmin_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            if (tbIDIslem.Text == "")
            {
                MessageBox.Show("Silmek için bir ID giriniz !");
            }
            else
            {
                if (adminExist())
                {
                    connection.Open();
                    OracleCommand a = new OracleCommand("ELEMAN_SIL", connection);
                    a.CommandType = System.Data.CommandType.StoredProcedure;
                    a.Parameters.Add("X", OracleDbType.Int64).Value = int.Parse(tbIDIslem.Text);
                    a.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Eleman Silindi.");
                }
                else
                {
                    MessageBox.Show("Bu ID ye sahip kimse bulunmamaktadır !");
                }
            }
            tbIDIslem.Text = "";
            sibelcan();
        }
        public bool adminExist()
        {
            OracleConnection connection2 = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand a = new OracleCommand("ELEMAN_EXIST", connection2);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Parameters.Add("X", OracleDbType.Int64).Value = int.Parse(tbIDIslem.Text);
            a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = a;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            int p = tablo.Rows.Count;
            if (p > 0)
            {
                return true;
            }
            else
            {
                connection2.Close();
                return false;
            }
        }
        //
        // ID var mı yoku mu kontrolü
        //
        public bool elemanExist()
        {
            OracleConnection connection2 = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand a = new OracleCommand("ELEMAN_EXIST", connection2);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Parameters.Add("X", OracleDbType.Int64).Value = int.Parse(tbElemanAdminIDKayit.Text);
            a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = a;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            int p = tablo.Rows.Count;
            if (p > 0)
            {
                return true;
            }
            else
            {
                connection2.Close();
                return false;
            }
        }
    }
}
