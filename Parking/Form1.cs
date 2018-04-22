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
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Form1()
        {
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
            }
            else
                textBox1.Focus();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.PasswordChar = Convert.ToChar("•");
            }
            else
                textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your username.", "Message", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            }
            try
            {
                dbCars2DataSetTableAdapters.UserTableAdapter user = new dbCars2DataSetTableAdapters.UserTableAdapter();
                dbCars2DataSet.UserDataTable dt = user.GetDataByUser(textBox1.Text, textBox2.Text);
                if(dt.Rows.Count > 0)
                {
                    fmDash frm = new fmDash();
                    frm._strUser = this.textBox1.Text;
                    frm.LoadInfor();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your username or password is incoeect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if (dt.Rows.Count <= 0)
            //{
            //    MessageBox.Show("Username or Password Incorrect");
            //}
            //else
            //{
            //    fmDash frm = new fmDash();
            //    frm._strUser = this.textBox1.Text;
            //    frm.LoadInfor();
            //    frm.Show();

            //    this.Hide();
            //}
            //dt.Clear();
        }
    }
}