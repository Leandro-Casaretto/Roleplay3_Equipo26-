using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeHechizos libro = new LibroDeHechizos();
            libro.agregarHechizo(new Hechizo());
            

            Mago pedro = new Mago("Pedro");

            
            Enano jose = new Enano("Jose");

            Console.WriteLine($"Jose tiene ❤️ {jose.Vida}");
            Console.WriteLine($"Pedro ataca a Jose con ⚔️ {pedro.valorAtaque}");

            jose.recibirAtaque(pedro.valorAtaque);

            Console.WriteLine($"Jose has {jose.Vida}");

            jose.recuperarVida();

            Console.WriteLine($"{jose.Vida}");
        }
    }
}
