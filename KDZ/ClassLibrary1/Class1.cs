using System;
using Weapon;

namespace Opponents
{
    public class Squad
    {
        int amount; // Количество юнитов в отряде
        double health; // Их суммарное здоровье
        int hp; // минимальное здоровье каждого юнита
        int[] squad; // массив юнитов где хранится здоровье отдельно взятого каждого юнита

        public int this[int index] // Прекрасный индексатор
        {
            get {
                return squad[index];
            }
            set {
                squad[index] = value;
            }
        }
        public int Amount
        {
            get => amount;
            set {
                amount = value;
            }
        }
        public double Health
        {
            get => health;
            set {
                health = value;
            }
        }

        public Squad(int amount, int health)
        {
            this.amount = amount;
            this.health = health;
            hp = health / amount;
            squad = new int[amount];
            for (int i = 0; i < amount; i++) // Присваиваем каждому бниту здоровье однако последний уникален - он может взять среднее здорье плю общий остаток
                squad[i] = i != amount - 1 ? hp : hp + health % amount;
        }
    }

    public static class Check
    {
        public static int ReadInt(int left, int right, string str)  // Статистический класс для проверки входных данных. Посылается строка - обращение к пользователю и границы вводимого числа
        {
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(str);
                    if (n < left || n > right)
                        throw new ArgumentException();
                    break;
                }
                catch (ArgumentNullException)
                {
                    return (-1);
                }
                catch (ArgumentException)
                {
                    return (-1);
                }
                catch (OverflowException)
                {
                    return (-1);
                }
                catch (FormatException)
                {
                    return (-1);
                }
            }
            return n;
        }
        // Перегрузка прошлого класса
        public static int ReadInt(string info, int left, int right)  // Статистический класс для проверки входных данных. Посылается строка - обращение к пользователю и границы вводимого числа
        {
            int n;
            Console.Write(info + "");
            while (true)
            {
                try
                {
                    string str = Console.ReadLine();
                    n = int.Parse(str);
                    if (n < left || n > right)
                        throw new ArgumentException();
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Введите число");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"[{left};{right}] - число в этих пределах!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("ПЕреполнение");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат данных");
                }
            }
            return n;
        }

        
    }
}
