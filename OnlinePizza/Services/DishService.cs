﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlinePizza.Data;
using OnlinePizza.Models;

namespace OnlinePizza.Services
{
    public class DishService
    {
        private readonly ApplicationDbContext _context;

        public DishService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Dish> GetAllDishes()
        {
            var allDishes = _context.Dishes.ToList();
            return allDishes;
        }

        public List<Category> GetAllCategories()
        {
            var allCategories = _context.Categories.ToList();

            return allCategories;
        }

        public List<Models.Ingredient> GetIngredients()
        {
            return _context.Ingredients.ToList();
        }

        public string AllIngredientsForDish(int id)
        {
            var ingredients = _context.DishIngredients.Include(x => x.Ingredient)
                .Where(x => x.DishId == id && x.Enabled);

            string allIngredients = "";
            foreach (var ingredient in ingredients)
            {
                allIngredients += ingredient.Ingredient.Name + " ";
            }

            return allIngredients;
        }

       
    }
}
