using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
            Sum.MaxLength = 4;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Sum_TextChanged);
            this.KeyUp += new KeyEventHandler(Sum_TextChanged);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string amount = Sum.Text;
            int a;
            if (!int.TryParse(amount, out a) || a < 10 || a > 100)
            {
                Sum.Text = null;
                label2.Text = $"Enter money from 10 to 100!\n {a} - Error!";
            }
            else
            { 
                this.Hide();
                Guns guns = new Guns(a);
                guns.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Sum_TextChanged(object sender, EventArgs e)
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
                Button1.PerformClick();
            }

        }


    }
}
