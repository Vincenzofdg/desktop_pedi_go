using PediGo.Data.Entities;

namespace PediGo.Data;

public static class SeedData
{
    public static List<Categories> GetCategories()
    {
        return
        [
            new() { Id = 1, Name = "Beverages", Description = "", Icon = "beverages.png" },
            new() { Id = 2, Name = "Main Course", Description = "", Icon = "main_course.png" },
            new() { Id = 3, Name = "Snacks", Description = "", Icon = "snacks.png" },
            new() { Id = 4, Name = "Desserts", Description = "", Icon = "desserts.png" },
            new() { Id = 5, Name = "Fast Food", Description = "", Icon = "fast_food.png" }
        ];
    }

    public static List<Products> GetProducts()
    {
        return
        [
            new() { Id = 1, Name = "Beer", Description = "Chilled beer", Price = 4.99m, Qtd = 3 },
            new() { Id = 2, Name = "Biryani", Description = "Spicy chicken biryani", Price = 7.99m, Qtd = 8 },
            new() { Id = 3, Name = "Buns", Description = "Freshly baked buns", Price = 2.99m, Qtd = 8},
            new() { Id = 4, Name = "Burger and Fries Combo", Description = "Burger with fries", Price = 5.99m, Qtd = 18 },
            new() { Id = 5, Name = "Cake", Description = "Delicious chocolate cake", Price = 3.99m, Qtd = 2 },
            new() { Id = 6, Name = "Chocolate", Description = "Rich chocolate bar", Price = 1.99m, Qtd = 26 },
            new() { Id = 7, Name = "Cocktail", Description = "Refreshing cocktail", Price = 6.99m, Qtd = 7 },
            new() { Id = 8, Name = "Coffee", Description = "Hot coffee", Price = 1.99m, Qtd = 27 },
            new() { Id = 9, Name = "Cupcake", Description = "Sweet cupcake", Price = 2.49m, Qtd = 1 },
            new() { Id = 10, Name = "Donut", Description = "Glazed donut", Price = 1.49m, Qtd = 98 },
            new() { Id = 11, Name = "Energy Drink", Description = "Energy drink", Price = 2.99m, Qtd = 10 },
        ];
    }

    public static List<ProductCategories> GetProductCategories()
    {
        return
        [
            new() { Id = 1, ProductId = 1, CategoryId = 1},
            new() { Id = 2, ProductId = 2, CategoryId = 5},
            new() { Id = 3, ProductId = 3, CategoryId = 5},
            new() { Id = 4, ProductId = 4, CategoryId = 5},
            new() { Id = 5, ProductId = 5, CategoryId = 4},
            new() { Id = 6, ProductId = 6, CategoryId = 4},
            new() { Id = 7, ProductId = 7, CategoryId = 1},
            new() { Id = 8, ProductId = 8, CategoryId = 1},
            new() { Id = 9, ProductId = 9, CategoryId = 4},
            new() { Id = 10, ProductId = 10, CategoryId = 4},
            new() { Id = 11, ProductId = 11, CategoryId = 1},
        ];
    }
}