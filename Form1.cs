using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OgrenciYoklamaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ghstBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTÝON = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTÝON, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrYoklamaPanel.Visible = true;
            ogrListPanel.Visible = false;
            ogrKayitPanel.Visible = false;
        }

        private void ogrListBtn_Click(object sender, EventArgs e)
        {
            ogrListPanel.Visible = true;
            ogrKayitPanel.Visible = false;
            ogrYoklamaPanel.Visible = false;
        }

        private void ogrSave_Click(object sender, EventArgs e)
        {
            ogrKayitPanel.Visible = true;
            ogrListPanel.Visible = false;
            ogrYoklamaPanel.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(ogrNoTxt.Text + "- " + ogrAdTxt.Text + " " + ogrSoyadTxt.Text);
            listBox4.Items.Add(ogrNoTxt.Text + "- " + ogrAdTxt.Text + " " + ogrSoyadTxt.Text);
            MessageBox.Show("Öðrenci Kayýt Edildi");
        }

        private void varBtn_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                listBox2.Items.Add(listBox4.SelectedItem);
                listBox4.Items.Remove(listBox4.SelectedItem);
            }

        }

        private void yokBtn_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                listBox3.Items.Add(listBox4.SelectedItem);
                listBox4.Items.Remove(listBox4.SelectedItem);
            }
        }
    }
}