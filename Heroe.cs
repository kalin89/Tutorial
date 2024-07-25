using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Heroe
    {
        public string Nombre {  get; set; }
        public int Vida { get; set; }
        public int Armandura { get; set; }
        public int DanoBasico { get; set; }
        public bool EstaVivo { get; set; } = true;
        public TipoHeroe Tipo {  get; set; }
        public Heroe(
            string nombre,
            TipoHeroe tipo,
            int vida = 100,
            int armadura = 0,
            int danoBasico = 10
            ) 
        {
            Nombre = nombre;
            Vida = vida;
            Armandura = armadura;
            DanoBasico = danoBasico;
            Tipo = tipo;
        }

        public int Atacar()
        {
            return DanoBasico;
        }

        public void RecibirDano(int dano)
        {
            //Manejar la armadura
            Vida = Vida - dano;
        }

        //Crear la manera de cambiar 
        // a false EstaVivo cuando el heroe
        // es derrotado
    }
}
