﻿using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public class ShoppingListController
    {
        private ShoppingListInventory _shoppingInventory;
        private MyPantry _pantry;
        private RecipeInventory _recipeInventory;
        public ShoppingListController(
            ShoppingListInventory shoppingListInventory,
            MyPantry pantry, RecipeInventory recipeInventory)
        {
            _shoppingInventory = shoppingListInventory;
            _pantry = pantry;
            _recipeInventory = recipeInventory;
        }
        public void LaunchShoppingListForm()
        {
            new uiShoppingList(
                LaunchAddShoppingListForm, 
                LaunchShowShoppingListForm,
                AddShoppingListToPantry,
                _shoppingInventory).Show();
        }

        public void LaunchAddShoppingListForm()
        {
            new uiAddShoppingList(_shoppingInventory.CreateShoppingList, _recipeInventory, _shoppingInventory).Show();
        }

        public void LaunchShowShoppingListForm(ShoppingList currentShoppingList)
        {
            new uiShowShoppingList(currentShoppingList).Show();
        }

        public void AddShoppingListToPantry(ShoppingList shoppingList)
        {
            foreach (KeyValuePair<Ingredient, int> ingred in shoppingList.ShoppingListItems)
            {
                _pantry.AddIngredientQuantity(ingred.Key, ingred.Value);
            }
        }

    }
}
