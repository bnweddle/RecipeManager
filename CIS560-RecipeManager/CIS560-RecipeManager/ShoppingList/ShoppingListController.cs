﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public class ShoppingListController
    {
        private IQuery QueryRepository;

        public ShoppingListController(IQuery query)
        {
            QueryRepository = query;
        }

        public void LaunchShoppingListForm()
        {
            //not implemented yet
        }
    }
}