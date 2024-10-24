//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase Step representa un paso específico en una receta.
    /// Extiende la clase BaseStep y encapsula los detalles de un paso
    /// de trabajo, incluyendo el producto, la cantidad, el equipo 
    /// utilizado y el tiempo requerido.
    /// Esta clase ha sido modificada para cumplir con el principio 
    /// OCP (Open-Closed Principle).
    /// </summary>
    public class Step : BaseStep
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Step.
        /// </summary>
        /// <param name="input">El producto utilizado en el paso.</param>
        /// <param name="quantity">La cantidad del producto a utilizar.</param>
        /// <param name="equipment">El equipo necesario para el paso.</param>
        /// <param name="time">El tiempo requerido para completar el paso.</param>
        public Step(Product input, double quantity, Equipment equipment, int time)
            : base(time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Equipment = equipment;
        }

        /// <summary>
        /// Obtiene o establece el producto que se utiliza en este paso.
        /// </summary>
        public Product Input { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad del producto a utilizar.
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// Obtiene o establece el equipo necesario para este paso.
        /// </summary>
        public Equipment Equipment { get; set; }

        /// <summary>
        /// Calcula el costo total de este paso, sumando el costo del 
        /// producto y el costo del uso del equipo.
        /// Este método ha sido agregado siguiendo el principio de Expert.
        /// </summary>
        /// <returns>Costo total del paso.</returns>
        public override double GetStepCost()
        {
            return
                (this.Input.UnitCost * this.Quantity) +
                (this.Equipment.HourlyCost * this.Time);
        }

        /// <summary>
        /// Genera un texto formateado que describe el paso, incluyendo
        /// la cantidad, el producto, el equipo utilizado y el tiempo
        /// requerido. Este método cumple con el principio de responsabilidad 
        /// única (SRP).
        /// </summary>
        /// <returns>Texto que representa el paso de la receta.</returns>
        public override string GetTextToPrint()
        {
            return $"{this.Quantity} de '{this.Input.Description}' " +
                $"usando '{this.Equipment.Description}' durante {this.Time}";
        }
    }
}
