using PediGo.Data.Actions;

namespace PediGo.Pages;

public partial class StorePage : ContentPage
{
    private readonly ProductCategoryAction _productCategoryAction;
    public StorePage()
	{
		InitializeComponent();
		_productCategoryAction = new ProductCategoryAction();

		LoadAsyncAction();
	}

	private async void LoadAsyncAction()
	{
		try
		{
            long mockedId = 1;

            var productCategories = await _productCategoryAction.GetProductCategoriesById(mockedId);
            var TEST = await _productCategoryAction.GetProductCategories();

            await DisplayAlert("Erro", $"Erro ao carregar os dados: {productCategories}", "OK");
        }
		catch (Exception ex) {
            await DisplayAlert("Erro", $"Erro ao carregar os dados: {ex.Message}", "OK");
        }
	}
}