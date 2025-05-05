using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PediGo.Data.Actions;
using PediGo.Models;

namespace PediGo.ViewModels.StorePage
{
    public partial class CategoriesViewModel : ObservableObject
    {
        private readonly CategoryAction _server;
        private bool _isInialized;

        [ObservableProperty]
        private CategoryModel[] _categories = [];

        // ? => can accept null values
        [ObservableProperty]
        private CategoryModel? _selectedCategory = null;

        [ObservableProperty]
        private bool _isLoading;

        public CategoriesViewModel(CategoryAction databaseServer)
        {
            _server = databaseServer;
        }

        public async ValueTask LoadAsyncAction()
        {
            if (_isInialized) {
                return;
            }
            _isInialized = true;
            IsLoading = true;

            Categories = (await _server.GetCategories())
                .Select(CategoryModel.FromEntity)
                .ToArray();


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

            SelectedCategory = Categories[1];
            Categories[1].IsSelected = true;

            IsLoading = false;
        }

        [RelayCommand]
        private void HandleSelectCategoy(long categoryId)
        {
            if (categoryId == SelectedCategory.Id)
                return;

            var prevSelectedCategory = Categories.First(element => element.IsSelected);
            var newSelectedCategory = Categories.First(element => element.Id == categoryId);

            prevSelectedCategory.IsSelected = false;
            newSelectedCategory.IsSelected = true;

            SelectedCategory = newSelectedCategory;
        }
    }
}
