using System;

namespace Agencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cabaña cabaña1 = new Cabaña();
            Hotel hotel1 = new Hotel();
            Cabaña cabaña2 = new Cabaña();
            Hotel hotel2 = new Hotel();

            //Datos creados para prueba de verificacion rapida
            //Cabaña elmanquito = new Cabaña(001, "El Manquito", "General San Martin", "Villa Lynch", 3, 5, true, 1526, 2, 1);
            //Hotel zurdito = new Hotel(002, "Zurdito", "General San Martin", "Billinghurst", 4, 6, true, 1424);
            //Hotel viper = new Hotel(003, "Viper", "Capital Federal", "Nuñez", 5, 3, true, 2000);


            Agencia grupo3 = new Agencia(5);

            //grupo3.insertarAlojamiento(elmanquito);
            //grupo3.insertarAlojamiento(zurdito);
            //grupo3.insertarAlojamiento(viper);

            grupo3.insertarAlojamiento(hotel1);
            grupo3.insertarAlojamiento(cabaña1);
            grupo3.insertarAlojamiento(cabaña2);
            grupo3.insertarAlojamiento(hotel2);

            //Verifico si estan en agregados
            //Console.WriteLine(grupo3.estaAlojamiento(elmanquito));
            //Console.WriteLine(grupo3.estaAlojamiento(zurdito));
            //Console.WriteLine(grupo3.estaAlojamiento(viper));

            Console.WriteLine("Verifica si los alojamientos ingresaron correctamente a la base de datos");
            Console.WriteLine("Alojamiento 1 :" + grupo3.estaAlojamiento(cabaña1));
            Console.WriteLine("Alojamientos 2: " + grupo3.estaAlojamiento(cabaña2));
            Console.WriteLine("Alojamientos 2: " + grupo3.estaAlojamiento(hotel1));
            Console.WriteLine("Alojamientos 2: " + grupo3.estaAlojamiento(hotel2));

            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Si es False a la base de datos todavia le quedan lugares :"+ grupo3.estaLlena());
            Console.WriteLine("Si es True hay alojamientos disponibles en la Agencia :"+ grupo3.hayAlojamientos());

            Console.WriteLine("\nMuestro solo los Hoteles :");
            grupo3.soloHoteles();

            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Ingrese numeros de estrellas a buscar: ");
            int estrellas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Muestro los alojamientos con las estrellas que se ingresaron :");           
            grupo3.masEstrellas(estrellas);

            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Ingrese el precio minimo: ");
            float desde = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el precio maximo: ");
            float hasta = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Cabañas encontradas en ese rango de precio :");
            grupo3.cabañasEntrePrecios(desde, hasta);

            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nMuestro los alojamientos desde el metodo");
            grupo3.getAlojamientos();


            Console.WriteLine("\nMuestro todos los alojamientos disponibles en la base de datos :");

            //Console.WriteLine(elmanquito.ToString());
            //Console.WriteLine(zurdito.ToString());
            //Console.WriteLine(viper.ToString());

            Console.WriteLine(cabaña1.ToString());
            Console.WriteLine(cabaña2.ToString());
            Console.WriteLine(hotel1.ToString());
            Console.WriteLine(hotel2.ToString());

        }
    }
}
