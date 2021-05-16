using System;

namespace Agencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cabaña pruebaC = new Cabaña();
            //Hotel pruebaH = new Hotel();
            Cabaña elmanquito = new Cabaña(001, "El Manquito", "General San Martin", "Villa Lynch", 3, 5, true, 1526, 2, 1);
            Hotel zurdito = new Hotel(002, "Zurdito", "General San Martin", "Billinghurst", 4, 6, true, 1424);
            Hotel viper = new Hotel(003, "Viper", "Capital Federal", "Nuñez", 5, 3, true, 2000);



            Agencia grupo3 = new Agencia(5);

            //Agrego los 2 alojamientos en la base de datos de Agencia
            grupo3.insertarAlojamiento(elmanquito);
            grupo3.insertarAlojamiento(zurdito);
            grupo3.insertarAlojamiento(viper);
            //grupo3.insertarAlojamiento(pruebaH);
            //grupo3.insertarAlojamiento(pruebaC);

            //Verifico si estan en agregados
            Console.WriteLine(grupo3.estaAlojamiento(elmanquito));
            Console.WriteLine(grupo3.estaAlojamiento(zurdito));
            Console.WriteLine(grupo3.estaAlojamiento(viper));
            
            


            Console.WriteLine("Si es False a la base de datos todavia le quedan lugares :"+ grupo3.estaLlena());
            Console.WriteLine("Si es True hay alojamientos disponibles en la Agencia :"+ grupo3.hayAlojamientos());

            Console.WriteLine("\nMuestro solo los Hoteles :");
            grupo3.soloHoteles();

            Console.WriteLine("\nMuestro los alojamientos con las estrellas que se ingresaron :");
            grupo3.masEstrellas(5);
            
                 
            Console.WriteLine("\nCabañas entre precios :");
            grupo3.cabañasEntrePrecios(15, 1600);


            Console.WriteLine("\nMuestro los alojamientos desde el metodo");
            grupo3.getAlojamientos();


            Console.WriteLine("\nMuestro todos los alojamientos disponibles en la base de datos :");
            Console.WriteLine(elmanquito.ToString());
            Console.WriteLine(zurdito.ToString());
            Console.WriteLine(viper.ToString());
            //Console.WriteLine(pruebaC.ToString());
            //Console.WriteLine(pruebaH.ToString());

        }
    }
}
