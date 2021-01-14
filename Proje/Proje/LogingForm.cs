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
{ public partial class LogingForm : Form
    {
        int MouseX, MouseY;
        bool MouseM;
        public static string ID = "";//SefUrunEkle ve SefForma ve CalisanForm a ID yi Gönderdik
        public LogingForm()
        {
            InitializeComponent();    
            this.BackColor = Color.White;
            //
            // Ana Menü
            //
            pnlGiris.BackColor = Color.FromArgb(100, Color.Black);
            lblGirisTuruSec.BackColor = Color.Transparent;
            lblGiris.BackColor = Color.Transparent;
            lblSifre.BackColor = Color.Transparent;
            //
            // Admin Menü
            //
            pnlAdminToAnaMenBackG.BackColor=Color.FromArgb(100, Color.Black);
            btnAdminToAnaMenu.BackColor = Color.FromArgb(100, Color.Black);

            //
            // Eleman Ekleme
            //
            pnlAdminKayit.BackColor = Color.FromArgb(100, Color.Black);
            lblKayitElemaniSecAdmin.BackColor = Color.Transparent;
            lblAdminKayitID.BackColor = Color.Transparent;
            lblAdminSIFRE.BackColor = Color.Transparent;
            lblAdminKayitAD.BackColor = Color.Transparent;
            lblAdminKayitSOYAD.BackColor = Color.Transparent;
            lblAdminKayitDOB.BackColor = Color.Transparent;
            lblAdminKayitEMAIL.BackColor = Color.Transparent;
            lblAdminKayitTELNO.BackColor = Color.Transparent;
            lblAdminKayitGOREV.BackColor = Color.Transparent;
            lblAdminKayitMAAS.BackColor = Color.Transparent;
            lblAdminKayitSID.BackColor = Color.Transparent;
            lblAdminKayitIBAN.BackColor = Color.Transparent;
            lblAdminKayitCHAKKINDA.BackColor = Color.Transparent;
            btnElemanEklemeAdmin.BackColor = Color.FromArgb(100, Color.Black);
            mtbSifreAdminKayit.PasswordChar = '*';
                //
                // Eleman Guncelleme
                //
            pnlAdminGuncelle.BackColor = Color.FromArgb(100, Color.Black);
            lblKayitElemaniSecAdminGuncelle.BackColor = Color.Transparent;
            lblAdminKayitIDGuncelle.BackColor = Color.Transparent;
            lblAdminSIFREGuncelle.BackColor = Color.Transparent;
            lblAdminKayitADGuncelle.BackColor = Color.Transparent;
            lblAdminKayitSOYADGuncelle.BackColor = Color.Transparent;
            lblAdminKayitDOBGuncelle.BackColor = Color.Transparent;
            lblAdminKayitEMAILGuncelle.BackColor = Color.Transparent;
            lblAdminKayitTELNOGuncelle.BackColor = Color.Transparent;
            lblAdminKayitGOREVGuncelle.BackColor = Color.Transparent;
            lblAdminKayitMAASGuncelle.BackColor = Color.Transparent;
            lblAdminKayitSIDGuncelle.BackColor = Color.Transparent;
            lblAdminKayitIBANGuncelle.BackColor = Color.Transparent;
            lblAdminKayitCHAKKINDAGuncelle.BackColor = Color.Transparent;
                //
                // Eleman Silme
                //
            pnlAdminSil.BackColor = Color.FromArgb(100, Color.Black);
            lblAdminIDSil.BackColor = Color.Transparent;
        }
        //
        // Kapatma ve alta alma tuşu
        //
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        //
        // Üst kenar hareket paneli
        //
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
        // Ana Menü
        //
        private void tbKullaniciID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void lblTarih_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            lblTarih.Text = DateTime.Now.ToLongDateString();
        }
        private void lblSaat_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
            //
            // Girişte Database ile bağanıp kullanıcı bilgilerini kontrol eden yer.
            //
        private void btnGiris_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            if (cbGırısTuruSec.SelectedItem==null)
            {
                MessageBox.Show("Giriş Türü Seçiniz.");
            }
            else if (cbGırısTuruSec.SelectedItem.ToString() =="Admin")  // Admin GİRİŞ
            {
            connection.Open();
            OracleCommand a = new OracleCommand("ADMING", connection);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Parameters.Add("X1", OracleDbType.Int64).Value = int.Parse(tbKullaniciID.Text);
            a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = mtbSifre.Text;
            a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = cbGırısTuruSec.SelectedItem.ToString();
            a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = a;
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            int p = tablo.Rows.Count;

            if (p > 0)
            {
                pnlGiris.Visible = false;
                lblTarih.Visible = false;
                lblSaat.Visible = false;
                pnlAdmin.Visible = true;
            }
            else
                MessageBox.Show(" ID, Şifre veya Kullanıcı Türü Hatalı !  ");

            connection.Close();
            cbGırısTuruSec.SelectedIndex = -1;
            tbKullaniciID.Text = "";
            mtbSifre.Text = "";
            }// Admin GİRİŞ
            else if (cbGırısTuruSec.SelectedItem.ToString() == "Şef")  // Şef GİRİŞ
            {
                connection.Open();
                OracleCommand a = new OracleCommand("ADMING", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.Int64).Value = int.Parse(tbKullaniciID.Text);
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = mtbSifre.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = cbGırısTuruSec.SelectedItem.ToString();
                a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                int p = tablo.Rows.Count;

                if (p > 0)
                {
                    ID = tbKullaniciID.Text; //SefUrunEkleye ID yi Gönderdik
                    SefUrunEkle SUE = new SefUrunEkle(); //SefUrunEkleye ID yi Gönderdik
                    SefForm sf = new SefForm(); //SefForma ID'yi Gönderdik
                    SefForm nextForm = new SefForm();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show(" ID, Şifre veya Kullanıcı Türü Hatalı !  ");
                connection.Close();
                cbGırısTuruSec.SelectedIndex = -1;
                tbKullaniciID.Text = "";
                mtbSifre.Text = "";
            }// Şef GİRİŞ
            else if (cbGırısTuruSec.SelectedItem.ToString() == "Çalışan")  // Çalışan GİRİŞ
            {
                connection.Open();
                OracleCommand a = new OracleCommand("ADMING", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.Int64).Value = int.Parse(tbKullaniciID.Text);
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = mtbSifre.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = cbGırısTuruSec.SelectedItem.ToString();
                a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                int p = tablo.Rows.Count;

                if (p > 0)
                {
                    ID = tbKullaniciID.Text;
                    CalisanForm nextForm2 = new CalisanForm();
                    this.Hide();
                    nextForm2.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show(" ID, Şifre veya Kullanıcı Türü Hatalı !  ");

                connection.Close();
                cbGırısTuruSec.SelectedIndex = -1;
                tbKullaniciID.Text = "";
                mtbSifre.Text = "";
            }// Çalışan GİRİŞ
            else if (cbGırısTuruSec.SelectedItem.ToString() == "Muhasebe")  // Muhasebe GİRİŞ
            {
                connection.Open();
                OracleCommand a = new OracleCommand("ADMING", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.Int64).Value = int.Parse(tbKullaniciID.Text);
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = mtbSifre.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = cbGırısTuruSec.SelectedItem.ToString();
                a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                int p = tablo.Rows.Count;

                if (p > 0)
                {
                    MuhasebeForm nextForm = new MuhasebeForm();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show(" ID, Şifre veya Kullanıcı Türü Hatalı !  ");
                connection.Close();
                cbGırısTuruSec.SelectedIndex = -1;
                tbKullaniciID.Text = "";
                mtbSifre.Text = "";
            }// Muhasebe GİRİŞ
            else if (cbGırısTuruSec.SelectedItem.ToString() == "Yönetici")  // Yönetici GİRİŞ
            {
                connection.Open();
                OracleCommand a = new OracleCommand("ADMING", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.Int64).Value = int.Parse(tbKullaniciID.Text);
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = mtbSifre.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = cbGırısTuruSec.SelectedItem.ToString();
                a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                int p = tablo.Rows.Count;

                if (p > 0)
                {
                    YoneticiForm nextForm = new YoneticiForm();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show(" ID, Şifre veya Kullanıcı Türü Hatalı !  ");
                connection.Close();
                cbGırısTuruSec.SelectedIndex = -1;
                tbKullaniciID.Text = "";
                mtbSifre.Text = "";
            }
            else
                MessageBox.Show(" ID, Şifre veya Kullanıcı Türü Hatalı !  ");
            cbGırısTuruSec.SelectedIndex = -1;
            tbKullaniciID.Text = "";
            mtbSifre.Text = "";
        }
        //
        // Admin Menü
        //
        private void btnAdminToAnaMenu_Click(object sender, EventArgs e)
        {
            pnlGiris.Visible = true;
            lblTarih.Visible = true;
            lblSaat.Visible = true;
            pnlAdmin.Visible = false;
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
            // Eleman Ekleme Menüsü
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
        private void btnElemanEklemeAdmin_Click(object sender, EventArgs e)
        {
            pnlAdminKayit.Visible = true;
            pnlAdminGuncelle.Visible = false;
            pnlAdminSil.Visible = false;
            btnElemanEklemeAdmin.BackColor = Color.FromArgb(100, Color.Black);
            btnElemanGuncellemeAdmin.BackColor = Color.Transparent;
            btnElemanSilAdmin.BackColor = Color.Transparent;
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
                // Ekleme İşlemi
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
        // Eleman Guncelleme Menüsü
        //
        private void tbElemanAdminIDKayitGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            
        }
        private void btnElemanGuncellemeAdmin_Click(object sender, EventArgs e)
        {
            pnlAdminKayit.Visible = false;
            pnlAdminGuncelle.Visible = true;
            pnlAdminSil.Visible = false;
            btnElemanGuncellemeAdmin.BackColor = Color.FromArgb(100, Color.Black);
            btnElemanEklemeAdmin.BackColor = Color.Transparent;
            btnElemanSilAdmin.BackColor = Color.Transparent;
            tbElemanAdminIDKayitGuncelle.Text = "";
            tbElemanAdminADKayitGuncelle.Text = "";
            tbElemanAdminSOYADKayitGuncelle.Text = "";
            cbElemanGuncelleTuruSecAdmin.SelectedIndex = -1;
            dtElemanAdminDOBKayitGuncelle.Text = "";
            tbElemanAdminEMAILKayitGuncelle.Text = "";
            tbElemanAdminTELNOKayitGuncelle.Text = "";
            tbElemanAdminGOREVKayitGuncelle.Text = "";
            mtbSifreAdminKayitGuncelle.Text = "";
            tbElemanAdminMAASKayitGuncelle.Text = "";
            tbElemanAdminIBANKayitGuncelle.Text = "";
            tbElemanAdminSIDKayitGuncelle.Text = "";
            tbElemanAdminCHAKKINDAKayitGuncelle.Text = "";
        }
            //
            // Güncelleme İşlemi
            //
        private void btnGuncelleAdmin_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            if (cbElemanGuncelleTuruSecAdmin.SelectedItem == null)
            {
                MessageBox.Show("Güncelleme Türü Seçiniz.");
            }
            else
            {
                connection.Open();
                OracleCommand a = new OracleCommand("ELEMAN_GUNCELLE", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.Varchar2).Value = cbElemanGuncelleTuruSecAdmin.SelectedItem.ToString();
                a.Parameters.Add("X2", OracleDbType.Int64).Value = tbElemanAdminIDKayitGuncelle.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = mtbSifreAdminKayitGuncelle.Text;
                a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbElemanAdminADKayitGuncelle.Text;
                a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbElemanAdminSOYADKayitGuncelle.Text;               
                a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = dtElemanAdminDOBKayitGuncelle.Text;
                a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbElemanAdminEMAILKayitGuncelle.Text;
                a.Parameters.Add("X8", OracleDbType.Int64).Value = int.Parse(tbElemanAdminMAASKayitGuncelle.Text);
                a.Parameters.Add("X9", OracleDbType.NVarchar2).Value = tbElemanAdminIBANKayitGuncelle.Text;
                a.Parameters.Add("X10", OracleDbType.Int64).Value = tbElemanAdminSIDKayitGuncelle.Text;
                a.Parameters.Add("X11", OracleDbType.NVarchar2).Value = tbElemanAdminGOREVKayitGuncelle.Text;
                a.Parameters.Add("X12", OracleDbType.Int64).Value = tbElemanAdminTELNOKayitGuncelle.Text;
                a.Parameters.Add("X13", OracleDbType.NVarchar2).Value = tbElemanAdminCHAKKINDAKayitGuncelle.Text;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo = new DataTable();
                adapter.Fill(tablo);
                connection.Close();
                tbElemanAdminIDKayitGuncelle.Text = "";
                tbElemanAdminADKayitGuncelle.Text = "";
                tbElemanAdminSOYADKayitGuncelle.Text = "";
                cbElemanGuncelleTuruSecAdmin.SelectedIndex = -1;
                dtElemanAdminDOBKayitGuncelle.Text = "";
                tbElemanAdminEMAILKayitGuncelle.Text = "";
                tbElemanAdminTELNOKayitGuncelle.Text = "";
                tbElemanAdminGOREVKayitGuncelle.Text = "";
                mtbSifreAdminKayitGuncelle.Text = "";
                tbElemanAdminMAASKayitGuncelle.Text = "";
                tbElemanAdminIBANKayitGuncelle.Text = "";
                tbElemanAdminSIDKayitGuncelle.Text = "";
                tbElemanAdminCHAKKINDAKayitGuncelle.Text = "";
            }
        }
                //
                // Günceleme ID yerine ıd yazılıp enter a basılırsa kullanıcıların diğer bilgilerini çekiyor 
                //
        private void tbElemanAdminIDKayitGuncelle_KeyDown(object sender, KeyEventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            if (e.KeyCode == Keys.Enter)
            {
                connection.Open();
                OracleCommand a = new OracleCommand("KULLANICI_ID_FIND", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X", OracleDbType.Int64).Value = int.Parse(tbElemanAdminIDKayitGuncelle.Text);
                a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = a;
                DataTable tablo2 = new DataTable();
                adapter.Fill(tablo2);
                dgvHammut.DataSource = tablo2;
                connection.Close();

                if (tablo2.Rows.Count != 0)
                {
                    tbElemanAdminADKayitGuncelle.Text = dgvHammut.Rows[0].Cells[1].Value.ToString();
                    tbElemanAdminSOYADKayitGuncelle.Text = dgvHammut.Rows[0].Cells[2].Value.ToString();
                    cbElemanGuncelleTuruSecAdmin.Text = dgvHammut.Rows[0].Cells[3].Value.ToString();
                    dtElemanAdminDOBKayitGuncelle.Text = dgvHammut.Rows[0].Cells[4].Value.ToString();
                    tbElemanAdminEMAILKayitGuncelle.Text = dgvHammut.Rows[0].Cells[5].Value.ToString();
                    tbElemanAdminTELNOKayitGuncelle.Text = dgvHammut.Rows[0].Cells[6].Value.ToString();
                    tbElemanAdminGOREVKayitGuncelle.Text = dgvHammut.Rows[0].Cells[7].Value.ToString();
                    mtbSifreAdminKayitGuncelle.Text = dgvHammut.Rows[0].Cells[8].Value.ToString();
                    tbElemanAdminMAASKayitGuncelle.Text = dgvHammut.Rows[0].Cells[9].Value.ToString();
                    tbElemanAdminIBANKayitGuncelle.Text = dgvHammut.Rows[0].Cells[10].Value.ToString();
                    tbElemanAdminSIDKayitGuncelle.Text = dgvHammut.Rows[0].Cells[11].Value.ToString(); 
                    tbElemanAdminCHAKKINDAKayitGuncelle.Text = dgvHammut.Rows[0].Cells[14].Value.ToString();
                }
                else
                    MessageBox.Show("Bu ID'ye sahip kullanıcı bulunamadı. ");
                e.Handled = true;
            }
        }
        //
        // Eleman Silme Menüsü
        //
        private void btnElemanSilAdmin_Click(object sender, EventArgs e)
        {
            pnlAdminKayit.Visible = false;
            pnlAdminGuncelle.Visible = false;
            pnlAdminSil.Visible = true;
            btnElemanSilAdmin.BackColor = Color.FromArgb(100, Color.Black);
            btnElemanGuncellemeAdmin.BackColor = Color.Transparent;
            btnElemanEklemeAdmin.BackColor = Color.Transparent;
        }
        private void chkbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbSifreGoster.Checked)
            {
                mtbSifre.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Şifreyi Gizle";
            }
            else
            {
                mtbSifre.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Şifreyi Göster";
            }
        }
            //
            // Silme İşlemi
            //
        private void btnSilAdmin_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            if (tbElemanAdminSil.Text == "")
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
                    a.Parameters.Add("X", OracleDbType.Int64).Value = int.Parse(tbElemanAdminSil.Text);
                    a.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Eleman Silindi.");
                }
                else
                {
                    MessageBox.Show("Bu ID ye sahip kimse bulunmamaktadır !");
                }
            }
            tbElemanAdminSil.Text = "";
        }
                //
                // ID var mı yoku mu kontrolü
                //
        public bool adminExist()
        {
            OracleConnection connection2 = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand a = new OracleCommand("ELEMAN_EXIST", connection2);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Parameters.Add("X", OracleDbType.Int64).Value = int.Parse(tbElemanAdminSil.Text);
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
