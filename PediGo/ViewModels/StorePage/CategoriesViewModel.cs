using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PediGo.Data.Actions;
using PediGo.Data.Entities;
using PediGo.Models;

namespace PediGo.ViewModels.StorePage
{
    public partial class CategoriesViewModel : ObservableObject
    {
        private readonly CategoryAction _categoryServer;
        private readonly ProductAction _productServer;
        private readonly ProductCategoryAction _categoryProductServer;

        private bool _isInialized;

        [ObservableProperty]
        private CategoryModel[] _categories = [];

        [ObservableProperty]
        private Products[] _products = [];

        // ? => can accept null values
        [ObservableProperty]
        private CategoryModel? _selectedCategory = null;

        [ObservableProperty]
        private bool _isLoading;

        public CategoriesViewModel(CategoryAction categoryServer, ProductCategoryAction categoryProductServer, ProductAction productServer)
        {
            _categoryServer = categoryServer;
            _categoryProductServer = categoryProductServer;
            _productServer = productServer;
        }

        public async ValueTask LoadAsyncAction()
        {
            if (_isInialized) {
                return;
            }
            _isInialized = true;
            IsLoading = true;

            Categories = (await _categoryServer.GetCategories())
                .Select(CategoryModel.FromEntity)
                .ToArray();

            Products = await FetchProductsFromCategory(0);

            var listCategories = new List<CategoryModel>
            {
                new() {
                    Id = 0,
                    Name = "All",
                    Description = "All products",
                    Icon = "all_products.png"
                }
            };

            listCategories.AddRange(Categories);
            Categories = [.. listCategories];

            SelectedCategory = Categories[0];
            Categories[0].IsSelected = true;

            IsLoading = false;
        }

        [RelayCommand]
        private async void HandleSelectCategoy(long categoryId)
        {
            // ? => can accept null values
            if (categoryId == SelectedCategory?.Id)
                return;

            var targetProducts = await FetchProductsFromCategory(categoryId);

            var prevSelectedCategory = Categories.First(element => element.IsSelected);
            var newSelectedCategory = Categories.First(element => element.Id == categoryId);

            prevSelectedCategory.IsSelected = false;
            newSelectedCategory.IsSelected = true;

            SelectedCategory = newSelectedCategory;
            Products = targetProducts;
        }
        private async Task<Products[]> FetchProductsFromCategory(long categoryId)
        {
            Products[] allProducts = null;

            if (categoryId == 0)
            {
                allProducts = await _productServer.GetProducts();
            }
            else
            {
                allProducts = await _categoryProductServer.GetProductCategoriesById(categoryId);
            }

            return allProducts;
        }
    }
}
