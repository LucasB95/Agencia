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
                else
                {
                    for (int i = 0; i < cantAlojamientos; i++)
                    {
                        if (alojamientoAgencia[i] == null && alojamientoAgencia[i] != aloj)
                        {

                            alojamientoAgencia[i] = aloj;
                            break;

                        }

                    }

                    return true;
                }

            }
            return false;

        }

        public bool estaAlojamiento(Alojamiento aloj)
        {
            for (int i = 0; i < alojamientoAgencia.Length; i++)
            {
                if (aloj.getCodigo() == alojamientoAgencia[i].getCodigo())
                {
                    return true;

                }
            }

            return false;
        }

        public bool estaLlena()
        {
            int vueltas = 0;
            int contadorArray = 0;
            for (int i = 0; i < alojamientoAgencia.Length; i++)
            {
                vueltas++;
                if (alojamientoAgencia[i] != null)
                {
                    contadorArray++;
                }
            }

            if (vueltas == contadorArray)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool hayAlojamientos()
        {

            Alojamiento[] hayAloj = new Alojamiento[cantAlojamientos + 1];

            for (int i = 0; i < alojamientoAgencia.Length; i++)
            {
                if (alojamientoAgencia[i] != null)
                {
                    hayAloj[i] = alojamientoAgencia[i];
                    return true;
                }

            }

            for (int i = 0; i < hayAloj.Length; i++)
            {
                if (hayAloj[i] != null)
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

            for (int i = 0; i < alojamientoAgencia.Length; i++)
            {
                if (alojamientoAgencia[i] != null && alojamientoAgencia[i] is Hotel)
                {
                    Salida.insertarAlojamiento(alojamientoAgencia[i]);
                    Console.WriteLine(alojamientoAgencia[i].ToString());

                }
            }

            return Salida;

        }

        public Agencia masEstrellas(int cant)
        {
            Agencia Salida = new Agencia(this.cantAlojamientos);
            for (int i = 0; i < alojamientoAgencia.Length; i++)
            {
                if (alojamientoAgencia[i] != null && alojamientoAgencia[i].getEstrellas() >= cant)
                {
                    Salida.insertarAlojamiento(alojamientoAgencia[i]);
                    Console.WriteLine(alojamientoAgencia[i].ToString());
                }
            }

            return Salida;
        }


        public Agencia cabañasEntrePrecios(float d, float h)
        {
            Agencia A2 = new Agencia(this.cantAlojamientos);
           
                foreach (Alojamiento aloj in alojamientoAgencia) 
                { 
                    if (aloj is Cabaña)
                    {
                        Cabaña c = (Cabaña)aloj;
                        if (c.getPrecioPorPersona() <= h && c.getPrecioPorPersona() >= d)
                        {
                            A2.insertarAlojamiento(c);
                            Console.WriteLine(c.ToString());
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron Cabañas con el rango de precio buscado");
                    }


                    }
                }


            return A2;
        }

        public int getCantidad()
        {

            return cantAlojamientos;
        }
        public void setCantidad(int CantAlojamientos)
        {

            cantAlojamientos = CantAlojamientos;

        }

        public Alojamiento[] getAlojamientos()
        {
            Alojamiento[] aux;
            aux = new Alojamiento[cantAlojamientos];
            for (int i = 0; i < alojamientoAgencia.Length; i++)
            {
                if (alojamientoAgencia[i] != null)
                {

                    aux[i] = alojamientoAgencia[i];
                    Console.WriteLine(alojamientoAgencia[i].ToString());
              
                }
              
            }
            return aux;
            //return aux.OrderBy(x => x.getEstrellas()).ThenBy(x => x.getCantPersonas()).ThenBy(x => x.getCodigo()).ToArray();
        }
    }
}
