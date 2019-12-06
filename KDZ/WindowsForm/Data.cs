using System;
using System.Windows.Forms;
using Weapon;
using Opponents;

namespace WindowsForm
{
    public partial class Data : Form
    {
        public static Gun[] guns;
        public static Squad[] squad;
        public static int len;
        public static int len2;
        public static int index;
        public static Random rnd = new Random();
        public Data(Gun[] g, Squad[] s, int len1, int len3, int ind)
        {
            InitializeComponent();
            guns = g;
            squad = s;
            len = len1;
            len2 = len3;
            index = ind;
            label2.Text = $"[1;{len}] without {index + 1}";
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(textBox1_TextChanged);
            this.KeyUp += new KeyEventHandler(textBox1_TextChanged);
            textBox1.MaxLength = 2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            guns[index] = guns[len - 1];
            len--;
            this.Hide();
            Fighting fight = new Fighting(guns, squad, len,len2);
            fight.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int choice = int.Parse(textBox1.Text);
            while (choice - 1 == index)
            {
               textBox1.Text = "";
               choice = int.Parse(textBox1.Text);
            }
            if (rnd.NextDouble() < 0.5)
                guns[index].Patrons += 5;
            else
            {
                guns[choice - 1] = guns[len - 1];
                len--;
            }
            this.Hide();
            Fighting fight = new Fighting(guns, squad, len, len2);
            fight.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Sum_TextChanged(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Sum_TextChanged(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }

        }
    }
}
