using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Entity
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus)
        {
            Console.WriteLine();
            if (Bonus > 8)
            {
                return this.Name = "usou o super golpe com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name = "usou golpe fraco com bonus de ataque de " + Bonus;
            }
        }
    }
}
