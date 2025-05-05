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
            new() { Id = 1, Name = "Beer", Description = "Chilled beer", Price = 4.99m, ImgUrl = "https://cdn.pixabay.com/photo/2014/08/19/22/58/beer-422138_1280.jpg", Qtd = 3 },
            new() { Id = 2, Name = "Biryani", Description = "Spicy chicken biryani", Price = 7.99m, ImgUrl = "https://cdn.tasteatlas.com/images/dishes/cc3cca86c55443c7ab4e86797b08b846.jpg?mw=2000", Qtd = 8 },
            new() { Id = 3, Name = "Buns", Description = "Freshly baked buns", Price = 2.99m, ImgUrl = "https://veenaazmanov.com/wp-content/uploads/2020/06/Homemade-Hamburger-Buns-Hokkaido-Buns2-500x500.jpg", Qtd = 8},
            new() { Id = 4, Name = "Burger and Fries Combo", Description = "Burger with fries", Price = 5.99m, ImgUrl = "https://as2.ftcdn.net/v2/jpg/00/92/04/47/1000_F_92044757_K6rFzZN9mBNu7w8aJFNwEAhzkV0tefUo.jpg", Qtd = 18 },
            new() { Id = 5, Name = "Cake", Description = "Delicious chocolate cake", Price = 3.99m, ImgUrl = "https://th.bing.com/th/id/OIP.7bEK8zNR1hmj63EuvmzdYgHaLH?cb=iwc1&rs=1&pid=ImgDetMain", Qtd = 2 },
            new() { Id = 6, Name = "Chocolate", Description = "Rich chocolate bar", Price = 1.99m, ImgUrl = "https://th.bing.com/th/id/OIP.4f8QdnjErguik11icY2AxQHaFB?cb=iwc1&rs=1&pid=ImgDetMain", Qtd = 26 },
            new() { Id = 7, Name = "Cocktail", Description = "Refreshing cocktail", Price = 6.99m, ImgUrl = "https://th.bing.com/th/id/OIP.wcVdbAdfq4BA0U-0cED6MwHaFN?cb=iwc1&rs=1&pid=ImgDetMain", Qtd = 7 },
            new() { Id = 8, Name = "Coffee", Description = "Hot coffee", Price = 1.99m, ImgUrl = "https://th.bing.com/th/id/OIP.x1vJJny0erg4CvicFQws4AHaEo?cb=iwc1&rs=1&pid=ImgDetMain", Qtd = 27 },
            new() { Id = 9, Name = "Cupcake", Description = "Sweet cupcake", Price = 2.49m, ImgUrl = "https://th.bing.com/th/id/OIP.BQGpMOnaBK_FJr_XWeJi8QHaE7?cb=iwc1&rs=1&pid=ImgDetMain", Qtd = 1 },
            new() { Id = 10, Name = "Donut", Description = "Glazed donut", Price = 1.49m, ImgUrl = "https://th.bing.com/th/id/OIP.waS2qhick9pINmxkuIuIGQHaHa?cb=iwc1&rs=1&pid=ImgDetMain", Qtd = 98 },
            new() { Id = 11, Name = "Energy Drink", Description = "Energy drink", Price = 2.99m, ImgUrl = "https://media.istockphoto.com/photos/frosted-energy-drink-can-picture-id1167739806?k=20&m=1167739806&s=612x612&w=0&h=4CMdu9bwsq8k0HctK99EPET1dDcersyHH9ajioDS7oA=", Qtd = 10 },
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