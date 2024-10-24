namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La interfaz IPrinter define un contrato para imprimir recetas.
    /// Cualquier clase que implemente esta interfaz debe proporcionar
    /// una implementación del método PrintRecipe.
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Imprime la receta proporcionada.
        /// </summary>
        /// <param name="recipe">La receta a imprimir, que debe implementar la interfaz IRecipeText.</param>
        void PrintRecipe(IRecipeText recipe);
    }
}