using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroDeHechizos libro = new LibroDeHechizos();
            libro.Hechizos = new Hechizo[]{ new Hechizo() };

            Mago pedro = new Mago("Pedro");
            pedro.BaculoHelado = new BaculoHelado();

            Elfo jose = new Elfo("Jose");
            jose.ArcoPesado = new ArcoPesado();
            jose.BotasDeOro = new BotasDeOro();

            Console.WriteLine($"Jose tiene {jose.Vida}");
            Console.WriteLine($"Pedro ataca a Jose con {pedro.valorAtaque}");

            jose.perderVida(pedro);

            Console.WriteLine($"Jose tiene {jose.Vida}");

            jose.recuperarVida(jose);

            Console.WriteLine($"Jose tiene {jose.Vida}");
        }
    }
}
