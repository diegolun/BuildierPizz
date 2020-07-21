using System;
namespace BuilderPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----------PIZZAS-----------");
                Console.WriteLine("Especialidad----------------1");
                Console.WriteLine("Arma tu pizza---------------2");
                Console.WriteLine("Terminar--------------------3");
                try
                {
                    Console.WriteLine("Ingresa la opcion deseada: ");
                    int option = int.Parse(Console.ReadLine());
                    if ( option == 3 ) break;
                    CreatePizza create = new CreatePizza();
                    int mass = create.GetMass();
                    int size = create.GetSize();
                    int extras= create.GetExtras();
                    Builder builder =new Builder();
                    if ( option == 1 )
                    {
                        try
                        {
                            int especialidad = create.GetEspecialidad();
                            Director director= new Director();
                            if ( especialidad == 1)
                            {
                                IPizza description= director.CreatePeperoni(builder,mass,size,extras);
                                Console.WriteLine(description.GetDescription());
                            }
                            else if ( especialidad == 2)
                            {
                                IPizza description= director.CreateHawaiana(builder,mass,size,extras);
                                Console.WriteLine(description.GetDescription());
                            }
                            else if ( especialidad == 3)
                            {
                                IPizza description= director.CreateMexicana(builder,mass,size,extras);
                                Console.WriteLine(description.GetDescription());
                            }
                            else if ( especialidad == 4)
                            {
                                IPizza description= director.CreatePollo(builder,mass,size,extras);
                                Console.WriteLine(description.GetDescription());
                            }
                        }
                        catch
                        {
                            Console.WriteLine("No se permiten valores nulos");
                        }
                    }
                    else if ( option == 2 )
                    {
                        try
                        {
                            builder.Reset();
                            if ( mass == 1) builder.SetMass(MassTypes.TRADICIONAL);
                            else if ( mass == 2) builder.SetMass(MassTypes.ROMANA);
                            else if ( mass == 3) builder.SetMass(MassTypes.DEEPDISH);
                            while (true)
                            {   try
                                {
                                    int ingredient = create.AddIngredients();
                                    if ( ingredient == 1) builder.AddIngredient(Ingredients.PEPERONI);
                                    else if ( ingredient == 2) builder.AddIngredient(Ingredients.CARNE);
                                    else if ( ingredient == 3) builder.AddIngredient(Ingredients.VERDURAS);
                                    else if ( ingredient == 4) builder.AddIngredient(Ingredients.POLLO);
                                    else if ( ingredient == 5) builder.AddIngredient(Ingredients.PIÑA);
                                    else if ( ingredient == 6) builder.AddIngredient(Ingredients.JAMON);
                                    else if ( ingredient == 7) builder.AddIngredient(Ingredients.TOCINO);
                                    else if ( ingredient == 8) builder.AddIngredient(Ingredients.SALCHICHA);
                                    else if ( ingredient == 9) builder.AddIngredient(Ingredients.CHORIZO);
                                    else if ( ingredient == 10) builder.AddIngredient(Ingredients.QUESO);
                                    else if ( ingredient == 11) break;
                                }
                                catch
                                {
                                    Console.WriteLine("No puedes agregar ingredientes repetidos");
                                }
                            }
                            if ( size == 1) builder.SetSize(Sizes.FAMILIAR);
                            else if ( size == 2) builder.SetSize(Sizes.INDIVIDUAL);
                            else if  ( size == 3) builder.SetSize(Sizes.NORMAL);
                            if (extras == 1)
                            {
                                builder.SetExtraChess();
                            }
                            else if (extras == 2)
                            {
                                builder.SetSpicySauce();
                            }
                            else if (extras == 3)
                            {
                                builder.SetExtraChess();
                                builder.SetSpicySauce();
                            }
                            IPizza pizaa=builder.GetPizza();
                            Console.WriteLine(pizaa.GetDescription());
                        }
                        catch
                        {
                            Console.WriteLine("No puedes dejar datos nulos");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("No puedes ingresar letras donde van numeros");
                }
            }
        }
    }
}