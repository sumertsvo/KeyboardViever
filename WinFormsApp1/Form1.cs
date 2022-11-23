using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WinFormsApp1
{

    
    public partial class Form1 : Form
    {
        Form2 newForm;
        protected override bool ShowWithoutActivation => true;
        private const int WS_EX_TOPMOST = 0x00000008;
        private const int WS_EX_TRANSPARENT = 0x00000020;
        private const int WS_EX_LAYERED = 0x00080000;
      
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TOPMOST + WS_EX_TRANSPARENT + WS_EX_LAYERED;
                return createParams;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       /*
            Location = new Point(Properties.Settings.Default.X, Properties.Settings.Default.Y);
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            Opacity = Properties.Settings.Default.Opacity;
      */
            TopMost = true;
            Enabled = false;
            newForm = new Form2();
            newForm.Owner = this;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            newForm.Show();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (var pict in this.Controls.OfType<PictureBox>())
            {
                if (pict.Name == Convert.ToString(e.KeyCode))
                {
                    pict.Visible = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var pict in this.Controls.OfType<PictureBox>() ) 
            {
                pict.Visible =false;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Shift_Click(object sender, EventArgs e)
        {

        }
    }
}