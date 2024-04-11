using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemandavaST10375407Part1
{
    internal class Recipe
    {
        public Ingredient[] Ingredients { get; set; }    // Array to store ingredients
        public Step[] Steps { get; set; }    // Array to store steps
        private double[] originalQuantities;  // Array to store original quantities

        // Constructor to initialize the recipe with specified counts of ingredients and steps
        public Recipe(int ingredientCount, int stepCount)
        {
            Ingredients = new Ingredient[ingredientCount];
            Steps = new Step[stepCount];
            originalQuantities = new double[ingredientCount];
        }

        // Method to display the entire recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Console.WriteLine($"{Ingredients[i].Quantity} {Ingredients[i].Unit} {Ingredients[i].Name}");
            }
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        
    }
}

