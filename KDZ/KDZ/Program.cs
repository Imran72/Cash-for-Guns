using System;
using Weapon;
using Opponents;

namespace KDZ
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Menu()
        {
            double money = DataCheck("Введите сумму денег", 0, Int32.MaxValue);

        }

        static int DataCheck(string info, int rg, int lf)
        {
            int data;
            while (true)
            {
                try
                {
                    Console.WriteLine(info);
                    string str = Console.ReadLine();

                    data = int.Parse(str);
                    if (data < lf || data > rg)
                        throw new ArgumentException();
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Empty");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Number must be in [{lf};{rg}]");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Number must be in [{lf};{rg}]");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number");
                }
            }
            return data;
        }

        static void Shopping(double money)
        {
            double[] arr = new double[(int)(money / 10)];
            int ind = 0;
            while (money >= 10)
            {
                Console.WriteLine("1 - покупка Pistol");
                Console.WriteLine("2 - покупка AutomaticWeapon");
                Console.WriteLine("3 - покупка Machinegun");
                int num = DataCheck("Веберите номе", 1, 3);
                arr[ind] = num;
                if (num == 1)
                    money -= 10;
                else if (num == 2)
                    money -= 15;
                else
                    money -= 20;
                ind++;
            }
        }

    }
}
