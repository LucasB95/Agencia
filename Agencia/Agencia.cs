using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Agencia
{
    class Agencia
    {
        

        private Alojamiento[] alojamientoAgencia;
        private int cantAlojamientos;
    

        public Agencia(int CantidadAlojamientos)
        {
            
            alojamientoAgencia = new Alojamiento[CantidadAlojamientos];
            cantAlojamientos = CantidadAlojamientos;
        }

        public bool insertarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in alojamientoAgencia)
            {
                if (a != null && a.igualCodigo(aloj))
                {

                    return false;
                }
                else {
                    for (int i = 0; i < cantAlojamientos; i++)
                    {
                        alojamientoAgencia[i] = aloj;
                    }

                    return true;
                }      

            }
            return false;
        
        }

        public bool estaAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in alojamientoAgencia) 
            { 
                if (a != null && a.igualCodigo(aloj))
                {
                return true;
                Console.WriteLine("El alojamiento ingresado se encuentra en la Agencia :" + aloj.getNombre());
                }
            else
                {
                return false;
                }
                   
             }
            return false;
         }

        public bool estaLlena() {
            int vueltas = 0;
            int contadorArray = 0;
            for (int i = 0; i < alojamientoAgencia.Length; i++)
            {
                vueltas++;   
                if(alojamientoAgencia[i] != null)
                {
                    contadorArray++; 
                }
            }

            if(vueltas == contadorArray)
            {
                return true;
                Console.WriteLine("El Array de Alojamiento esta lleno");
            }
            else
            {
                return false;
                Console.WriteLine("El Array no esta lleno");
            }


        }

        public bool hayAlojamientos() {

            Alojamiento[] hayAloj = new Alojamiento[cantAlojamientos + 1]; 

            for(int i = 0; i < alojamientoAgencia.Length; i++)
            {
                if(alojamientoAgencia[i] != null)
                {
                    hayAloj[i] = alojamientoAgencia[i];
                    return true;
                }
               
            }
        
            for(int i = 0;i < hayAloj.Length; i++)
            {
                if(hayAloj[i] != null)
                {
                    Console.WriteLine(hayAloj[i].ToString());
                    return true;
                }
               
            }

            return false;
        }


        public Agencia soloHoteles()
        {
            Agencia Salida = new Agencia(cantAlojamientos);
            foreach (Alojamiento a in alojamientoAgencia)
            {
               if (a != null  && a is Hotel)
                {
                    //Console.WriteLine(a.ToString());
                    Salida.insertarAlojamiento(a);
                  

                }
            }
            return Salida;         
               
        }
        public Agencia soloCabañas()
        {
            Agencia Salida = new Agencia(this.cantAlojamientos);
            foreach (Alojamiento a in alojamientoAgencia)
            {
                if (a != null && a is Cabaña)
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
            Agencia A2 = new Agencia(this.cantAlojamientos);
            for (int a=0; a< alojamientoAgencia.Length; a++)
            {
                if (d > 0 && h > 0)
                {
                    if (alojamientoAgencia[a] is Cabaña)
                    {
                        A2.insertarAlojamiento(alojamientoAgencia[a]);
                        Console.WriteLine(alojamientoAgencia[a].ToString());

                    }
                }

                
             }

            return A2;
        }

        public int getCantidad() { return cantAlojamientos; }
        public void setCantidad(int CantAlojamientos) { cantAlojamientos = CantAlojamientos; }


      

        public Alojamiento[] getAlojamientos()
        {

            Alojamiento[] aux;
            

            aux = new Alojamiento[cantAlojamientos];


            for (int i = 0; i < cantAlojamientos; i++)
            {
                if(aux != null) {

                    aux[i] = alojamientoAgencia[i];
                    //Console.WriteLine(alojamientoAgencia[i].ToString());
                    Console.WriteLine("Repeticiones :" + i);
                }

                // return aux;
            }

            return aux;

            //return aux.OrderBy(a => a.getEstrellas()).ThenBy(a => a.getCantPersonas()).ThenBy(a => a.getCodigo()).ToArray();
        }



    }
}
