using System.Collections.Generic;
namespace BuilderPizza
{
    public class Pizza : IPizza
    {
        private string description;
        public MassTypes? Mass { get; set; } = null;

        public IList<Ingredients> Ingredients { get; set; } = new List<Ingredients>();
        public Sizes? Size { get; set; } = null;

        public bool? HasExtraChess { get; set; } = null;

        public bool? HasSpicySauce { get; set; } = null;

        public string GetDescription()
        {
            description="Pizza Creada\n";
            description+="MassTypes:    "+Mass+"\n";
            description+="Ingredients: \n";
            foreach (var ingredient in Ingredients)
            {
                description+=ingredient+"\n";
            }
            description+="Size:  "+Size+"\n";
            description+="HasExtraChess:  "+HasExtraChess+"\n";
            description+="HasSpicySauce:  "+HasSpicySauce+"\n";
            return description;
        }
    }
}