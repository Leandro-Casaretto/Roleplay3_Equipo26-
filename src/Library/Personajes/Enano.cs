using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Enano: Heroe
    {


        public Enano(string nombre) : base(nombre)
        {  
            this.agregarElemento(new Martillo());
            this.agregarElemento(new Armadura());
        }         
    }
}