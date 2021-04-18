using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia
{
    abstract class Alojamiento
    {
        protected int codigo;
        protected string nombre;
        protected string ciudad;
        protected string barrio;
        protected int estrellas;
        protected int cantPersonas;
        protected bool tv;

        public override string ToString()
        {
            return codigo + " - " + nombre + " - " + ciudad + " - " + barrio + " - " + estrellas;
        }
        public bool igualCodigo(Alojamiento a)
        {
            return codigo == a.getCodigo();
        }

        public void setCodigo(int Codigo) { codigo = Codigo; }
        public void setNombre(string Nombre) { nombre = Nombre; }
        public void setEstrellas(int Estrellas) { estrellas = Estrellas; }
        public void setCiudad(string Ciudad) { ciudad = Ciudad; }
        public void setBarrio(string Barrio) { barrio = Barrio; }
        public void setCantPersonas(int CantPersonas) { cantPersonas = CantPersonas; }
        public void setTV(bool tieneTV) { tv = tieneTV; }

        public int getCodigo() { return codigo; }
        public string getNombre() { return nombre; }
        public string getCiudad() { return ciudad; }
        public bool getTV() { return tv; }
        public string getBarrio() { return barrio; }
        public int getEstrellas() { return estrellas; }
        public int getCantPersonas() { return cantPersonas; }

    }
}
