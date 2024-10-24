//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase Equipment representa un equipo utilizado en la receta.
    /// Contiene la descripción del equipo y su costo por hora de uso.
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Equipment.
        /// </summary>
        /// <param name="description">Descripción del equipo.</param>
        /// <param name="hourlyCost">Costo por hora del uso del equipo.</param>
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        /// <summary>
        /// Obtiene o establece la descripción del equipo.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Obtiene o establece el costo por hora del uso del equipo.
        /// </summary>
        public double HourlyCost { get; set; }
    }
}