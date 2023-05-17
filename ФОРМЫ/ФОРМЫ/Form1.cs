using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ФОРМЫ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSayBruh_Click(object sender, EventArgs e)
        {
            labelBruh.Text = "пук";
        }

        private void buttonSayHitler_Click(object sender, EventArgs e)
        {
            labelHitler.Text = "РАБОТАЕМ РЕБЯТА";
        }

        private void buttonSayAsu_Click(object sender, EventArgs e)
        {
            labelApologize.Text = "ОСУЖДАЮ ПРЕДЫДУЩУЮ КНОПКУ";
        }

        private void buttonPuk_Click(object sender, EventArgs e)
        {
            labelPuk.Text = ">пук";
        }

    }
}
