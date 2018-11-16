﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.RecipeManager
{
    public class AddRecipeViewModel
    {
        public BindingList<Ingredient> TotalIngredients { get; }

        public BindingList<Ingredient> RecipeIngredients { get; }

        public AddRecipeViewModel(ICollection<Ingredient> totalIngredients, IDictionary<Ingredient, int> measuredIngredients)
        {
            TotalIngredients = new BindingList<Ingredient>();
            RecipeIngredients = new BindingList<Ingredient>();

            foreach (Ingredient i in totalIngredients)
            {
                TotalIngredients.Add(i);
            }

            foreach(var kvp in measuredIngredients)
            {
                RecipeIngredients.Add(kvp.Key);
            }
        }
    }
}
