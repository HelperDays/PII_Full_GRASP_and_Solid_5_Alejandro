using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeText recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}