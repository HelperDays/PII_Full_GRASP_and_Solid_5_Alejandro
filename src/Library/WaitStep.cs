//-------------------------------------------------------------------------------
// <copyright file="WaitStep.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase WaitStep representa un paso de espera en una receta.
    /// Extiende la clase BaseStep y encapsula la lógica de un paso
    /// que no implica un uso activo de recursos, sino simplemente 
    /// un periodo de espera.
    /// Esta clase ha sido añadida para cumplir con el principio OCP 
    /// (Open-Closed Principle).
    /// </summary>
    public class WaitStep : BaseStep
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase WaitStep.
        /// </summary>
        /// <param name="description">Descripción del paso de espera.</param>
        /// <param name="time">Tiempo de espera necesario.</param>
        public WaitStep(string description, int time)
            : base(time)
        {
            this.Description = description;
        }

        /// <summary>
        /// Obtiene o establece la descripción del paso de espera.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Calcula el costo del paso de espera. En este caso, el costo
        /// es igual al tiempo de espera, ya que no se incurre en costos 
        /// adicionales.
        /// </summary>
        /// <returns>Costo del paso de espera.</returns>
        public override double GetStepCost()
        {
            return this.Time;
        }

        /// <summary>
        /// Genera un texto formateado que describe el paso de espera,
        /// incluyendo la descripción y el tiempo de espera. 
        /// </summary>
        /// <returns>Texto que representa el paso de espera.</returns>
        public override string GetTextToPrint()
        {
            return $"Esperando '{this.Description}' durante {this.Time}";
        }
    }
}
