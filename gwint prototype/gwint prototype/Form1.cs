using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gwint_prototype
{
    public partial class Form1 : Form
    {
        Card homa = new Card("Frame0.png", 10);
        public Form1()
        {
            InitializeComponent();
            hand.Invalidate();
        }

        private void hand_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(homa.CardImage, 0, 0, 42, 84);
        }
    }
}
