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

        private void çàêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}