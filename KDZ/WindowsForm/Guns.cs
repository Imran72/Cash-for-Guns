using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
 
    public partial class Guns : Form
    {
        public int amount;
        public string weapon = "";
        public Guns(int amount)
        {
      
            InitializeComponent();
            this.amount = amount;
            cashsum.Text = this.amount + "$";
            gun1.FlatAppearance.BorderColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Army army = new Army(weapon);
            army.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gun3_Click_1(object sender, EventArgs e)
        {
            if (this.amount - 10 >= 0)
            {
                this.amount = this.amount - 10;
                weapon += "1";
            }
            cashsum.Text = this.amount + "$";
        }

        private void gun2_Click_1(object sender, EventArgs e)
        {
            if (this.amount - 15 >= 0)
            {
                this.amount = this.amount - 15;
                weapon += "2";
            }
            cashsum.Text = this.amount + "$";
        }

        private void gun1_Click(object sender, EventArgs e)
        {
            if (this.amount - 20 >= 0)
            {
                this.amount = this.amount - 20;
                weapon += "3";
            }
            cashsum.Text = this.amount + "$";
        }

        private void cashsum_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
