//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase Product representa un producto utilizado en la receta.
    /// Contiene la descripción del producto y su costo unitario.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Product.
        /// </summary>
        /// <param name="description">Descripción del producto.</param>
        /// <param name="unitCost">Costo unitario del producto.</param>
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        /// <summary>
        /// Obtiene o establece la descripción del producto.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Obtiene o establece el costo unitario del producto.
        /// </summary>
        public double UnitCost { get; set; }
    }
}