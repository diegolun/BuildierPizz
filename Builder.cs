using System;
namespace BuilderPizza
{
    public class Builder : IBuilder
    {
        private Pizza pizza;
        public IBuilder AddIngredient(Ingredients ingredient)
        {
            if(!this.pizza.Ingredients.Contains(ingredient))
            {
                this.pizza.Ingredients.Add(ingredient);
                return this;
            }
            else
            {
                throw new Exception();
            }
        }

        public IBuilder SetExtraChess()
        {
            this.pizza.HasExtraChess = true;
            return this;
        }

        public IBuilder SetMass(MassTypes mass)
        {
            this.pizza.Mass = mass;
            return this;
        }

        public IPizza GetPizza()
        {
            if (this.pizza.Mass != null && this.pizza.Size != null && this.pizza.Ingredients.Count!=0)
            {
                if (this.pizza.HasExtraChess == null)
                {
                    this.pizza.HasExtraChess = false;
                }
                if (this.pizza.HasSpicySauce == null)
                {
                    this.pizza.HasSpicySauce = false;
                }
                return this.pizza;
            }
            else
            {
                throw new Exception();
            }
        }

        public IBuilder SetSize(Sizes size)
        {
            this.pizza.Size = size;
            return this;
        }

        public IBuilder SetSpicySauce()
        {
            this.pizza.HasSpicySauce=true;
            return this;
        }

        public IBuilder Reset()
        {
            this.pizza = new Pizza();
            return this;
        }
    }
}
