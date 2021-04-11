using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2{

    class Alojamiento{

        private int codigo;
        private String ciudad;
        private String barrio;
        private String estrellas;
        private int cantPersonas;
        private Boolean TV;

        public Alojamiento(int codigo,String ciudad, String barrio, String estrellas, int cantPersonas, Boolean TV){
            this.codigo = codigo;
            this.ciudad = ciudad;
            this.barrio = barrio;
            this.estrellas = estrellas;
            this.cantPersonas = cantPersonas;
            this.TV = TV;
        }

        //Set y Get de CODIGO
        public void setCodigo(int codigo){
            this.codigo = codigo;
        }

        public int getCodigo(){
            return  codigo;
        }

        //Set y Get de CIUDAD
        public void setCiudad(String ciudad){
            this.ciudad = ciudad;
        }

        public String getCiudad(){
            return ciudad;
        }

        //Set y Get BARRIO
        public void setBarrio(String barrio){
            this.barrio = barrio;
        }

        public String getBarrio(){
            return barrio;
        }

        //Set y Get ESTRELLAS
        public void setEstrellas(String estrellas){
            this.estrellas = estrellas;
        }

        public String getEstrellas(){
            return estrellas;
        }

        //Set y Get CANT PERSONAS
        public void setCantPersonas(int cantPersonas){
            this.cantPersonas = cantPersonas;
        }

        public int getCantPersonas(){
            return cantPersonas;
        }

        //Set y Get TV
        public void setTV(Boolean TV){
            this.TV = TV;
        }

        public Boolean getTV(Boolean TV){
            return TV;
        }

        //toString
        public override string ToString(){
            return "Codigo: " + codigo + "\nCiudad: " + ciudad + "\nBarrio: " + barrio + "\nEstrellas: " + estrellas + "\nCantidad de Personas: " + cantPersonas + "\nContiene TV: " + TV;
        }

        public Boolean igualCodigo(Alojamiento a)
        {
            if (a.getCodigo() == getCodigo())
            {
                return true;
            }
            else
            {
              return false;
            }
            
        }

    }
}
