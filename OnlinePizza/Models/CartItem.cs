﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizza.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        
        public int Quantity { get; set; }
        public List<CartItemIngredient> CartItemIngredients { get; set; }
        public string DishName { get; set; }
        public int DishPrice { get; set; }
    }
}
