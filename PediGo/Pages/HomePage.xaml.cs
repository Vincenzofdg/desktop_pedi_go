using System.Diagnostics;
using PediGo.Components.Buttons;

namespace PediGo.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        int[] commandNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15];

        foreach (var num in commandNumbers) {
            var btn = new CommandButton(num.ToString(), OnCounterClicked);
 
            CommandContainer.Children.Add(btn);
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var clickedButton = sender as CommandButton;
        if (clickedButton != null)
        {
            DisplayAlert("Debug", $"Você clicou no botão: {clickedButton.Name}", "OK");
        }
        else
        {
            DisplayAlert("Erro", "O sender não é um CommandButton", "OK");
        }
    }

}