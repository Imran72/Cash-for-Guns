using System;
using System.Windows.Forms;
using Weapon;
using Opponents;

namespace WindowsForm
{
    public partial class Army : Form
    {
        public string weapon;
        public int squad;
        static Random rnd = new Random();
        public int NumberSquad;
        public int curSquad = 1;
        static Gun[] guns;

        public Army(string weapon)
        {
            InitializeComponent();
            this.weapon = weapon;
            Number.MaxLength = 3;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Sum_TextChanged);
            this.KeyUp += new KeyEventHandler(Sum_TextChanged);
            MasGun();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void MasGun()
        {
            guns = new Gun[weapon.Length];
            for (int i = 0; i < weapon.Length; i++)
            {
                Console.WriteLine(weapon[i]);
                if (weapon[i] == '1')
                    guns[i] = new Pistol(rnd.Next(10, 15 + 1), rnd.Next(5, 8 + 1));
                else if (weapon[i] == '2')
                    guns[i] = new AutomaticWeapon(rnd.Next(13, 18 + 1), rnd.Next(9, 14 + 1), rnd.NextDouble() * (0.3) + 0.3);
                else
                    guns[i] = new Machinegun(rnd.Next(10, 25 + 1), rnd.Next(8, 16 + 1), rnd.NextDouble() * (0.1) + 0.3, rnd.Next(2, 4 + 1), rnd.NextDouble() * (0.2) + 0.1);
            }
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
                button3.PerformClick();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check.ReadInt(1, 100, Number.Text) == -1)
            {
                Number.Text = "";
            }
            else
            {
                squad = int.Parse(Number.Text);
                Number.ReadOnly = true;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Army_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string amount = Number.Text;
            int a;
            if (!int.TryParse(amount, out a) || a < 1 || a > 10)
            {
                Number.Text = null;
                label2.Text = "Your army may\nconsist of[1; 10] units,\nso be careful in deciding" + $"\n{a} is not correct!";
            }
            else
            {
                this.Hide();
                squad = int.Parse(Number.Text);
                Enemies enemy = new Enemies(guns, squad);
                enemy.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
