using Program.Entity;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 42, "Knight");
            Console.WriteLine($"Introducing the character... {knight}");
          //Console.WriteLine("Arus " + knight.Attack(2));
            Console.WriteLine("Arus " + knight.Attack(21));

            Console.WriteLine();

            Wizard wizard = new Wizard("Jennica", 42, "White Wizard");
            Console.WriteLine($"Introducing the character... {wizard}");
          //Console.WriteLine("Jennica " + wizard.Attack(1));
            Console.WriteLine("Jennica " + wizard.Attack(9));

            Console.WriteLine();

            Wizard black_wizard = new Wizard("Topapa", 42, "Black Wizard");
            Console.WriteLine($"Introducing the character... {black_wizard}");
            Console.WriteLine("Topapa " + wizard.Attack(3));
          //Console.WriteLine("Topapa " + wizard.Attack(43));

            Console.WriteLine();

            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            Console.WriteLine($"Introducing the character... {ninja}");
          //Console.WriteLine("Wedge " + ninja.Attack(2));
            Console.WriteLine("Wedge " + ninja.Attack(24));
        }
    }
}