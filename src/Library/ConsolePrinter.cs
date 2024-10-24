using System;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase ConsolePrinter implementa la interfaz IPrinter
    /// para proporcionar funcionalidad de impresión de recetas
    /// en la consola.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// Imprime la receta en la consola utilizando el método
        /// <see cref="Console.WriteLine"/>. 
        /// </summary>
        /// <param name="recipe">La receta a imprimir, que debe implementar la interfaz IRecipeText.</param>
        public void PrintRecipe(IRecipeText recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}