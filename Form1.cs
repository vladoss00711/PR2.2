using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ПР_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(TbNumberOfEntries.Text, out n) || n <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректное число записей.");
                return;
            }

            Dictionary<string, List<string>> purchases = new Dictionary<string, List<string>>();

            string[] lines = InputTb.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                string[] input = line.Split(' ');
                if (input.Length != n)
                {
                    MessageBox.Show("Неверный формат записи. Используйте: 'Покупатель Товар Количество'.");
                    return;
                }
                string buyer = input[0];
                string item = input[1];
                string count = input[2];

                if (!purchases.ContainsKey(buyer))
                {
                    purchases[buyer] = new List<string>();
                }
                purchases[buyer].Add($"{item} {count}");
            }
            ResultTb.Clear();
            foreach (var buyer in purchases)
            {
                ResultTb.Text += $"{buyer.Key}:\r\n";
                foreach (var purchase in buyer.Value)
                {
                    ResultTb.Text += $"{purchase}\r\n";
                }
                ResultTb.Text += "\r\n";
            }
        }
        private void ResultTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void InputTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputTb_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(InputTb, "Введите текст по типу: " +
                "Покупатель Товар Количество");
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }

        private void CLEARBTN_Click(object sender, EventArgs e)
        {
            TbNumberOfEntries.Clear();
            InputTb.Clear();
            ResultTb.Clear();
        }

        private void CLEARBTN_MouseEnter(object sender, EventArgs e)
        {
            CLEARBTN.BackColor = Color.DarkSalmon;

        }

        private void CLEARBTN_MouseLeave(object sender, EventArgs e)
        {
            CLEARBTN.BackColor = Color.Tomato; 

        }

        private void CLEARBTN_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(CLEARBTN, "ОЧИСТКА");
        }

        private void TbNumberOfEntries_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

