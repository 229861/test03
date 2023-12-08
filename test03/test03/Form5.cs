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
    public partial class Form5 : Form
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

        public Form5()
        {
            InitializeComponent();
            updatedCards();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            tableLayoutPanel1.Enabled = true;
            for (var i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                var button = (Button)tableLayoutPanel1.Controls[i];
                button.Visible = true;
            }
            updatedCards();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button card_button = (Button)sender;

            card_button.Enabled = false;
            int ButtonNumber = int.Parse(card_button.Name.Substring(6));
            int indexNumber = index[ButtonNumber - 1];
            card_button.BackgroundImage = card[indexNumber];
            card_button.Refresh();

            if (firstCard == null)
            {
                firstCard = card_button;
                firstIndex = indexNumber;
                movement++;

            }

            else
            {
                System.Threading.Thread.Sleep(1000);
                firstCard.BackgroundImage = null;
                card_button.BackgroundImage = null;
                if (firstIndex == indexNumber)
                {
                    found++;
                    firstCard.Visible = false;
                    card_button.Visible = false;
                    if (found == 2)
                    {
                        MessageBox.Show("축하합니다!", "시행횟수 : " + movement);
                        tableLayoutPanel1.Enabled = false;
                    }

                }
                card_button.Enabled = true;
                firstCard.Enabled = true;
                firstCard = null;
            }

        }
    }
}
