using System;
using System.Windows.Forms;
using Weapon;
using Opponents;

namespace WindowsForm
{
    public partial class Enemies : Form
    {
        static int unit;
        int squad;
        static string number = "";
        static Squad[] army;
        Gun[] guns;
        public Enemies(Gun[] guns, int squad)
        {
            InitializeComponent();
            unit = 0;
            this.squad = squad;
            this.guns = guns;
            army = new Squad[squad];
            amount.MaxLength = 2;
            textBox1.MaxLength = 3;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(amount_TextChanged);
            this.KeyUp  += new KeyEventHandler(amount_TextChanged);
            this.KeyUp += new KeyEventHandler(textBox1_TextChanged);
            this.KeyPress += new KeyPressEventHandler(textBox1_TextChanged);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void amount_TextChanged(object sender, EventArgs e)
        {

        }
        private void amount_TextChanged(object sender, KeyPressEventArgs e)
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
        private void amount_TextChanged(object sender, KeyEventArgs e)
        {
            number += amount.Text + "*";
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
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
        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            number += textBox1.Text + '*';
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int index = 0;
            int muli = 0;
            for(int i = number.Length-1;i>-1;i--)
            { 
               
                if (number[i] == '*')
                { 
                    index++;
                    muli= 0;
                }
                else
                { 
                    if (index == 2)
                        a += (int)Math.Pow(10,muli) * (number[i] - 48);
                    else if (index == 3)
                        b += (int)Math.Pow(10, muli) * (number[i] - 48);
                    muli++;
                }
                if (index == 4)
                    break;
                }
            if (((a > 10 || a < 1)) && (!(b > 200 || b < 10)))
            {
                amount.Text = null;
                textBox1.Text = null;
                label2.Text = $"Good. Bad.\nI’m the guy with the gun.But Remember \nin the unit - [1; 10] warriors,\n their total hp is [10; 200]!\n these units - is not correct!\n this hp - is not correct!";
            }
            else if ((a > 10 || a < 1))
            {
                amount.Text = null;
                label2.Text = $"Good. Bad.\nI’m the guy with the gun.But Remember \nin the unit - [1; 10] warriors,\n their total hp is [10; 200]!\n these units - is not correct!";
            }
            else if ((b > 200 || b < 10))
            {
                textBox1.Text = null;
                label2.Text = $"Good. Bad.\nI’m the guy with the gun.But Remember \nin the unit - [1; 10] warriors,\n their total hp is [10; 200]!\n this hp - is not correct!";
            }
            else
            {
                label2.Text = $"Good. Bad.\nI’m the guy with the gun.But Remember \nin the unit - [1; 10] warriors,\n their total hp is [10; 200]!,\n {unit + 1} units is ready!";
                army[unit] = new Squad(a, b);
                unit++;
                amount.Text = "";
                textBox1.Text = "";
                label3.Text = $"{unit + 1} unit features";
                if (unit == squad)
                {
                    label3.Text = "Units are ready!";
                    amount.Text = "don't write";
                    textBox1.Text = "don't write";
                    this.Hide();
                    Fighting fight = new Fighting(guns, army, guns.Length, army.Length);
                    fight.Show();
                }

            }
        }
    }
}
