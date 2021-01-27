using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();



        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown_1(sender, e);
        }


        private void RUN_BTN_Click(object sender, EventArgs e)
        {
            switch (RUN_BTN.Text)
            {
                case "開始":
                    RUN_BTN.Text = "停止";
                    timer1.Start();
                    break;
                case "停止":
                    RUN_BTN.Text = "開始";
                    timer1.Stop();
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int ts = Convert.ToInt32(H_BOX.Text) * 60 * 60 + Convert.ToInt32(M_BOX.Text) * 60 + Convert.ToInt32(S_BOX.Text);
            ts -= 1;
            if (ts <= 0)
            {
                timer1.Stop();
                RUN_BTN.Text = "開始";
                return;
            }
            TimeSpan t = TimeSpan.FromSeconds(ts);
            H_BOX.Text = string.Format("{0:D2}", t.Hours);
            M_BOX.Text = string.Format("{0:D2}", t.Minutes);
            S_BOX.Text = string.Format("{0:D2}", t.Seconds);
        }

        private void H_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void M_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void S_BOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void H_BOX_Leave(object sender, EventArgs e)
        {
            H_BOX.Text = H_BOX.Text.PadLeft(2, '0');
        }

        private void M_BOX_Leave(object sender, EventArgs e)
        {
            M_BOX.Text = M_BOX.Text.PadLeft(2, '0');
        }

        private void S_BOX_Leave(object sender, EventArgs e)
        {
            S_BOX.Text = S_BOX.Text.PadLeft(2, '0');
        }

        private void S_BOX_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown_1(sender, e);
        }

        private void RUN_BTN_MouseDown(object sender, MouseEventArgs e)
        {
            //Form1_MouseDown_1(sender, e);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown_1(sender, e);
        }

        private void M_BOX_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown_1(sender, e);
        }

        private void H_BOX_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown_1(sender, e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown_1(sender, e);
        }


        private void X_BTN_MouseDown(object sender, MouseEventArgs e)
        {
           // Form1_MouseDown_1(sender, e);
        }
        private void X_BTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
