using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Agencia
{
    class Agencia
    {
        

        private Alojamiento[] alojamientoAgencia;
        //private alojamientoAgencia = new Alojamiento[];
        //private List<Alojamiento> misAlojamientos;
        private int cantAlojamientos;
        private const int MAX_ALOJ = 10;

        public Agencia(int CantidadAlojamientos)
        {
            
            alojamientoAgencia = new Alojamiento[Agencia.MAX_ALOJ];
            cantAlojamientos = CantidadAlojamientos;
        }

        public bool insertarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in alojamientoAgencia) { 
               if (a != null && a.igualCodigo(aloj))
                   return false;
            for (int i = 0; i > 10; i++) { 
                   alojamientoAgencia[i] = aloj; }

            }

            return true;

        }
        public bool estaAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in alojamientoAgencia)
                if (a != null && a.igualCodigo(aloj))
                    return true;
            Console.WriteLine("El alojamiento ingresado se encuentra en la Agencia :" + aloj.getNombre());
            return false;
         }

        public bool estaLlena() {
            int total = cantAlojamientos - alojamientoAgencia.Count();
            if (cantAlojamientos == alojamientoAgencia.Count())
            {
                return true;
              
            }
            
            return false;

        }

        public bool hayAlojamientos() { return alojamientoAgencia.Count() > 0; }


        /*Por lo que entiendo el metodo soloHoteles() es para mostrar los hoteles pero no puedo hacer q muestre los hoteles que hay
        ademas para que crea una nueva agencia y le asigna un nuevo alojamiento si en la nueva agencia no esta pasando las referencias de la otra agencia*/
        public Agencia soloHoteles()
        {
            Agencia Salida = new Agencia(this.cantAlojamientos);
            //foreach (Alojamiento a in alojamientoAgencia)
            //    if (a is Hotel)
            //        Salida.insertarAlojamiento(a);
            foreach (Alojamiento a in alojamientoAgencia)
            {
                if (a is Hotel)
                {
                    Console.WriteLine(a.ToString());
                    Salida.insertarAlojamiento(a);

                }
            }
            return Salida;

           
            
           
        }
        //Aca pasa lo mismo que en el metodo anterior -> soloHoteles()
        public Agencia masEstrellas(int cant)
        {
            Agencia Salida = new Agencia(this.cantAlojamientos);
            foreach (Alojamiento a in alojamientoAgencia)
                if (a != null &&  a.getEstrellas() >= cant)
                    Salida.insertarAlojamiento(a);
            return Salida;
        }

        //Aca pasa lo mismo que en el metodo anterior -> soloHoteles()
        public Agencia cabañasEntrePrecios(float d, float h)
        {
            Agencia Salida = new Agencia(this.cantAlojamientos);
            foreach (Alojamiento a in alojamientoAgencia)
                if (a is Cabaña)
                {
                    Cabaña c = (Cabaña)a;
                    if (c.getPrecioPorPersona() <= h && c.getPrecioPorPersona() >= d)
                        Salida.insertarAlojamiento(c);
                }

            return Salida;
        }

        public int getCantidad() { return cantAlojamientos; }
        public void setCantidad(int CantAlojamientos) { cantAlojamientos = CantAlojamientos; }


        //error tira que la "a" fue null
        public Alojamiento[] getAlojamientos()
        {
         
                return alojamientoAgencia.OrderBy(a => a.getEstrellas()).ThenBy(a => a.getCantPersonas()).ThenBy(a => a.getCodigo()).ToArray();
            
            

        }

    }
}
