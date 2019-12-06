using System;
using System.Windows.Forms;
using Weapon;
using Opponents;

namespace WindowsForm
{
    public partial class Fighting : Form
    {
        public static Squad[] squad;
        public static Gun[] guns;
        static PictureBox[] arr = new PictureBox[10];
        public static Label[] mas = new Label[10];
        static Random rnd = new Random();
        public static int len;
        public static int len2;
        public Fighting(Gun[] g, Squad[] a, int l, int l2)
        {
            InitializeComponent();
            guns = g;
            squad = a;
            len = l;
            len2 = l2;
            label4.Text = $"{len2} squads against you";
            arr[0] = pic1; mas[0] = label5;
            arr[1] = pic2; mas[1] = label6;
            arr[2] = pic3; mas[2] = label7;
            arr[3] = pic4; mas[3] = label8;
            arr[4] = pic5; mas[4] = label9;
            arr[5] = pic6; mas[5] = label10;
            arr[6] = pic7; mas[6] = label11;
            arr[7] = pic8; mas[7] = label12;
            arr[8] = pic9; mas[8] = label13;
            arr[9] = pic10; mas[9] = label14;
            for (int i = 0; i < (10 - len2); i++)
            {
                arr[i].Hide();
                mas[9 - i].Text = "";
            }
            int cur = 0;
            for (int i = 0; i < len2; i++)
            {
                for (int j = 0; j < a[i].Amount; j++)
                    cur += a[i][j];
                mas[i].Text = $"{cur}/{a[i].Health} hp";
                cur = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Attack()
        {
            int damage;
            if (len > 0 && len2 > 0)
            {
                int gun = rnd.Next(0, len);
                int unit = rnd.Next(0, len2);
                if (guns[gun].Patrons == 0)
                {
                    if (len > 1)
                    {
                        this.Hide();
                        Data data = new Data(guns, squad, len, len2, gun);
                        data.Show();
                    }
                    else
                    {
                        label15.Text = "You lose, man!";
                        return;
                    }
                }
                damage = guns[gun].Shoot();
                if (damage == 0)
                    label15.Text = "Shot to nowhere.Miss";
                else
                    label15.Text = "Congratulations, you shot!";
                squad[unit][squad[unit].Amount - 1] -= damage;
                if (guns[gun].GetType().ToString() == "Weapon.Machinegun")
                    ((Machinegun)guns[gun]).NumShoots++;
                if (squad[unit][squad[unit].Amount - 1] <= 0)
                    squad[unit].Amount--;
                if (squad[unit].Amount == 0)
                {
                    squad[unit] = squad[len2 - 1];
                    len2--;
                }
                if (guns[gun].GetType().ToString() == "Weapon.Machinegun")
                {
                    if (((Machinegun)guns[gun]).NumShoots % ((Machinegun)guns[gun]).LifeTime == 0)
                    {
                        if (rnd.NextDouble() < ((Machinegun)guns[gun]).Breaking)
                        {
                            guns[gun] = guns[len - 1];
                            len--;
                        }

                    }
                }
            }
            int cur = 0;
            for (int i = 0; i < len2; i++)
            {
                for (int j = 0; j < squad[i].Amount; j++)
                    cur += squad[i][j];
                mas[i].Text = $"{cur}/{squad[i].Health} hp";
                cur = 0;
            }
            for (int i = 0; i < (10 - len2); i++)
            {
                mas[9 - i].Text = "";
                arr[i].Hide();
            }
            label4.Text = $"{len2} squads against you";
            if (len == 0)
                label15.Text = "You lose, man!";
            else if (len2 == 0)
                label15.Text = "You won, man!";
        }


        private void Fighting_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void pic8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
        public static string ReLive(Gun[] guns, int index)
        {
            int ans = Check.ReadInt("Do you want to take a chance?\n1) Press 1 if  you want\n2) Press 2 if you don't want\n", 1, 2);
            if (ans == 1)
            {
                int choice = Check.ReadInt("Choose a gun number to take a chance\n", 1, len);
                while (choice - 1 == index)
                {
                    choice = Check.ReadInt("Choose a gun number to take a chance(you cannot take a gun which we have now)\n", 1, len);
                }
                if (rnd.NextDouble() < 0.5)
                {
                    guns[index].Patrons += 5;
                    return "You took a chance and restored 5 patrons";
                }
                else
                {
                    guns[index] = guns[len - 1];
                    len--;
                    guns[choice - 1] = guns[len - 1];
                    len--;
                    return "You took a chance and lost everything! Keep going";
                }

            }
            else if (ans == 2)
            {
                guns[index] = guns[len - 1];
                len--;
                return "You decided to part with your gun, it was your choice!";
            }
            return "You decided to part with your gun, it was your choice!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            len = 0;
            len2  =0;
            guns = null;
            squad = null;
            this.Hide();
            Cash cash = new Cash();
            cash.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
