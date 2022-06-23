using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Entity
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return "\nNome: " + this.Name + "\nNível: " + this.Level + "\nTipo de herói: " + this.HeroType;
        }

        public virtual string Attack()
        {
            Console.WriteLine("");
            return this.Name = "usou a espada para atacar!";
        }

        public string Attack(int Bonus)
        {
            Console.WriteLine();
            if (Bonus > 8)
            {
                return this.Name = "usou a espada super flamejante com bonus de ataque de " + Bonus;
            }
            else
            {
              return this.Name = "usou a espada com bonus de ataque de " + Bonus;    
            }
        }
    }
}
