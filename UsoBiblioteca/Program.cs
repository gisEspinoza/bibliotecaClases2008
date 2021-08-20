using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace UsoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el elemento a crear: ");
            Console.WriteLine("1. List");
            Console.WriteLine("2. SortedList");
            var response = Console.ReadLine();

            //evaluar la respuesta del usuario
            if (response == "1")
            {
                CollectionExample.ListCollection();              
            }
            else
            { //llamado al metodo SortedListCollection de la clase CollectionExample
              //de nuestro ensamblado
                CollectionExample.SortedListCollection();
                
            }

            Console.ReadKey();

        }
    }
}
