using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;

namespace Parking
{
    public partial class fmDash : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string strUser;
        public string _strUser
        {
            get { return strUser; }
            set { strUser = value; }
        }

        public void LoadInfor()
        {
            txtUsername.Text = strUser;
        }

        private void fmDash_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public fmDash()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(fmDash_MouseDown);
            SideP.Height = button1.Height;
            SideP.Top = button1.Top;
           // txtTime.Text = DateTime.Now.ToString();
        }

        private void fmDash_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.MouseDown += new MouseEventHandler(fmDash_MouseDown);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SideP.Height = button1.Height;
            SideP.Top = button1.Top;

            usrDashboard ctrl = new usrDashboard();
            this.panel3.Controls.Add(usrDashboard2);
            this.usrDashboard2.Show();
            this.usrRecords2.Hide();
            this.usrReports1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SideP.Height = button2.Height;
            SideP.Top = button2.Top;

            usrRecords ctrl = new usrRecords();
            this.panel3.Controls.Add(usrRecords2);
            this.usrRecords2.Show();
            this.usrDashboard2.Hide();
            this.usrReports1.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SideP.Height = button5.Height;
            SideP.Top = button5.Top;

            usrReports ctrl = new usrReports();
            this.panel3.Controls.Add(usrReports1);
            this.usrReports1.Show();
            this.usrRecords2.Hide();
            this.usrDashboard2.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString();
        }

        private void usrDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
