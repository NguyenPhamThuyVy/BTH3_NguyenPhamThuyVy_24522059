using System;
using System.Drawing;           
using System.Windows.Forms;    
namespace BTH3_BT4
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            colordialog.AllowFullOpen = true;
            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colordialog.Color;
            }
        }
    }
}
