using CommunityToolkit.Mvvm.ComponentModel;
using PediGo.Data;
using PediGo.Data.Actions;

namespace PediGo.ViewModels.StorePage
{
    public partial class CategoriesViewModel : ObservableObject
    {
        private readonly CategoryAction _server;
        private bool _isInialized;
        [ObservableProperty]
        public Categories[] _categories = [];
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

            IsLoading = false;
            
        }
    }
}
