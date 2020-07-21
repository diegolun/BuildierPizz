using System.Collections.Generic;
namespace BuilderPizza
{
    public interface IPizza
    {
        MassTypes? Mass { get; }
        IList<Ingredients> Ingredients { get; }
        Sizes? Size { get;}
        bool? HasExtraChess { get; }
        bool? HasSpicySauce { get; }
        string GetDescription();
    }
}