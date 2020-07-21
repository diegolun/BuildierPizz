using System;
namespace BuilderPizza
{
    public class CreatePizza
    {
        public int GetExtras()
        {
            int extra;
            Console.WriteLine("-----------Extras--------");
            Console.WriteLine("Extra Chess-------------1");
            Console.WriteLine("Spicy Sauce-------------2");
            Console.WriteLine("Ambos-------------------3");
            Console.WriteLine("Ninguno-----------------4");
            try
            {
                Console.WriteLine("Ingresa extra: ");
                int option = int.Parse(Console.ReadLine());
                if ( option == 1 ) extra = 1;
                else if ( option == 2 ) extra = 2;
                else if ( option == 3 ) extra = 3;
                else if ( option == 4 ) extra = 4;
                else extra = 0;
            }
            catch
            {
                throw;
            }

            return extra;
        }
        public int GetMass()
        {
            int massType;
            Console.WriteLine("-----------Mass-----------");
            Console.WriteLine("Tradicional-------------1");
            Console.WriteLine("Romana------------------2");
            Console.WriteLine("Deepdish----------------3");
            try
            {
                Console.WriteLine("Ingresa el tipo de masa: ");
                int option = int.Parse(Console.ReadLine());
                if ( option == 1 ) massType = 1;
                else if ( option == 2 ) massType = 2;
                else if ( option == 3 ) massType = 3;
                else massType = 0;
            }
            catch
            {
                throw;
            }

            return massType;
        }
        public int GetSize()
        {
            int size;
            Console.WriteLine("-----------Size-----------");
            Console.WriteLine("Familiar-----------------1");
            Console.WriteLine("Individual---------------2");
            Console.WriteLine("Normal-------------------3");
            try
            {
                Console.WriteLine("Ingresa el tamaño: ");
                int option = int.Parse(Console.ReadLine());
                if ( option == 1 ) size = 1;
                else if ( option == 2 ) size = 2;
                else if ( option == 3 ) size = 3;
                else size = 0;
            }
            catch
            {
                throw;
            }
            return size;
        }
        public int GetEspecialidad()
        {
            int especialidad;
            Console.WriteLine("-----------Especialidades-----------");
            Console.WriteLine("Peperoni----------------1");
            Console.WriteLine("Hawaiana----------------2");
            Console.WriteLine("Mexicana----------------3");
            Console.WriteLine("Pollo-------------------4");
            try
            {
                Console.WriteLine("Ingresa la opcion deseada: ");
                int option = int.Parse(Console.ReadLine());
                if ( option == 1 ) especialidad = 1;
                else if ( option == 2 ) especialidad = 2;
                else if ( option == 3 ) especialidad = 3;
                else if ( option == 4 ) especialidad = 4;
                else especialidad = 0;
            }
            catch
            {
                throw;
            }
            return especialidad;
        }
        public int AddIngredients()
        {
            int ingredient;
            Console.WriteLine("-----------Ingredientes------------");
            Console.WriteLine("Peperoni--------------------------1");
            Console.WriteLine("Carne-----------------------------2");
            Console.WriteLine("Verduras--------------------------3");
            Console.WriteLine("Pollo-----------------------------4");
            Console.WriteLine("Piña------------------------------5");
            Console.WriteLine("Jamon-----------------------------6");
            Console.WriteLine("Tocino----------------------------7");
            Console.WriteLine("Salchicha-------------------------8");
            Console.WriteLine("Chorizo---------------------------9");
            Console.WriteLine("Queso----------------------------10");
            Console.WriteLine("Terminar de agregar--------------11");
            try
            {
                Console.WriteLine("Ingresa la opcion deseada: ");
                int option = int.Parse(Console.ReadLine());
                if ( option == 1 ) ingredient = 1;
                else if ( option == 2 ) ingredient = 2;
                else if ( option == 3 ) ingredient = 3;
                else if ( option == 4 ) ingredient = 4;
                else if ( option == 5 ) ingredient = 5;
                else if ( option == 6 ) ingredient = 6;
                else if ( option == 7 ) ingredient = 7;
                else if ( option == 8 ) ingredient = 8;
                else if ( option == 9 ) ingredient = 9;
                else if ( option == 10 ) ingredient = 10;
                else if ( option == 11 ) ingredient = 11;
                else ingredient = 0;
            }
            catch
            {
                throw;
            }
            return ingredient;
        }
    }
}