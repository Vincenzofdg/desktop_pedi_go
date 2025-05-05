using CommunityToolkit.Mvvm.ComponentModel;
using PediGo.Data.Actions;
using PediGo.Data.Entities;

namespace PediGo.ViewModels.StorePage
{
    public partial class CategoriesViewModel : ObservableObject
    {
        private readonly CategoryAction _server;
        private bool _isInialized;

        [ObservableProperty]
        private Categories[] _categories = [];

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

            Categories = await _server.GetCategories();
            var listCategories = new List<Categories>
            {
                new Categories
                {
                    Id = 0,
                    Name = "All",
                    Description = "All products",
                    Icon = "all_products.png"
                }
            };

            listCategories.AddRange(Categories);
            Categories = [.. listCategories];

            IsLoading = false;
            
        }
    }
}
