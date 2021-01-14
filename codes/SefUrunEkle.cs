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
    public partial class SefUrunEkle : Form
    {
        int MouseX, MouseY;
        bool MouseM;
        public SefUrunEkle()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            pnlSUE.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEID.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEUrunAdi.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEUrunTuru.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEToptanciAdi.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEToptanciSoyadi.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEToptanciTel.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEToptanciIBAN.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEBirimFiyat.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEMiktar.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEMiktarTuru.BackColor = Color.FromArgb(100, Color.Black);
            lblSUEToplamFiyat.BackColor = Color.FromArgb(100, Color.Black);
            lblSUESID.BackColor = Color.FromArgb(100, Color.Black);
            btnAUAl.BackColor = Color.FromArgb(100, Color.Black);
            tbSUESID.Text = LogingForm.ID;//LoggingForm dan ID'yi aldık
        }
        //
        // Kapatma ve alta alma tuşu
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
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
        // Alma Tuşu
        //
        private void btnAUAl_Click(object sender, EventArgs e)
        {
            OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            OracleCommand command = new OracleCommand();

            if (tbSUEID.Text == "" || tbSUEUrunAdi.Text == "" || tbSUEUrunTuru.Text == "" || tbSUEToptanciAdi.Text == "" || tbSUEToptanciSoyadi.Text == "" || tbSUEToptanciTel.Text == "" || tbSUEToptanciIBAN.Text == "" || tbSUEBirimFiyat.Text == "" || tbSUEMiktar.Text == "" || cbSUEMiktarTuru.SelectedIndex == -1 || tbSUEToplamFiyat.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!");
            }
            else
            {
                tbSUEToplamFiyat.Text = ((double.Parse(tbSUEBirimFiyat.Text)) * (double.Parse(tbSUEMiktar.Text))).ToString();
                if (ekle_EXIST("UPDATEABLE"))
                {
                    connection.Open();
                    OracleCommand a = new OracleCommand("URUN_AL", connection);
                    a.CommandType = System.Data.CommandType.StoredProcedure;
                    a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSUEID.Text;
                    a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbSUEUrunAdi.Text;
                    a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbSUEUrunTuru.Text;
                    a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbSUEToptanciAdi.Text;
                    a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbSUEToptanciSoyadi.Text;
                    a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = tbSUEToptanciTel.Text;
                    a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbSUEToptanciIBAN.Text;
                    a.Parameters.Add("X8", OracleDbType.Double).Value = double.Parse(tbSUEBirimFiyat.Text);
                    a.Parameters.Add("X9", OracleDbType.Double).Value = double.Parse(tbSUEMiktar.Text);
                    a.Parameters.Add("X10", OracleDbType.NVarchar2).Value = cbSUEMiktarTuru.Text;
                    a.Parameters.Add("X11", OracleDbType.Double).Value = double.Parse(tbSUEToplamFiyat.Text);
                    a.Parameters.Add("X12", OracleDbType.NVarchar2).Value = tbSUESID.Text;
                    a.Parameters.Add("X13", OracleDbType.NVarchar2).Value = "UZERINE_EKLE";
                    a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    a.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ürün Alma Başarılı!");
                }
                else if (!ekle_EXIST("NONINSERTABLE"))
                {
                    if (!iliski_EXIST())
                    {
                        connection.Open();
                        OracleCommand b = new OracleCommand("URUN_AL", connection);
                        b.CommandType = System.Data.CommandType.StoredProcedure;
                        b.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSUEID.Text;
                        b.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbSUEUrunAdi.Text;
                        b.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbSUEUrunTuru.Text;
                        b.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbSUEToptanciAdi.Text;
                        b.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbSUEToptanciSoyadi.Text;
                        b.Parameters.Add("X6", OracleDbType.NVarchar2).Value = tbSUEToptanciTel.Text;
                        b.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbSUEToptanciIBAN.Text;
                        b.Parameters.Add("X8", OracleDbType.Double).Value = double.Parse(tbSUEBirimFiyat.Text);
                        b.Parameters.Add("X9", OracleDbType.Double).Value = double.Parse(tbSUEMiktar.Text);
                        b.Parameters.Add("X10", OracleDbType.NVarchar2).Value = cbSUEMiktarTuru.Text;
                        b.Parameters.Add("X11", OracleDbType.Double).Value = double.Parse(tbSUEToplamFiyat.Text);
                        b.Parameters.Add("X12", OracleDbType.NVarchar2).Value = tbSUESID.Text;
                        b.Parameters.Add("X13", OracleDbType.NVarchar2).Value = "ILISKI_EKLE";
                        b.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                        b.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Ürün Alma Başarılı!");
                    }
                    connection.Open();
                    OracleCommand a = new OracleCommand("URUN_AL", connection);
                    a.CommandType = System.Data.CommandType.StoredProcedure;
                    a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSUEID.Text;
                    a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbSUEUrunAdi.Text;
                    a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbSUEUrunTuru.Text;
                    a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbSUEToptanciAdi.Text;
                    a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbSUEToptanciSoyadi.Text;
                    a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = tbSUEToptanciTel.Text;
                    a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbSUEToptanciIBAN.Text;
                    a.Parameters.Add("X8", OracleDbType.Double).Value = double.Parse(tbSUEBirimFiyat.Text);
                    a.Parameters.Add("X9", OracleDbType.Double).Value = double.Parse(tbSUEMiktar.Text);
                    a.Parameters.Add("X10", OracleDbType.NVarchar2).Value = cbSUEMiktarTuru.Text;
                    a.Parameters.Add("X11", OracleDbType.Double).Value = double.Parse(tbSUEToplamFiyat.Text);
                    a.Parameters.Add("X12", OracleDbType.NVarchar2).Value = tbSUESID.Text;
                    a.Parameters.Add("X13", OracleDbType.NVarchar2).Value = "EKLE";
                    a.Parameters.Add("F1", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    a.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ürün Alma Başarılı!");
                }
                tbSUEID.Text = "";
                tbSUEUrunAdi.Text = "";
                tbSUEUrunTuru.Text = "";
                tbSUEToptanciAdi.Text = "";
                tbSUEToptanciSoyadi.Text = "";
                tbSUEToptanciTel.Text = "";
                tbSUEToptanciIBAN.Text = "";
                tbSUEBirimFiyat.Text = "";
                tbSUEMiktar.Text = "";
                cbSUEMiktarTuru.SelectedIndex = -1;
                tbSUEToplamFiyat.Text = "";
            }
        }
        // Miktar Hesaplayan
        private void tbSUEToplamFiyat_Click(object sender, EventArgs e)
        {
            tbSUEToplamFiyat.Text= ((double.Parse(tbSUEBirimFiyat.Text)) * (double.Parse(tbSUEMiktar.Text))).ToString();
        }
        //
        // İlişki var mı yokmu kontrolü
        //
        public bool iliski_EXIST()
        {
                OracleConnection connection = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
                connection.Open();
                OracleCommand a = new OracleCommand("URUN_AL", connection);
                a.CommandType = System.Data.CommandType.StoredProcedure;
                a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSUEID.Text;
                a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbSUEUrunAdi.Text;
                a.Parameters.Add("X3", OracleDbType.NVarchar2).Value = tbSUEUrunTuru.Text;
                a.Parameters.Add("X4", OracleDbType.NVarchar2).Value = tbSUEToptanciAdi.Text;
                a.Parameters.Add("X5", OracleDbType.NVarchar2).Value = tbSUEToptanciSoyadi.Text;
                a.Parameters.Add("X6", OracleDbType.NVarchar2).Value = tbSUEToptanciTel.Text;
                a.Parameters.Add("X7", OracleDbType.NVarchar2).Value = tbSUEToptanciIBAN.Text;
                a.Parameters.Add("X8", OracleDbType.Double).Value = double.Parse(tbSUEBirimFiyat.Text);
                a.Parameters.Add("X9", OracleDbType.Double).Value = double.Parse(tbSUEMiktar.Text);
                a.Parameters.Add("X10", OracleDbType.NVarchar2).Value = cbSUEMiktarTuru.Text;
                a.Parameters.Add("X11", OracleDbType.Double).Value = double.Parse(tbSUEToplamFiyat.Text);
                a.Parameters.Add("X12", OracleDbType.NVarchar2).Value = tbSUESID.Text;
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
        //
        // ID ve/veya ad var mı yoku mu kontrolü
        //
        public bool ekle_EXIST(string b)
        {
            OracleConnection connection2 = new OracleConnection("User Id=SYSTEM;Password=H1a3S59H1a3S59;Data Source=localhost:1521/XEPDB1;");
            connection2.Open();
            OracleCommand a = new OracleCommand("URUN_EXIST", connection2);
            a.CommandType = System.Data.CommandType.StoredProcedure;
            a.Parameters.Add("X1", OracleDbType.NVarchar2).Value = tbSUEID.Text;
            a.Parameters.Add("X2", OracleDbType.NVarchar2).Value = tbSUEUrunAdi.Text;
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
    }
}
