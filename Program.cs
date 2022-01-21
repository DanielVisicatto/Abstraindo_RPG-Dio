using ProjetoGFT_Abstraindo_Jogo_RPG.src.Entities;

namespace ProjetoGFT_Abstraindo_Jogo_RPG.src.Entities
{
    class Program
    {
        static void Main (string[] args)
        {
            Knight arus = new("Arus", 23, "Knight", 800, 50);
            Ninja wedge = new("Wedge", 23, "Ninja", 777, 150);
            Wizard wizard = new("Jenica", 23, "White Wizard", 602, 997);
            BlackWizard topapa = new("Topapa", 23, "Black Wizard", 412, 985);

           
            System.Console.WriteLine($@"Ataque da(o) {arus.Name}");
            System.Console.WriteLine($@"{arus.Attack()}");
            System.Console.WriteLine($@"{arus.Attack(4)}");
            System.Console.WriteLine($@"{arus.Attack(6)}");
            System.Console.WriteLine($@"{arus.Attack(10)}");
            System.Console.WriteLine("");
            
            System.Console.WriteLine($@"Ataque da(o) {wizard.Name}");
            System.Console.WriteLine($@"{wizard.Attack()}");
            System.Console.WriteLine($@"{wizard.Attack(4)}");
            System.Console.WriteLine($@"{wizard.Attack(6)}");
            System.Console.WriteLine($@"{wizard.Attack(10)}");
            System.Console.WriteLine("");
            
            System.Console.WriteLine($@"Ataque da(o) {wedge.Name}");
            System.Console.WriteLine($@"{wedge.Attack()}");
            System.Console.WriteLine($@"{wedge.Attack(4)}");
            System.Console.WriteLine($@"{wedge.Attack(6)}");
            System.Console.WriteLine($@"{wedge.Attack(10)}");
            System.Console.WriteLine("");

            System.Console.WriteLine($@"Ataque da(o) {topapa.Name}");
            System.Console.WriteLine($@"{topapa.Attack()}");
            System.Console.WriteLine($@"{topapa.Attack(4)}");
            System.Console.WriteLine($@"{topapa.Attack(6)}");
            System.Console.WriteLine($@"{topapa.Attack(10)}");
            System.Console.WriteLine("");
           
        }
    }
}
