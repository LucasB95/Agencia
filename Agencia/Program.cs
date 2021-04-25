using System;

namespace Agencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cabaña elmanquito = new Cabaña(001, "El Manquito", "General San Martin", "Villa Lynch", 3, 5, true, 1526, 2, 1);
            Hotel zurdito = new Hotel(002, "Zurdito", "General San Martin", "Billinghurst", 4, 6, true, 1424);
            Hotel viper = new Hotel(003, "Viper", "Capital Federal", "Nuñez", 5, 3, true, 2000);

            Agencia grupo3 = new Agencia(3);

            //Agrego los 2 alojamientos en la base de datos de Agencia
            grupo3.insertarAlojamiento(elmanquito);
            grupo3.insertarAlojamiento(zurdito);
            grupo3.insertarAlojamiento(viper);

            //Verifico si estan en agregados
            grupo3.estaAlojamiento(elmanquito);
            grupo3.estaAlojamiento(zurdito);
            grupo3.estaAlojamiento(viper);


            Console.WriteLine("Si es False a la base de datos todavia le quedan lugares :"+ grupo3.estaLlena());
            Console.WriteLine("Si es True hay alojamientos disponibles en la Agencia :"+ grupo3.hayAlojamientos());



            Console.WriteLine("Solo Hoteles " + grupo3.soloHoteles());
            Console.WriteLine("Busqueda por estrellas " + grupo3.masEstrellas(8));


            Console.WriteLine("Cabañas entre precios "+grupo3.cabañasEntrePrecios(15, 100));

            Console.WriteLine(grupo3.getAlojamientos()); 

            Console.WriteLine(elmanquito.ToString());
            Console.WriteLine(zurdito.ToString());
            Console.WriteLine(viper.ToString());
        }
    }
}
