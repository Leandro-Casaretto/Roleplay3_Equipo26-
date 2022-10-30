using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Mago: Heroe
    {


        public Mago(string nombre) : base(nombre)
        {  
            this.agregarElemento(new CapaOscura());
            this.agregarElemento(new BaculoHelado());
        }         
    }
}