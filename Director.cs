namespace BuilderPizza
{
    public class Director
    {
        public IPizza CreatePeperoni(Builder builder,int mass,int size, int extras)
        {
            builder.Reset();
            if ( mass == 1) builder.SetMass(MassTypes.TRADICIONAL);
            else if ( mass == 2)  builder.SetMass(MassTypes.ROMANA);
            else if ( mass == 3) builder.SetMass(MassTypes.DEEPDISH);
            builder.AddIngredient(Ingredients.PEPERONI);
            builder.AddIngredient(Ingredients.QUESO);
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
            return builder.GetPizza();
        }
        public IPizza CreateHawaiana(Builder builder,int mass,int size, int extras)
        {
            builder.Reset();
            if ( mass == 1) builder.SetMass(MassTypes.TRADICIONAL);
            else if ( mass == 2)  builder.SetMass(MassTypes.ROMANA);
            else if ( mass == 3) builder.SetMass(MassTypes.DEEPDISH);
            builder.AddIngredient(Ingredients.JAMON);
            builder.AddIngredient(Ingredients.PIÑA);
            builder.AddIngredient(Ingredients.QUESO);
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
            return builder.GetPizza();
        }
        public IPizza CreateMexicana(Builder builder,int mass,int size, int extras)
        {
            builder.Reset();
            if ( mass == 1) builder.SetMass(MassTypes.TRADICIONAL);
            else if ( mass == 2)  builder.SetMass(MassTypes.ROMANA);
            else if ( mass == 3) builder.SetMass(MassTypes.DEEPDISH);
            builder.AddIngredient(Ingredients.CARNE);
            builder.AddIngredient(Ingredients.VERDURAS);
            builder.AddIngredient(Ingredients.CHORIZO);
            builder.AddIngredient(Ingredients.QUESO);
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
            return builder.GetPizza();
        }
        public IPizza CreatePollo(Builder builder,int mass,int size, int extras)
        {
            builder.Reset();
            if ( mass == 1) builder.SetMass(MassTypes.TRADICIONAL);
            else if ( mass == 2)  builder.SetMass(MassTypes.ROMANA);
            else if ( mass == 3) builder.SetMass(MassTypes.DEEPDISH);
            builder.AddIngredient(Ingredients.POLLO);
            builder.AddIngredient(Ingredients.VERDURAS);
            builder.AddIngredient(Ingredients.QUESO);
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
            return builder.GetPizza();
        }
    }
}