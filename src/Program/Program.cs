//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// La clase Program es el punto de entrada de la aplicación.
    /// Se encarga de inicializar los catálogos de productos y equipos,
    /// crear una receta, y imprimirla utilizando diferentes implementaciones de IPrinter.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Catálogo de productos disponible en la aplicación.
        /// </summary>
        private static List<Product> productCatalog = new List<Product>();

        /// <summary>
        /// Catálogo de equipos disponible en la aplicación.
        /// </summary>
        private static List<Equipment> equipmentCatalog = new List<Equipment>();

        /// <summary>
        /// Método principal que inicia la ejecución de la aplicación.
        /// Se encarga de poblar los catálogos, crear una receta,
        /// y utilizar impresoras para mostrar la receta.
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos (no se utilizan).</param>
        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = GetProduct("Café con leche");
            recipe.AddStep(GetProduct("Café"), 100, GetEquipment("Cafetera"), 120);
            recipe.AddStep(GetProduct("Leche"), 200, GetEquipment("Hervidor"), 60);
            recipe.AddStep("Dejar enfriar", 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        /// <summary>
        /// Método que pobla los catálogos de productos y equipos
        /// con algunos datos de ejemplo.
        /// </summary>
        private static void PopulateCatalogs()
        {
            AddProductToCatalog("Café", 100);
            AddProductToCatalog("Leche", 200);
            AddProductToCatalog("Café con leche", 300);

            AddEquipmentToCatalog("Cafetera", 1000);
            AddEquipmentToCatalog("Hervidor", 2000);
        }

        /// <summary>
        /// Añade un nuevo producto al catálogo.
        /// </summary>
        /// <param name="description">Descripción del producto.</param>
        /// <param name="unitCost">Costo unitario del producto.</param>
        private static void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        /// <summary>
        /// Añade un nuevo equipo al catálogo.
        /// </summary>
        /// <param name="description">Descripción del equipo.</param>
        /// <param name="hourlyCost">Costo por hora del equipo.</param>
        private static void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
        }

        /// <summary>
        /// Obtiene un producto del catálogo en la posición especificada.
        /// </summary>
        /// <param name="index">Índice del producto en el catálogo.</param>
        /// <returns>El producto correspondiente al índice dado.</returns>
        private static Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        /// <summary>
        /// Obtiene un equipo del catálogo en la posición especificada.
        /// </summary>
        /// <param name="index">Índice del equipo en el catálogo.</param>
        /// <returns>El equipo correspondiente al índice dado.</returns>
        private static Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        /// <summary>
        /// Busca un producto en el catálogo por su descripción.
        /// </summary>
        /// <param name="description">Descripción del producto a buscar.</param>
        /// <returns>El producto encontrado o null si no existe.</returns>
        private static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        /// <summary>
        /// Busca un equipo en el catálogo por su descripción.
        /// </summary>
        /// <param name="description">Descripción del equipo a buscar.</param>
        /// <returns>El equipo encontrado o null si no existe.</returns>
        private static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}