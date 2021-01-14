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

    public partial class CalisanForm : Form
    {
        int MouseX, MouseY;
        bool MouseM;
        public CalisanForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //
            // CalışanFrom
            //
            pnlProfilCalisanNot.BackColor = Color.FromArgb(100, Color.Black);
            pnlSefProfil.BackColor = Color.FromArgb(100, Color.Black);
            lblDepoArama.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilCalisanNot.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilMAAS.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilID.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilAD.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilSOYAD.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilDOB.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilEMAIL.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilTEL.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilGOREV.BackColor = Color.FromArgb(100, Color.Black);
            lblProfilCBT.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoAramaSifirla.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoArama.BackColor = Color.FromArgb(100, Color.Black);
            btnDepoMusteriArama.BackColor = Color.FromArgb(100, Color.Black);
            mahmud();
            bora();
            suha();
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
        // Depo Tabı
        //
        private void btnDepoAramaSifirla_Click(object sender, EventArgs e)
        {
            tbDepoArama.Text = "";
            mahmud();
            bora();
        }
            //
            // Depoya Bilgi Çeken
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
        // Depoda Arama Yapan
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
        // Profile Bilgi Çeken
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
            dgvCalisanProfil.DataSource = dt;
            connection.Close();
            lblProfilID3.Text = dgvCalisanProfil.Rows[0].Cells[0].Value.ToString();
            lblProfilAD3.Text = dgvCalisanProfil.Rows[0].Cells[1].Value.ToString();
            lblProfilSOYAD3.Text = dgvCalisanProfil.Rows[0].Cells[2].Value.ToString();
            lblProfilDOB3.Text = dgvCalisanProfil.Rows[0].Cells[3].Value.ToString();
            lblProfilEMAIL3.Text = dgvCalisanProfil.Rows[0].Cells[4].Value.ToString();
            lblProfilTEL3.Text = dgvCalisanProfil.Rows[0].Cells[5].Value.ToString();
            lblProfilGOREV3.Text = dgvCalisanProfil.Rows[0].Cells[6].Value.ToString();
            lblProfilMAAS3.Text = dgvCalisanProfil.Rows[0].Cells[7].Value.ToString();
            lblProfilCBT3.Text = dgvCalisanProfil.Rows[0].Cells[8].Value.ToString();
            lblProfilCalisanNot3.Text = dgvCalisanProfil.Rows[0].Cells[9].Value.ToString();
        }
    }
}
