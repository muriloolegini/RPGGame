using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Entity
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }
        public override string Attack()
        {
            Console.WriteLine();
            return this.Name = "lançou magia!";
        }

        public string Attack(int Bonus)
        {
            Console.WriteLine();
            if (Bonus > 8)
            {
                return this.Name = "lançou magia super efetiva com bonus de ataque de " + Bonus;
            }
            else
            {
                return this.Name = "lançou magia fraca com bonus de ataque de " + Bonus;
            }
        }

    }
}
