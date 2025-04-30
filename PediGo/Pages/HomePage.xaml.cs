using System.Diagnostics;
using PediGo.Components.Buttons;

namespace PediGo.Pages;

public partial class HomePage : ContentPage
{
    private CancellationTokenSource _cts = new();

    public HomePage()
    {
        InitializeComponent();

        // Inicia a rotina de atualização
        StartAutoUpdateLoop();
    }

    private async void StartAutoUpdateLoop()
    {
        while (!_cts.IsCancellationRequested)
        {
            AtualizarBotoes();
            await Task.Delay(3000); // Aguarda 3 segundos
        }
    }

    private void AtualizarBotoes()
    {
        //Debug.WriteLine("CHAMANDO ATUALIZACAO");
        CommandContainer.Children.Clear();

        int[] commandNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15];

        foreach (var num in commandNumbers)
        {
            var btn = new CommandButton(num.ToString(), OnCounterClicked);
            CommandContainer.Children.Add(btn);
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (sender is CommandButton clickedButton)
        {
            DisplayAlert("Debug", $"Você clicou no botão: {clickedButton.Name}", "OK");
        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _cts.Cancel(); // Para a tarefa quando a página for fechada
    }
}
