using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace iReverse_Theme_Engine
{
    public partial class Main : Form
    {
        #region UI
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion
        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));
            panel_header.MouseDown += Main_MouseDown;
            label_title.MouseDown += Main_MouseDown;
        }

        public void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_set_dark_Click(object sender, EventArgs e)
        {
            ThemeEngine.ThemeSet(this, ThemeEngine.Styles.Dark);
        }

        private void button_set_light_Click(object sender, EventArgs e)
        {
            ThemeEngine.ThemeSet(this, ThemeEngine.Styles.Light);
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            label_time.Text = $"Time : {DateTime.Now:D} - {DateTime.Now:hh:mm:ss}";
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            timer_time.Stop();
            this.Close();
        }
    }
}
