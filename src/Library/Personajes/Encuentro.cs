using System;
using System.Collections.Generic;
using System.Linq;

namespace RoleplayGame
{
    public class Encuentro
    {
        private List<Personaje> jugadores = new List<Personaje>();
        private List<Heroe> heroes = new List<Heroe>();
        private List<Enemigo> enemigos = new List<Enemigo>();

        private int contador;
        private int poderEnemigo = 0;
        private int poderHeroe = 0;
        
        public List<Personaje> Jugadores
        {
            get
            {
                return this.jugadores;
            }
        }
        public void agregarPersonaje (Personaje personaje) //Agregamos los personajes
        {
            if (!jugadores.Contains(personaje))
            {
                jugadores.Add(personaje);
            }
        }
        public void Batallar() //Empezamos la batalla
        {
            foreach (Personaje jugador in jugadores)
            {
                if (jugador is Heroe)
                {
                    heroes.Add((Heroe)jugador); 
                }
                else
                {
                    enemigos.Add((Enemigo)jugador); 
                }
            }

            contador = 0;  //inicializamos en 0
            
            do
            {
                foreach (Enemigo jugador in enemigos) //para cada jugador 
                {
                    if (heroes.Count >= 1)
                    {
                        heroes[contador].recibirAtaque(jugador.valorAtaque);

                        if (heroes[contador].Vida <= 0) //si la vida es menor a 0 lo eliminamos
                        {
                            heroes.Remove(heroes[contador]);
                        }
                        else { contador ++; } //iteramos

                        if (contador >= heroes.Count - 1)
                        {
                            contador = 0;
                        }
                    }
                }

                if (heroes.Count >= 1)
                {

                    foreach (Heroe hero in heroes)
                    {
                        if (enemigos.Count >= 1)
                        {
                            for (int i = 0; i < enemigos.Count; i++)
                            {
                                enemigos[i].recibirAtaque(hero.valorAtaque);
                                if (enemigos[i].Vida <= 0)
                                {
                                    hero.puntosTotales(enemigos[i].puntosDeVictoria);
                                    enemigos.Remove(enemigos[i]);
                                }
                            }
                        }
                    }
                }

            } while (heroes.Count > 0 && enemigos.Count > 0);

            if (heroes.Count >= 1)
            {
                foreach (Heroe hero in heroes)
                {
                    if (hero.puntosDeVictoria >= 5)
                    {
                        hero.recuperarVida();
                        hero.puntosDeVictoria -= 5;
                    }
                }
            }
        }
    }
}

