using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using PediGo.Data.Actions;
using PediGo.Data.Entities;
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
        private CategoriesViewModel? CategorySelected = null;

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
                new CategoryModel
                {
                    Id = 0,
                    Name = "All",
                    Description = "All products",
                    Icon = "all_products.png"
                }
            };

            listCategories.AddRange(Categories);
            Categories = [.. listCategories];


            Debug.WriteLine(listCategories);

            //CategorySelected = Categories[0];

            IsLoading = false;
            
        }
    }
}
