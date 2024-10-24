// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La interfaz IRecipeText define un contrato para obtener el texto a imprimir de una receta.
    /// Implementando esta interfaz, las clases pueden proporcionar una representación textual de la receta.
    /// </summary>
    public interface IRecipeText
    {
        /// <summary>
        /// Obtiene el texto formateado que describe la receta.
        /// </summary>
        /// <returns>Texto que representa la receta.</returns>
        string GetTextToPrint();
    }

    /// <summary>
    /// La clase Recipe representa una receta que contiene un producto final y una lista de pasos.
    /// Implementa la interfaz IRecipeText para poder generar un texto que describa la receta.
    /// </summary>
    public class Recipe : IRecipeText
    {
        /// <summary>
        /// Lista de pasos que componen la receta. Se utiliza IList&lt;BaseStep&gt; para permitir diferentes tipos de pasos.
        /// Este diseño sigue el principio OCP (Open-Closed Principle) al permitir la extensión sin modificar el código existente.
        /// </summary>
        private IList<BaseStep> steps = new List<BaseStep>();

        /// <summary>
        /// Producto final que se obtiene al completar la receta.
        /// </summary>
        public Product FinalProduct { get; set; }

        /// <summary>
        /// Agrega un nuevo paso de trabajo a la receta. Este método es parte del patrón Creator.
        /// </summary>
        /// <param name="input">Producto que se utilizará en el paso.</param>
        /// <param name="quantity">Cantidad del producto a utilizar.</param>
        /// <param name="equipment">Equipo necesario para realizar el paso.</param>
        /// <param name="time">Tiempo necesario para completar el paso.</param>
        public void AddStep(Product input, double quantity, Equipment equipment, int time)
        {
            Step step = new Step(input, quantity, equipment, time);
            this.steps.Add(step);
        }

        /// <summary>
        /// Agrega un nuevo paso de espera a la receta. Este método permite añadir pasos con solo descripción y tiempo,
        /// siguiendo los principios OCP y Creator.
        /// </summary>
        /// <param name="description">Descripción del paso de espera.</param>
        /// <param name="time">Tiempo de espera necesario.</param>
        public void AddStep(string description, int time)
        {
            WaitStep step = new WaitStep(description, time);
            this.steps.Add(step);
        }

        /// <summary>
        /// Elimina un paso específico de la receta.
        /// </summary>
        /// <param name="step">El paso que se desea eliminar de la receta.</param>
        public void RemoveStep(BaseStep step)
        {
            this.steps.Remove(step);
        }

        /// <summary>
        /// Genera un texto formateado que describe la receta, incluyendo todos los pasos y el costo de producción.
        /// Este método cumple con el principio de responsabilidad única (SRP).
        /// </summary>
        /// <returns>Texto que describe los pasos de la receta y su costo total de producción.</returns>
        public string GetTextToPrint()
        {
            string result = $"Receta de {this.FinalProduct.Description}:\n";
            foreach (BaseStep step in this.steps)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            // Agrega el costo total de producción calculado por el método GetProductionCost.
            result = result + $"Costo de producción: {this.GetProductionCost()}";

            return result;
        }

        /// <summary>
        /// Calcula el costo total de producción de la receta, sumando el costo de cada paso.
        /// Este método sigue el principio de Expert al delegar la responsabilidad de calcular el costo a los pasos.
        /// </summary>
        /// <returns>Costo total de producción de la receta.</returns>
        public double GetProductionCost()
        {
            double result = 0;

            foreach (BaseStep step in this.steps)
            {
                result += step.GetStepCost();
            }

            return result;
        }
    }
}
