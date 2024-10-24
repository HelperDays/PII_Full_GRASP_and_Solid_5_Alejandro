using System.IO;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase FilePrinter implementa la interfaz IPrinter
    /// para proporcionar funcionalidad de impresión de recetas
    /// en un archivo de texto.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        /// <summary>
        /// Imprime la receta en un archivo de texto llamado "Recipe.txt".
        /// Sobrescribe el contenido del archivo si ya existe.
        /// </summary>
        /// <param name="recipe">La receta a imprimir, que debe implementar la interfaz IRecipeText.</param>
        public void PrintRecipe(IRecipeText recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}