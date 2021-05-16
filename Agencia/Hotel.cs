using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    class Hotel : Alojamiento
    {
        protected float precioPorPersona;

        public Hotel(int Codigo, string Nombre, string Ciudad, string Barrio, int Estrellas, int CantPersonas, bool Tv, float PrecioPP)
        {
            codigo = Codigo;
            nombre = Nombre;
            ciudad = Ciudad;
            barrio = Barrio;
            estrellas = Estrellas;
            cantPersonas = CantPersonas;
            tv = Tv;
            precioPorPersona = PrecioPP;
        }
        public Hotel(){
            int Codigo = codigo;
            string Nombre = nombre;
            string Ciudad = ciudad;
            string Barrio = barrio;
            int Estrellas = estrellas;
            int CantPersonas = cantPersonas;
            bool Tv = tv;
            float PrecioPP =precioPorPersona;

            Console.WriteLine("Ingrese Codigo: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Ciudad: ");
            ciudad = Console.ReadLine();

            Console.WriteLine("Ingrese Barrio: ");
            barrio = Console.ReadLine();

            Console.WriteLine("Ingrese Estrellas: ");
            estrellas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cantidad de personas: ");
            cantPersonas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese si tiene TV: ");
            tv = Convert.ToBoolean(Console.ReadLine());
         
            

            Console.WriteLine("Ingrese Precio por persona: ");
            precioPorPersona = Convert.ToSingle(Console.ReadLine());


        }

        public void setPrecioPorPersona(float nuevoPrecioPP) { precioPorPersona = nuevoPrecioPP; }

        public float getPrecioPorPersona() { return precioPorPersona; }

        public override string ToString()
        {
            return base.ToString() + " Precio: " + precioPorPersona;
        }

    }
}
