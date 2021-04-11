using System;

namespace ConsoleApp2
{
    class Agencia
    {
        private Hotel hotel;
        private Alojamiento aloj;
        private int[] alojamientosAgencia;
        private int catAloj;

        public Agencia(int catAloj, int[] alojamientosAgencia)
        {
            this.alojamientosAgencia = alojamientosAgencia;
            this.catAloj = catAloj;
        }

        public void insertaAlojamiento(Alojamiento a)
        {
            if (aloj.getCodigo() == a.getCodigo())
            {
                if (a.getCantPersonas() < 0)
                {
                    Console.WriteLine("Hay lugar en el Alojamiento");
                }
            }
        }


        //public Boolean estaAlojamiento(Alojamiento a){
        //}


        public Boolean estaLLena()
        {
            if (aloj.getCantPersonas() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public Boolean hayAlojamientos()
        {

        }

        public void masEstrellas(int cantEstrellas)
        {

        }*/

        public Agencia soloHoteles(){

           return hotel.ToString();
  
        }

       /* public void cabañasEntrePrecios()
        {
            
        }*/
    }
}
