using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Elfo: Heroe
    {


        public Elfo(string nombre) : base(nombre)
        {  
            this.agregarElemento(new ArcoPesado());
            this.agregarElemento(new CascoDeOro());
        }         
    }
}