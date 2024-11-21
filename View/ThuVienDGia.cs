using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPTPMHDT.View
{
    public partial class ThuVienDGia : Form
    {
        public ThuVienDGia()
        {
            InitializeComponent();
            panel1.Height = 800; // Chiều cao của nội dung
            SB.Maximum = panel1.Height - this.ClientSize.Height;
            SB.Scroll += new ScrollEventHandler(SB_Scroll);
            SB.LargeChange = this.ClientSize.Height / 10;
        }

        private void SB_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Top = -SB.Value;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SB.Maximum = panel1.Height - this.ClientSize.Height;
        }
    }
}