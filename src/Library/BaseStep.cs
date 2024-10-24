//-------------------------------------------------------------------------------
// <copyright file="BaseStep.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase abstracta BaseStep representa un paso base en una receta.
    /// Esta clase sirve como base para pasos específicos, como Step y WaitStep.
    /// Se ha agregado para cumplir con el principio OCP (Open-Closed Principle).
    /// </summary>
    public abstract class BaseStep
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase BaseStep.
        /// </summary>
        /// <param name="time">Tiempo requerido para completar este paso.</param>
        public BaseStep(int time)
        {
            this.Time = time;
        }

        /// <summary>
        /// Obtiene o establece el tiempo requerido para este paso.
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// Método abstracto que calcula el costo del paso.
        /// Este método debe ser implementado por las clases derivadas.
        /// </summary>
        /// <returns>Costo del paso.</returns>
        public abstract double GetStepCost();

        /// <summary>
        /// Método abstracto que genera un texto formateado que describe el paso.
        /// Este método debe ser implementado por las clases derivadas.
        /// </summary>
        /// <returns>Texto que representa el paso.</returns>
        public abstract string GetTextToPrint();
    }
}