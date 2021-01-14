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
    public partial class SefForm : Form
    {
        int MouseX, MouseY;
        bool MouseM;
        public double miktar = 0;
        public SefForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //
            // DEPO
            //
            lblDepoArama.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoID.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoUrunADI.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoUrunTURU.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoMusteriADI.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoMusteriSOYAD.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoMusteriTEL.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoMusteriIBAN.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoBirimFiyat.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoMiktar.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoMiktarTuru.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoToplamFiyat.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoSID.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoAramaSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoArama.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoMusteriArama.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoSat.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoSifirla.BackColor = Color.FromArgb(100, Color.Black);
            tbDepoSID.Text = LogingForm.ID;//LoggingForm dan ID'yi aldık
            mahmud();
            bora();
            //
            // Üretilen Ürünler
            //
            lblUUArama.BackColor = Color.FromArgb(100, Color.Black);
            lblUUID.BackColor = Color.FromArgb(100, Color.Black);
            lblUUUrunAdi.BackColor = Color.FromArgb(100, Color.Black);
            lblUUUrunTuru.BackColor = Color.FromArgb(100, Color.Black);
            lblUUMiktar.BackColor = Color.FromArgb(100, Color.Black);
            lblUUMikltarTuru.BackColor = Color.FromArgb(100, Color.Black);
            btnUUAramaSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnUUArama.BackColor = Color.FromArgb(100, Color.Black);
            btnUUEkle.BackColor = Color.FromArgb(100, Color.Black);
            btnBUUEkleSifirla.BackColor = Color.FromArgb(100, Color.Black);
            tuncer();
            //
            // Alınan Ürünler
            //
            lblAUArama.BackColor = Color.FromArgb(100, Color.Black);
            btnAUSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnAUArama.BackColor = Color.FromArgb(100, Color.Black);
            btnYeniUrunAl.BackColor = Color.FromArgb(100, Color.Black);
            btnSUEAyniUrundenAl.BackColor = Color.FromArgb(100, Color.Black);
            ekmek();
            //
            // Satılan Ürünler
            //
            lblSAArama.BackColor = Color.FromArgb(100, Color.Black);
            btnSASifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnSAArama.BackColor = Color.FromArgb(100, Color.Black);
            reis();
            //
            // Çalışanlar
            //
            lblCalisanlarNot.BackColor = Color.FromArgb(100, Color.Black);
            berk();
            //
            // Profil
            //
            pnlSefProfil.BackColor = Color.FromArgb(100, Color.Black);
            pnlProfilSefNot.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilID.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilAD.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilSOYAD.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilDOB.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilEMAIL.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilTEL.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilGOREV.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilCBT.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilSefNot.BackColor = Color.FromArgb(100, Color.Black);
            suha();
        }
        private void SefForm_Load(object sender, EventArgs e)
        {
            
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
        // Depo Tabı
        //
        private void btnDepoAramaSifirla_Click(object sender, EventArgs e)
        {
            tbDepoArama.Text = "";
            mahmud();
            bora();
        }
        private void dgvDepo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbDepoID.Enabled = false;
                tbDepoUrunAdi.Enabled = false;
                tbDepoUrunTuru.Enabled = false;
                DataGridViewRow row = this.dgvDepo.Rows[e.RowIndex];
                miktar = double.Parse(row.Cells[3].Value.ToString());
                tbDepoID.Text = row.Cells[0].Value.ToString();
                tbDepoUrunAdi.Text = row.Cells[1].Value.ToString();
                tbDepoUrunTuru.Text = row.Cells[2].Value.ToString();
                tbDepoMiktar.Text = row.Cells[3].Value.ToString();
            }
        }
        private void tbDepoMiktar_TextChanged(object sender, EventArgs e)
        {
            if(tbDepoMiktar.Text=="")
            {

            }
            else if ((double.Parse(tbDepoMiktar.Text)) > miktar) 
            {
                tbDepoMiktar.Text = miktar.ToString();
            }
        }
        private void btnDepoSifirla_Click(object sender, EventArgs e)
        {
            tbDepoID.Enabled = true;
            tbDepoUrunAdi.Enabled = true;
            tbDepoUrunTuru.Enabled = true;
            tbDepoMusteriAdi.Enabled = true;
            tbDepoMusteriSoyadi.Enabled = true;
            tbDepoID.Text = "";
            tbDepoUrunAdi.Text = "";
            tbDepoUrunTuru.Text = "";
            tbDepoMusteriAdi.Text = "";
            tbDepoMusteriSoyadi.Text = "";
            tbDepoMusteriTel.Text = "";
            tbDepoMusteriIBAN.Text = "";
            tbDepoBirimFiyat.Text = "";
            tbDepoMiktar.Text = "";
            cbDepoMiktarTuru.SelectedIndex = -1;
            tbDepoToplamFiyat.Text = "";

        }
        private void dgvDepoIlisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbDepoMusteriAdi.Enabled = false;
                tbDepoMusteriSoyadi.Enabled = false;
                DataGridViewRow row = this.dgvDepoIlisiler.Rows[e.RowIndex];
                tbDepoMusteriAdi.Text = row.Cells[0].Value.ToString();
                tbDepoMusteriSoyadi.Text = row.Cells[1].Value.ToString();
                tbDepoMusteriIBAN.Text = row.Cells[2].Value.ToString();
                tbDepoMusteriTel.Text = row.Cells[3].Value.ToString();
            }
        }
        private void SefForm_Activated(object sender, EventArgs e)
        {
            ekmek();
        }
        //
        // Depoya bilgi çeken 
        //
        public void mahmud()
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
        public void bora()
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
                // Depoda arama yapan
                //
        private void btnDepoArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD AS ADI,TURU AS TÜR,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ FROM DEPO_TABLOSU WHERE ID LIKE '%" + tbDepoArama.Text + "%' or AD LIKE '%" + tbDepoArama.Text + "%' or TURU LIKE '%" + tbDepoArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvDepo.DataSource = dt;
            connection.Close();
        }
        private void btnDepoMusteriArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT AD AS ADI,SOYAD AS SOYADI,IBAN,TEL_NO AS TEL FROM ILISKILER_TABLOSU WHERE AD like '%" + tbDepoArama.Text + "%' or SOYAD like '%" + tbDepoArama.Text + "%' or IBAN like '%" + tbDepoArama.Text + "%' or TEL_NO like '%" + tbDepoArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvDepoIlisiler.DataSource = dt;
            connection.Close();
        }
                    //
                    // Depoda satış yapan
                    //
        private void btnDepoSat_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();

            if(tbDepoID.Text=="" || tbDepoUrunAdi.Text=="" || tbDepoUrunTuru.Text=="" || tbDepoMusteriAdi.Text=="" || tbDepoMusteriSoyadi.Text=="" || tbDepoMusteriTel.Text=="" || tbDepoMusteriIBAN.Text=="" || tbDepoBirimFiyat.Text=="" || tbDepoMiktar.Text=="" || cbDepoMiktarTuru.SelectedIndex==-1 || tbDepoToplamFiyat.Text=="")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
            else
            {
                tbDepoToplamFiyat.Text = ((double.Parse(tbDepoBirimFiyat.Text)) * (double.Parse(tbDepoMiktar.Text))).ToString();
                if (!iliski_EXIST())
                { 
                    connection.Open();
                    OracleCommand b = new OracleCommand("URUN_AL", connection);
                    b.CommandType = System.Data.CommandType.StoredProcedure;
                    b.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbDepoID.Text;
                    b.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbDepoUrunAdi.Text;
                    b.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbDepoUrunTuru.Text;
                    b.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbDepoMusteriAdi.Text;
                    b.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbDepoMusteriSoyadi.Text;
                    b.Parameters.Add("X6", OracleDbType.NVarchar2).Value = tbDepoMusteriTel.Text;
                    b.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbDepoMusteriIBAN.Text;
                    b.Parameters.Add("X8", OracleDbType.Double).Value = double.Parse(tbDepoBirimFiyat.Text);
                    b.Parameters.Add("X9", OracleDbType.Double).Value = double.Parse(tbDepoMiktar.Text);
                    b.Parameters.Add("X10", OracleDbType.NVarchar2).Value = cbDepoMiktarTuru.Text;
                    b.Parameters.Add("X11", OracleDbType.Double).Value = double.Parse(tbDepoToplamFiyat.Text);
                    b.Parameters.Add("X12", OracleDbType.NVarchar2).Value = tbDepoSID.Text;
                    b.Parameters.Add("X13", OracleDbType.NVarchar2).Value = "ILISKI_EKLE_M";
                    b.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    b.ExecuteNonQuery();
                    connection.Close();
                }  
                connection.Open();
                OracleCommand a = new OracleCommand("URUN_AL", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbDepoID.Text;
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbDepoUrunAdi.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbDepoUrunTuru.Text;
                a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbDepoMusteriAdi.Text;
                a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbDepoMusteriSoyadi.Text;
                a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = tbDepoMusteriTel.Text;
                a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbDepoMusteriIBAN.Text;
                a.Parameters.Add("X8", OracleDbType.Double).Value = double.Parse(tbDepoBirimFiyat.Text);
                a.Parameters.Add("X9", OracleDbType.Double).Value = double.Parse(tbDepoMiktar.Text);
                a.Parameters.Add("X10", OracleDbType.NVarchar2).Value = cbDepoMiktarTuru.Text;
                a.Parameters.Add("X11", OracleDbType.Double).Value = double.Parse(tbDepoToplamFiyat.Text);
                a.Parameters.Add("X12", OracleDbType.NVarchar2).Value = tbDepoSID.Text;
                a.Parameters.Add("X13", OracleDbType.NVarchar2).Value = "SAT";
                a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                a.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ürün Satma Başarılı!");
                mahmud();
                bora();
                reis();

                tbDepoID.Text = "";
                tbDepoUrunAdi.Text = "";
                tbDepoUrunTuru.Text = "";
                tbDepoMusteriAdi.Text = "";
                tbDepoMusteriSoyadi.Text = "";
                tbDepoMusteriTel.Text = "";
                tbDepoMusteriIBAN.Text = "";
                tbDepoBirimFiyat.Text = "";
                tbDepoMiktar.Text = "";
                cbDepoMiktarTuru.SelectedIndex = -1;
                tbDepoToplamFiyat.Text = "";
            }
        }
        //
        // Üretilen Ürünler Tabı
        //  
        private void btnUUAramaSifirla_Click(object sender, EventArgs e)
        {
            tbUUArama.Text = "";
            tuncer();
        }
        private void dgvUretilenUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUretilenUrunler.Rows[e.RowIndex];
                tbUUID.Text = row.Cells[0].Value.ToString();
                tbUUAd.Text = row.Cells[1].Value.ToString();
                tbUUUrunTuru.Text = row.Cells[2].Value.ToString();
                tbUUMiktar.Text = row.Cells[3].Value.ToString();
                cbUUMiktarTuru.Text = row.Cells[4].Value.ToString();
            }
        }
       
        private void btnEkleBUUSifirla_Click(object sender, EventArgs e)
        {
            tbUUID.Text = "";
            tbUUAd.Text = "";
            tbUUUrunTuru.Text = "";
            tbUUMiktar.Text = "";
            cbUUMiktarTuru.SelectedIndex = -1;
        }
        private void tbUUID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
            //
            // Üretilen Ürünlere bilgi çeken 
            //
        public void tuncer()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI AS ADI,URUN_TURU AS TÜR,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ FROM URETILEN_URUN_TABLOSU";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvUretilenUrunler.DataSource = dt;
            connection.Close();
        }
                //
                // Üretilen Ürünlerde Arama Yapan
                //
        private void btnUUArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI AS ADI,URUN_TURU AS TÜR,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ FROM URETILEN_URUN_TABLOSU WHERE URUN_ID LIKE '%" + tbUUArama.Text + "%' or URUN_ADI LIKE '%" + tbUUArama.Text + "%' or URUN_TURU LIKE '%" + tbUUArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvUretilenUrunler.DataSource = dt;
            connection.Close();
        }
                        //
                        // Ekleyen Yer
                        //
        private void btnUUEkle_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();

            if (tbUUID.Text=="" || tbUUAd.Text=="" || tbUUUrunTuru.Text=="" || tbUUMiktar.Text=="" || cbUUMiktarTuru.SelectedIndex==-1)
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
            else
            {
                if (ekle_EXIST("UPDATEABLE"))
                {
                    connection.Open();
                    OracleCommand a = new OracleCommand("URUN_EKLE", connection);
                    a.CommandType = System.Data.CommandType.StoredProcedure;
                    a.Connection = connection;
                    a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbUUID.Text;
                    a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbUUAd.Text;
                    a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbUUUrunTuru.Text;
                    a.Parameters.Add("X4", OracleDbType.Int64).Value = int.Parse(tbUUMiktar.Text);
                    a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = cbUUMiktarTuru.Text;
                    a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = "UZERINE_EKLE";
                    a.ExecuteNonQuery();
                    connection.Close();
                    tuncer();
                    MessageBox.Show("Ürün Ekleme Başarılı!");
                }
                else if (!ekle_EXIST("NONINSERTABLE"))
                {
                    connection.Open();
                    OracleCommand a = new OracleCommand("URUN_EKLE", connection);
                    a.CommandType = System.Data.CommandType.StoredProcedure;
                    a.Connection = connection;
                    a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbUUID.Text;
                    a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbUUAd.Text;
                    a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbUUUrunTuru.Text;
                    a.Parameters.Add("X4", OracleDbType.Int64).Value = int.Parse(tbUUMiktar.Text);
                    a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = cbUUMiktarTuru.Text;
                    a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = "EKLE";
                    a.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ürün Ekleme Başarılı!");
                }
                tbUUID.Text = "";
                tbUUAd.Text = "";
                tbUUUrunTuru.Text="";
                tbUUMiktar.Text = "";
                cbUUMiktarTuru.SelectedIndex = -1;
                mahmud();
                tuncer();
            }
            
        }
                            //
                            // ID ve/veya ad var mı yoku mu kontrolü
                            //
        public bool ekle_EXIST(string b)
        {
            OracleConnection connection2 = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand a = new OracleCommand("URUN_EXIST", connection2);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbUUID.Text;
            a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbUUAd.Text;
            a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = b;
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
        // Alınan Ürünler Tabı
        //
        private void btnAUSifirla_Click(object sender, EventArgs e)
        {
            tbAUArama.Text = "";
            ekmek();
        }
        private void btnYeniUrunAl_Click(object sender, EventArgs e)
        {
            SefUrunEkle SUE = new SefUrunEkle();
            SUE.ShowDialog();
            this.Show();
        }
        private void btnSUEAyniUrundenAl_Click(object sender, EventArgs e)
        {
            SefUrunEkle SefNesne = new SefUrunEkle();
            SefNesne.tbSUEID.Text = dvgAlinanUrunler.CurrentRow.Cells[0].Value.ToString();
            SefNesne.tbSUEID.Enabled = false;
            SefNesne.tbSUEUrunAdi.Text = dvgAlinanUrunler.CurrentRow.Cells[1].Value.ToString();
            SefNesne.tbSUEUrunAdi.Enabled = false;
            SefNesne.tbSUEUrunTuru.Text = dvgAlinanUrunler.CurrentRow.Cells[2].Value.ToString();
            SefNesne.tbSUEUrunTuru.Enabled = false;
            SefNesne.tbSUEToptanciAdi.Text = dvgAlinanUrunler.CurrentRow.Cells[3].Value.ToString();
            SefNesne.tbSUEToptanciSoyadi.Text = dvgAlinanUrunler.CurrentRow.Cells[4].Value.ToString();
            SefNesne.tbSUEToptanciTel.Text = dvgAlinanUrunler.CurrentRow.Cells[5].Value.ToString();
            SefNesne.tbSUEToptanciIBAN.Text = dvgAlinanUrunler.CurrentRow.Cells[6].Value.ToString();
            SefNesne.tbSUEBirimFiyat.Text = dvgAlinanUrunler.CurrentRow.Cells[7].Value.ToString();
            SefNesne.tbSUEMiktar.Text = dvgAlinanUrunler.CurrentRow.Cells[8].Value.ToString();
            SefNesne.cbSUEMiktarTuru.Text = dvgAlinanUrunler.CurrentRow.Cells[9].Value.ToString();
            SefNesne.tbSUEToplamFiyat.Text = dvgAlinanUrunler.CurrentRow.Cells[10].Value.ToString();
            SefNesne.ShowDialog();
        }
            //
            // Alınan Ürünlere bilgi çeken
            //
        public void ekmek()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI AS ÜRÜN_ADI,URUN_TURU AS TÜR,TOPTANCI_ADI AS ADI,TOPTANCI_SOYADI AS SOYADI,TOPTANCI_TEL AS TEL,TOPTANCI_IBAN AS IBAN,BIRIM_FIYAT AS BİRİM_FİYAT,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ,TOPLAM_FIYAT AS TOPLAM,ISLEMI_YAPAN_ID AS SORUMLU_ID,TARIH,SAAT FROM ALINAN_URUN_TABLOSU";
            connection.Open();
            OracleDataAdapter B = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            B.SelectCommand = command;
            B.Fill(dt);
            dvgAlinanUrunler.DataSource = dt;
            connection.Close();
        }
                //
                // Alınan Ürünlerde Arama Yapan
                //
        private void btnAUArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI AS ÜRÜN_ADI,URUN_TURU AS TÜR,TOPTANCI_ADI AS ADI,TOPTANCI_SOYADI AS SOYADI,TOPTANCI_TEL AS TEL,TOPTANCI_IBAN AS IBAN,BIRIM_FIYAT AS BİRİM_FİYAT,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ,TOPLAM_FIYAT AS TOPLAM,ISLEMI_YAPAN_ID AS SORUMLU_ID,TARIH,SAAT FROM ALINAN_URUN_TABLOSU WHERE URUN_ID LIKE '%" + tbUUArama.Text + "%' or URUN_ADI LIKE '%" + tbUUArama.Text + "%' or URUN_TURU LIKE '%" + tbUUArama.Text + "%' or TOPTANCI_ADI LIKE '%" + tbUUArama.Text + "%' or TOPTANCI_SOYADI LIKE '%" + tbUUArama.Text + "%' or TOPTANCI_TEL LIKE '%" + tbUUArama.Text + "%' or ISLEMI_YAPAN_ID LIKE '%" + tbUUArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dvgAlinanUrunler.DataSource = dt;
            connection.Close();
        }
        //
        // Satılan Ürünler Tabı
        //
        private void btnSASifirla_Click(object sender, EventArgs e)
        {
            tbSAArama.Text = "";
            reis();
        }
            //
            // Satılan Ürünlere bilgi çeken
            //
        public void reis()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI AS ÜRÜN_ADI,URUN_TURU AS TÜR,MUSTERI_ADI AS ADI,MUSTERI_SOYADI AS SOYADI,MUSTERI_TEL AS TEL,MUSTERI_IBAN AS IBAN,BIRIM_FIYAT AS BİRİM_FİYAT,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ,TOPLAM_FIYAT AS TOPLAM,ISLEMI_YAPAN_ID AS SORUMLU_ID,TARIH,SAAT FROM SATILAN_URUN_TABLOSU";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvSatilanUrunler.DataSource = dt;
            connection.Close();
        }
                //
                // Toplam Miktarı Hesaplayan
                //
        private void tbDepoToplamFiyat_Click(object sender, EventArgs e)
        {
            tbDepoToplamFiyat.Text = ((double.Parse(tbDepoBirimFiyat.Text)) * (double.Parse(tbDepoMiktar.Text))).ToString();
        }
                    //
                    // Satılan Ürünlerde Arama Yapan
                    //
        private void btnSAArama_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT URUN_ID AS ID,URUN_ADI AS ÜRÜN_ADI,URUN_TURU AS TÜR,MUSTERI_ADI AS ADI,MUSTERI_SOYADI AS SOYADI,MUSTERI_TEL AS TEL,MUSTERI_IBAN AS IBAN,BIRIM_FIYAT AS BİRİM_FİYAT,MIKTAR AS MİKTAR,MIKTAR_TURU AS TÜRÜ,TOPLAM_FIYAT AS TOPLAM,ISLEMI_YAPAN_ID AS SORUMLU_ID,TARIH,SAAT FROM SATILAN_URUN_TABLOSU WHERE URUN_ID LIKE '%" + tbSAArama.Text + "%' or URUN_ADI LIKE '%" + tbSAArama.Text + "%' or URUN_TURU LIKE '%" + tbSAArama.Text + "%' or MUSTERI_ADI LIKE '%" + tbSAArama.Text + "%' or MUSTERI_SOYADI LIKE '%" + tbSAArama.Text + "%' or MUSTERI_TEL LIKE '%" + tbSAArama.Text + "%' or ISLEMI_YAPAN_ID LIKE '%" + tbSAArama.Text + "%'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvSatilanUrunler.DataSource = dt;
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
                tbCalisanNotEkle.Text = row.Cells[6].Value.ToString();
            }
        }
        private void btnNotKaydet_Click(object sender, EventArgs e)
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
            berk();
            MessageBox.Show("Güncelleme Başarılı!");
        }
            //
            // Çalışanlara bilgi çeken
            //
        public void berk()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD AS ADI,SOYAD,EMAIL,TELEFON_NO,GOREV,CALISAN_NOTU AS NOTLAR FROM KULLANICI_BILGILERI WHERE SORUMLU_ID='" + LogingForm.ID + "'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvCalisanlar.DataSource = dt;
            connection.Close();
        }
        //
        // Profil Tabı
        //
        public void suha()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SELECT ID,AD,SOYAD,DOGUM_TARIHI,EMAIL,TELEFON_NO,GOREV,MAAS,CALISMAYA_BASLADIGI_TARIH,CALISAN_NOTU FROM KULLANICI_BILGILERI WHERE ID='" + LogingForm.ID + "'";
            connection.Open();
            OracleDataAdapter a = new OracleDataAdapter(command);
            DataTable dt = new DataTable();
            a.SelectCommand = command;
            a.Fill(dt);
            dgvSefProfil.DataSource = dt;
            connection.Close();
            lblProfilID2.Text = dgvSefProfil.Rows[0].Cells[0].Value.ToString();
            lblProfilAD2.Text = dgvSefProfil.Rows[0].Cells[1].Value.ToString();
            lblProfilSOYAD2.Text = dgvSefProfil.Rows[0].Cells[2].Value.ToString();
            lblProfilDOB2.Text = dgvSefProfil.Rows[0].Cells[3].Value.ToString();
            lblProfilEMAIL2.Text = dgvSefProfil.Rows[0].Cells[4].Value.ToString();
            lblProfilTEL2.Text = dgvSefProfil.Rows[0].Cells[5].Value.ToString();
            lblProfilGOREV2.Text = dgvSefProfil.Rows[0].Cells[6].Value.ToString();
            lblProfilMAAS2.Text = dgvSefProfil.Rows[0].Cells[7].Value.ToString();
            lblProfilCBT2.Text = dgvSefProfil.Rows[0].Cells[8].Value.ToString();
            lblProfilSefNot2.Text = dgvSefProfil.Rows[0].Cells[9].Value.ToString();
        }
        //
        // İlişki var mı yok mu ?
        //
        public bool iliski_EXIST()
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            connection.Open();
            OracleCommand a = new OracleCommand("URUN_AL", connection);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = "";
            a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = "";
            a.Parameters.Add("X3", OracleDbType.NVarchar2).Value ="";
            a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = "";
            a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = "";
            a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = tbDepoMusteriTel.Text;
            a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbDepoMusteriIBAN.Text;
            a.Parameters.Add("X8", OracleDbType.Int64).Value = 0;
            a.Parameters.Add("X9", OracleDbType.Int64).Value = 0;
            a.Parameters.Add("X10", OracleDbType.NVarchar2).Value = "";
            a.Parameters.Add("X11", OracleDbType.Int64).Value = 0;
            a.Parameters.Add("X12", OracleDbType.NVarchar2).Value = "";
            a.Parameters.Add("X13", OracleDbType.NVarchar2).Value = "ILISKI";
            a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            connection.Close();
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
                connection.Close();
                return false;
            }
        }
    }
}
