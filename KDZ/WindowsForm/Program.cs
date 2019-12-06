using System;
using System.Windows.Forms;
using Weapon;
using Opponents;

namespace WindowsForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>10б
        public static Random rnd = new Random();
        public static int len1; // количество пушек
        public static int len2; // количество отрядов
        public static Gun[] guns; //массив пушек
        public static Squad[] squad; //массив отрядов
        [STAThread]
        /// Пункт управления
        ///  Здесь мы запрашиваем у пользователя все необходимые данные чтобы купить оружие
        /// , составит вражеский союз
        /// после чего мирно отправить на борьбу наши пушки и не наши отряды
        static void Main()
        {
            int a = Check.ReadInt("Нажмите:\n1) - Провести игру в консоли\n2) - Провести игру в форме\n", 1, 2);
            if (a == 1)
            {
                do
                {
                    Console.Clear();
                    int money = Check.ReadInt("Enter money from 10 to 100 just in numbers, sir!\n", 10, 100);
                    Console.Clear();
                    Weapon(money);
                    Console.Clear();
                    int units = Check.ReadInt("Decide how many units you want, but remember[1; 10]\n", 1, 10);
                    Army(units);
                    War();
                    Console.WriteLine("To exit, press escape, to play again - any key");
                }
                while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            else if (a == 2) //запуск формы
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Cash());
            }
        }
        /// <summary>
        /// Здесь мы работаем с пользователем
        /// Даем выбор закупить арсенал
        /// Однако изначально количество в будущем купленного оружия мы не знаем, соответсвенно записываем в строку
        /// после чего создаем массив объектов оружия и задаем рандомные параметры в диапозоне по условию
        /// </summary>
        /// <param name="money"></param>
        public static void Weapon(int money)
        {
            string st = "";
            string question = "Choose a weapon:\n" +
                    "1) Pistol - 10$\n" + "2) AutomaticWeapon - 15$\n" + "3) Machinegun - 20$\n" + "4) To complete the purchase.\n";
            int ans = 0;
            while (money >= 10) // ровно до тех пор пока есть деньги, которых хватает хотя бы на одно орудие
            {
                Console.Clear();
                Console.WriteLine($"{money}$ left");
                ans = Check.ReadInt(question, 1, 4);
                if (ans == 1)
                {
                    st += "1";
                    money -= 10;
                    Console.WriteLine("The purchase was successful!");
                }
                else if (ans == 2 && money >= 15)
                {
                    st += "2";
                    money -= 15;
                    Console.WriteLine("The purchase was successful!");
                }
                else if (ans == 3 && money >= 20)
                {
                    st += "3";
                    money -= 20;
                    Console.WriteLine("The purchase was successful!");
                }
                else if (ans == 4)
                    break;
                else
                    Console.WriteLine("Not enough money!");
            }
            guns = new Gun[st.Length]; // cоздаем массив и заполняем его разными видами орудий с их параметрами
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == '1')
                    guns[i] = new Pistol(rnd.Next(10, 15 + 1), rnd.Next(5, 8 + 1));
                else if (st[i] == '2')
                    guns[i] = new AutomaticWeapon(rnd.Next(13, 18 + 1), rnd.Next(9, 14 + 1), rnd.NextDouble() * (0.3) + 0.3);
                else
                    guns[i] = new Machinegun(rnd.Next(10, 25 + 1), rnd.Next(8, 16 + 1), rnd.NextDouble() * (0.1) + 0.3, rnd.Next(2, 4 + 1), rnd.NextDouble() * (0.2) + 0.1);
            }
            do
            {
                if (ans != 4)// если пользователь захочет выйти то нажмет 4
                    Console.WriteLine($"{money}$ left and this is not enough, to exit click Enter");
                else
                    return;
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
        }

        /// <summary>
        /// Момент взаимодействия с пользователем
        /// Нам важно узнать желаемое количество отрядов
        /// и в отдельности параметры каждого отряда - то бишь кол-во юнитов и их общее здоровье
        /// </summary>
        /// <param name="units"></param>
        public static void Army(int units)
        {
            squad = new Squad[units];
            Console.Clear();
            for (int i = 0; i < units; i++)
            {
                Console.WriteLine($"{i + 1} unit features:");
                int amount = Check.ReadInt("Enter the number of units in the squad [1;10]: ", 1, 10);
                int health = Check.ReadInt("Enter their total hp [10,200]: ", 10, 200);
                squad[i] = new Squad(amount, health);
                Console.Clear();
            }
        }
 
        /// <summary>
        /// Здесь и происходит сражение продолжающееся до того момента, пока либо не умрут все бойцы отрядо
        /// либо кончатся патроны на всех пушках
        /// Соответсвенно главный игрок рандом - выбирается случайный игрок и случайная пушка, производится атака
        /// </summary>
        public static void War()
        {
            len1 = guns.Length;
            len2 = squad.Length;
            int damage;
            string answer = "?";
            Screen(1);
            Console.WriteLine("To exit, press escape, to attack - any key");
            while (len1 > 0 && len2 > 0 && Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                int gun = rnd.Next(0, len1); // рандомое оружие
                int unit = rnd.Next(0, len2); // рандомные отряд
                if (guns[gun].Patrons == 0) // если пуль нет то предоставляется возможность испытать судьбу
                {
                    if (len1 > 1) // если же пушка одна и патронов нет - ты увы но проиграл
                        answer = ReLive(gun);
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You lose!");
                        return;
                    }
                }
                damage = guns[gun].Shoot();
                squad[unit][squad[unit].Amount - 1] -= damage;// непосредственно урон

                if (guns[gun].GetType().ToString() == "Weapon.Machinegun") // случайность поломки орудия
                    if (((Machinegun)guns[gun]).LifeTime != -1)
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
                            guns[gun] = guns[len1 - 1];
                            len1--;
                            answer = "1";
                        }

                    }
                }
                Console.Clear();
                // комментарии для пользователя о проведенном ударе
                if (damage == 0)
                    Console.WriteLine("Missed.Failure.Lucky next time");
                else if (damage > 0)
                    Console.WriteLine("A great shot was fired!");
                if (answer == "1")
                    Console.WriteLine($"Unfortunately, gun number {gun} broke");
                Screen(1);
                Console.WriteLine("To exit, press escape, to attack - any key");
            }
            Console.Clear();
            if (len1 == 0)
                Console.WriteLine("You Lose");
            else if (len2 == 0)
                Console.WriteLine("You Won!");
        }
        /// <summary>
        /// Представляет пользователю существующий расклад
        /// </summary>
        /// <param name="index">индекс того орудие которое не нудно выводить</param>
        /// <param name="except">исключение для вывода отрядов соперников</param>
        public static void Screen(int index, int except = -1)
        {
            Console.WriteLine("Weapons:");
            for (int i = 0; i < len1; i++)
            {
                //информация об орудиях 
                if (i != except)
                {
                    if (guns[i].GetType().ToString() == "Weapon.Machinegun")
                        Console.WriteLine($"{i + 1}) {guns[i].GetType()}\n"
                            + $"Patrons: {guns[i].Patrons}\n"
                            + $"Damage: {guns[i].Damage}\n"
                            + $"Coef: {((Machinegun)guns[i]).Coef}\n"
                            + $"LifeTime: {((Machinegun)guns[i]).LifeTime}\n"
                            + $"Breaking: {((Machinegun)guns[i]).Breaking}\n");
                    else if (guns[i].GetType().ToString() == "AutomaticWeapon")
                        Console.WriteLine($"{i + 1}) {guns[i].GetType()}\n"
                            + $"Patrons: {((AutomaticWeapon)guns[i]).Patrons}\n"
                            + $"Damage: {((AutomaticWeapon)guns[i]).Damage}\n"
                            + $"Coef: {((AutomaticWeapon)guns[i]).Coef}\n");
                    else
                        Console.WriteLine($"{i + 1}) {guns[i].GetType()}\n"
                            + $"Patrons: {guns[i].Patrons}\n"
                            + $"Damage: {guns[i].Damage}\n");
                }
            }
            // ИНформация об отрядах
            if (index == 1)
            {
                Console.WriteLine("Squads:");
                int health;
                int cur = 0;
                for (int i = 0; i < len2; i++)
                {
                    Console.WriteLine($"{i + 1} unit:");
                    Console.Write("[");
                    for (int j = 0; j < squad[i].Amount; j++)
                    {
                        health = (int)squad[i].Health / squad[i].Amount;
                        cur += squad[i][j];
                        if (squad[i][j] > 0.6 * health)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("|");
                            Console.ResetColor();
                        }
                        else if (squad[i][j] > 0.3 * health && squad[i][j] <= 0.6 * health)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("|");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("|");
                            Console.ResetColor();

                        }
                    }
                    Console.Write("] ");
                    Console.WriteLine($"{cur}/{squad[i].Health} hp");
                    cur = 0;
                }
            }
        }
        /// <summary>
        /// Этот запускается в случае отсутсвия атронов в пушке. Здесь предаставляется выбор для
        /// игрока - рискнуть другой пушкой или нет. В случае риска вы можете потерять хорошее оружие.
        /// Обратно потерять оружие с нулевым количеством патронов 
        /// </summary>
        /// <param name="index"> номер пушки в которой 0 патронов</param>
        /// <returns></returns>
        public static string ReLive(int index)
        {
            Console.Clear();
            int ans = Check.ReadInt("Do you want to take a chance?\n1) Press 1 if  you want\n2) Press 2 if you don't want\n", 1, 2);
            Console.Clear();
            if (ans == 1)
            {
                Screen(0, index);
                int choice = Check.ReadInt("Choose a gun number to take a chance\n", 1, len1);
                while (choice - 1 == index)
                {
                    choice = Check.ReadInt("Choose a gun number to take a chance(you cannot take a gun which we have now)\n", 1, len1);
                }
                if (rnd.NextDouble() < 0.5)
                {
                    guns[index].Patrons += 5;
                    return "You took a chance and restored 5 patrons";
                }
                else
                {
                    guns[choice - 1] = guns[len1 - 1];
                    len1--;
                    return "You took a chance and lost everything! Keep going";
                }

            }
            else if (ans == 2)
            {
                guns[index] = guns[len1 - 1];
                len1--;
                return "You decided to part with your gun, it was your choice!";
            }
            return "You decided to part with your gun, it was your choice!";
        }
    }
}
