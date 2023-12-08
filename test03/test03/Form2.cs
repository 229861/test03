﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test03
{
    public partial class Form2 : Form
    {
        Image[] card = {
            Properties.Resources.apple,
            Properties.Resources.avocado,
            Properties.Resources.banana,
            Properties.Resources.blueberry,
            Properties.Resources.cherry,
            Properties.Resources.gold_kiwi,
            Properties.Resources.grape_fruit,
            Properties.Resources.grape,
            Properties.Resources.lemon,
            Properties.Resources.mandarin,
            Properties.Resources.mango,
            Properties.Resources.orange,
            Properties.Resources.oriental_melon,
            Properties.Resources.peach,
            Properties.Resources.pear,
            Properties.Resources.pineapple,
            Properties.Resources.plum,
            Properties.Resources.pomegranate,
            Properties.Resources.strawberry,
            Properties.Resources.tomato,
            Properties.Resources.watermelon,
        };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
