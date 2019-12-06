using System;

namespace Weapon
{
    // Создаем абстрактный класс, становящийся родоначальном для всех остальных
    // у него свои протектед параметры если что
    public abstract class Gun
    {
        protected int patrons;
        protected int damage;
        public int Patrons
        {
            get => patrons;
            set {
                patrons = value;
            }
        }
        public int Damage { get => damage; }
        public abstract int Shoot();
    }

    // Пистолет производный класс от GUn 
    public class Pistol : Gun
    {
        public override int Shoot()// возвращает урон
        {
            this.patrons--;
            return damage;
        }
        public Pistol(int patrons, int damage)
        {
            this.patrons = patrons;
            this.damage = damage;
        }
    }
    // Пистолет производный класс от GUn 
    public class AutomaticWeapon : Gun
    {
        protected double coef; // Коэффициент промаха
        static Random rnd = new Random();
        
        public double Coef { get => coef;}
        public override int Shoot()
        {
            this.patrons--;
            if (rnd.NextDouble() > coef) // Используем рандом от 0 до 1, где любой исход равновероятен. Испытываем судьбу, после чего либо возвращаем урон, либо нет
                return damage;
            else
                return 0;
        }

        public AutomaticWeapon(int patrons, int damage, double coef)
        {
            this.patrons = patrons;
            this.damage = damage;
            this.coef = Math.Round(coef,2);
        }
    }
    // Производный класс от AutomaticWeapon
    public class Machinegun : AutomaticWeapon
    {
        protected double breaking;// Вероятность поломки
        protected int lifeTime;// МОмент поломки на конкретном моменте выстрела
        protected int numShots;// номер выстрела произведенного этим орудием
        static Random rnd = new Random();

        public double Breaking { get => breaking; }
        public double LifeTime { get => lifeTime; }

        public int NumShoots
        {
            get => numShots;
            set {
                numShots = value;
            }
        }
        public override int Shoot()
        {
            this.patrons--;
            numShots++;
            if (rnd.NextDouble() > coef)// Используем рандом от 0 до 1, где любой исход равновероятен. Испытываем судьбу, после чего либо возвращает урон либо нет
            {
                return damage;
            }
            else
                return 0;
        }

        public Machinegun(int patrons, int damage, double coef, int lifeTime, double breaking) : base(patrons, damage, coef)
        {
            this.lifeTime = lifeTime;
            this.breaking = Math.Round(breaking, 2);
            this.numShots = 0;
        }
    }
}
