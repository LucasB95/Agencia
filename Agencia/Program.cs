using System;

namespace Agencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cabaña elmanquito = new Cabaña(001, "El Manquito", "General San Martin", "Villa Lynch", 3, 5, true, 1526, 2, 1);
            Hotel zurdito = new Hotel(002, "Zurdito", "General San Martin", "Billinghurst", 4, 6, true, 1424);

            Agencia grupo3 = new Agencia(2);

            //Agrego los 2 alojamientos en la base de datos de Agencia
            grupo3.insertarAlojamiento(elmanquito);
            grupo3.insertarAlojamiento(zurdito);

            //Verifico si estan en agregados
            grupo3.estaAlojamiento(elmanquito);
            grupo3.estaAlojamiento(zurdito);


            Console.WriteLine("Si es False a la base de datos todavia le quedan lugares :"+ grupo3.estaLlena());
            Console.WriteLine("Si es True hay alojamientos disponibles en la Agencia :"+ grupo3.hayAlojamientos());


            Console.WriteLine(grupo3.soloHoteles());
            Console.WriteLine(grupo3.masEstrellas(3));

            //grupo3.soloHoteles();
            //grupo3.masEstrellas(3);

            //grupo3.cabañasEntrePrecios(15, 4000);
            Console.WriteLine(grupo3.cabañasEntrePrecios(15, 4000));

            //Console.WriteLine(grupo3.getAlojamientos()); a fue null tira error

            Console.WriteLine(elmanquito.ToString());
            Console.WriteLine(zurdito.ToString());
        }
    }
}
