using System;
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

        int[] index = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10,
        11, 11, 12, 12, 13, 13, 14, 14 ,15, 15, 16, 16, 17, 17, 18, 18, 19, 19, 20, 20};
        int found;
        Button firstCard;
        int firstIndex;
        int movement; 

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updatedCards();
        }
        private void updatedCards()
        {
            Random random = new Random();

            for (int i = 0; i < 42; i++)
            {
                int random_number = random.Next(0, 21);
                int temp = index[i];
                index[i] = index[random_number];
                index[random_number] = temp;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }

            found = 0;
            movement = 0;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button)
                {
                    button.Visible = true;

                }
            }
            updatedCards();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
