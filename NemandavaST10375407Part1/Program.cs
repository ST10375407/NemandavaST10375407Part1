using NemandavaST10375407Part1;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of ingredients:");
            int ingredientCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of steps:");
            int stepCount = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(ingredientCount, stepCount);

            // Input details for each ingredient
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                recipe.Ingredients[i] = new Ingredient();
                Console.Write("Enter the Name: ");
                recipe.Ingredients[i].Name = Console.ReadLine();
                Console.Write("Enter the Quantity (NB: Quantity must be a number): ");
                recipe.Ingredients[i].Quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter the unit Unit: ");
                recipe.Ingredients[i].Unit = Console.ReadLine();
            }
            // Input description for each step
            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter description for step {i + 1}:");
                recipe.Steps[i] = new Step();
                recipe.Steps[i].Description = Console.ReadLine();
            }

            // Store original quantities
            recipe.StoreOriginalQuantities();

            // Display the recipe details
            Console.WriteLine("\nRecipe Details:");
            recipe.DisplayRecipe();

            // Menu for additional operations
        }
    }
}