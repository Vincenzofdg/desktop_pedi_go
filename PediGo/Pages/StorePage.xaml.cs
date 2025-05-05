using System.Diagnostics;
using PediGo.ViewModels.StorePage;

namespace PediGo.Pages;

public partial class StorePage : ContentPage
    {
    private readonly CategoriesViewModel _categoriesViewModel;

    public StorePage(CategoriesViewModel categoriesViewModel)
    {
		InitializeComponent();
        _categoriesViewModel = categoriesViewModel;
        // All visual elements from this screen (StorePage) will use CategoriesViewModel as a source data.
        BindingContext = _categoriesViewModel;
        LoadAsyncAction();
    }

    private async void LoadAsyncAction()
    {
        await _categoriesViewModel.LoadAsyncAction();
    }

    protected override async void OnAppearing()
    {
        Debug.WriteLine("Storage Page");
    }
}