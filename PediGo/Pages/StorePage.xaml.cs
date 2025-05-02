using PediGo.ViewModels.StorePage;

namespace PediGo.Pages;

public partial class StorePage : ContentPage
{
	private readonly CategoriesViewModel _categoriesViewModel;
	public StorePage(CategoriesViewModel categoriesViewModel)
	{
		InitializeComponent();
		_categoriesViewModel = categoriesViewModel;
        // Todos os elementos visuais desta página (StorePage) vão usar o CategoriesViewModel como fonte de dados.
        BindingContext = _categoriesViewModel;
        LoadAsyncAction();
    }

    public async void LoadAsyncAction()
    {
        await _categoriesViewModel.LoadAsyncAction();

    }

    //protected override async void OnAppearing()
    //{
    //	base.OnAppearing();
    //	await _categoriesViewModel.LoadAsyncAction();
    //}
}