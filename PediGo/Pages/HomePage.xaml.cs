using System.Diagnostics;

namespace PediGo.Pages;

public partial class HomePage : ContentPage
{
    
    public HomePage()
    {
        InitializeComponent();
        int[] commandNumbers = [1, 2, 3, 4, 5];
        foreach (var num in commandNumbers) {
            var btn = new Button
            {
                Text = num.ToString(),
                WidthRequest = 100,
                HeightRequest = 100,
                BackgroundColor = Colors.AliceBlue,
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(5)
            };

            btn.Clicked += (s, e) =>
            {
                DisplayAlert("Debug", $"Sender: {num}", "OK");
                SemanticScreenReader.Announce(btn.Text);
            };

            CommandContainer.Children.Add(btn);
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        //Console.WriteLine($"Sender: {sender}");
        //Console.WriteLine($"EventArgs: {e}");

        CommandBtn.Text = "aa";
        DisplayAlert("Debug", $"Sender: {sender}", "OK");
        Debug.WriteLine($"Sender: {sender}");


        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
}