using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Cabaña: Alojamiento
    {
        private float precioXDia;
        private int habitaciones;
        private int baños;

        public Cabaña(int codigo,String ciudad, String barrio, String estrellas, int cantPersonas, Boolean TV,float precioXDia, int habitaciones, int baños)
            : base(codigo, ciudad, barrio, estrellas, cantPersonas, TV)
        {
            
            this.precioXDia = precioXDia;
            this.habitaciones = habitaciones;
            this.baños = baños;
        }

        public void PrecioXDia(float pred)
        {
            this.precioXDia = pred;
        }
        public float PrecioXDia()
        {
            return precioXDia;
        }
        public void Habitaciones(int hab)
        {
            this.habitaciones = hab;
        }
        public int Habitaciones()
        {
            return habitaciones;
        }
        public void Baños(int ban)
        {
            this.baños = ban;
        }
        public int Baños()
        {
            return baños;
        }

        public override string ToString() 
            
        {
            return base.ToString()+ "\nPrecio del dia"+precioXDia + "\nCantidad de habitaciones" + habitaciones + "\nCantidad de baños"+ baños;
        }


    }

   
}
