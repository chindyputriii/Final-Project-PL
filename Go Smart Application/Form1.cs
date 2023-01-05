using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Go_Smart_Application
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNavi.Height = btnHome.Height;
            pnlNavi.Top = btnHome.Top;
            pnlNavi.Left = btnHome.Left;
            btnHome.BackColor = Color.SlateGray;

            lblTitle.Text = "Dashboard";
            this.pnlFormLeader.Controls.Clear();
            frmHome frmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLeader.Controls.Add(frmHome_Vrb);
            frmHome_Vrb.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnHome.Height;
            pnlNavi.Top = btnHome.Top;
            pnlNavi.Left = btnHome.Left;
            btnHome.BackColor = Color.SlateGray;

            lblTitle.Text = "Dashboard";
            this.pnlFormLeader.Controls.Clear();
            frmHome frmHome_Vrb = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHome_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLeader.Controls.Add(frmHome_Vrb);
            frmHome_Vrb.Show();
        }

        private void btnKelasku_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnKelasku.Height;
            pnlNavi.Top = btnKelasku.Top;
            btnKelasku.BackColor = Color.SlateGray;

            lblTitle.Text = "Kelasku";
            this.pnlFormLeader.Controls.Clear();
            FormKelasku FormKelasku_Vrb = new FormKelasku() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormKelasku_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLeader.Controls.Add(FormKelasku_Vrb);
            FormKelasku_Vrb.Show();
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnJadwal.Height;
            pnlNavi.Top = btnJadwal.Top;
            btnJadwal.BackColor = Color.SlateGray;

            lblTitle.Text = "Jadwal";
            this.pnlFormLeader.Controls.Clear();
            FrmJadwal FrmJadwal_Vrb = new FrmJadwal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmJadwal_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLeader.Controls.Add(FrmJadwal_Vrb);
            FrmJadwal_Vrb.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNavi.Height = btnSettings.Height;
            pnlNavi.Top = btnSettings.Top;
            btnSettings.BackColor = Color.SlateGray;

            lblTitle.Text = "Settings";
            this.pnlFormLeader.Controls.Clear();
            FrmSettings FrmSettings_Vrb = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSettings_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLeader.Controls.Add(FrmSettings_Vrb);
            FrmSettings_Vrb.Show();
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.MediumBlue;
        }

        private void btnKelasku_Leave(object sender, EventArgs e)
        {
            btnKelasku.BackColor = Color.MediumBlue;
        }

        private void btnJadwal_Leave(object sender, EventArgs e)
        {
            btnJadwal.BackColor = Color.MediumBlue;
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.MediumBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlFormLeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}