namespace BuilderPizza
{
    public interface IBuilder
    {
        IBuilder SetMass(MassTypes mass);
        IBuilder Reset();
        IBuilder AddIngredient(Ingredients ingredient);
        IBuilder SetSize(Sizes size);
        IBuilder SetExtraChess();
        IBuilder SetSpicySauce();
        IPizza GetPizza();
    }
}