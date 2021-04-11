using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Hotel: Alojamiento
    {
    
        private float precioXPersona;

        public Hotel(int codigo, String ciudad, String barrio, String estrellas, int cantPersonas, Boolean TV, float precioXPersona)
            : base(codigo, ciudad, barrio, estrellas, cantPersonas, TV)
        {
            this.precioXPersona = precioXPersona; 
        }

        // set y get precioXPersona
        public void setPrecioXPersona(float precioXPersona)
        {
            this.precioXPersona = precioXPersona;
        }

        public float getPrecioXPersona()
        {
            return precioXPersona;
        }

        public override string ToString()

        {
            return base.ToString() + "\nPrecio por persona" + precioXPersona;
        }

    }
}
