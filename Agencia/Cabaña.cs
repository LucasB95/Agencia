using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    
    class Cabaña : Alojamiento
    {
        protected float precioDia;
        protected int habitaciones;
        protected int baños;

        public Cabaña(int Codigo, string Nombre, string Ciudad, string Barrio, int Estrellas, 
            int CantPersonas, bool Tv, float PrecioDIA, int Habitaciones, int Baños)
        {
            codigo = Codigo;
            nombre = Nombre;
            barrio = Barrio;
            ciudad = Ciudad;
            estrellas = Estrellas;
            cantPersonas = CantPersonas;
            tv = Tv;
            precioDia = PrecioDIA;
            habitaciones = Habitaciones;
            baños = Baños;
        }
        public Cabaña()
        {
            int Codigo = codigo;
            int Estrellas = estrellas;
            int CantPersonas = cantPersonas;
            int Habitaciones = habitaciones;
            int Banos = baños;
            bool Tv = tv;
            float PrecioDIA = precioDia;
            string Ciudad =ciudad;
            string Barrio = barrio;
            string Nombre = nombre;

            Console.WriteLine("Ingrese código de Cabaña: ");
            codigo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la ciudad: ");
            ciudad = Console.ReadLine();

            Console.WriteLine("Ingrese el barrio: ");
            barrio = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de personas: ");
            cantPersonas = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de baños: ");
            baños = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese si tiene TV con true('si') o false('no') :");
            tv = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de estrellas: ");
            estrellas = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de habitaciones: ");
            habitaciones = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese precio por día: ");
            precioDia = Convert.ToSingle(Console.ReadLine());

            
        }

        public void setPrecioPorPersona(float nuevoPrecioPP) { precioDia = nuevoPrecioPP; }

        public float getPrecioPorPersona() { return precioDia; }

        public void setHabitaciones(int Habitaciones) { habitaciones = Habitaciones; }

        public int getHabitaciones() { return habitaciones; }

        public void setBaños(int Baños) { baños = Baños; }

        public int getBaños() { return baños; }

        public override string ToString()
        {
            return base.ToString() + " Precio: " + precioDia;
        }

    }
}
