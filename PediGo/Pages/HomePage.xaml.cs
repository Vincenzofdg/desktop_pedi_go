using System.Diagnostics;

namespace PediGo.Pages;

public partial class HomePage : ContentPage
{
	int count = 0;
	public HomePage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        //Console.WriteLine($"Sender: {sender}");
        //Console.WriteLine($"EventArgs: {e}");

        DisplayAlert("Debug", $"Sender: {sender}", "OK");
        Debug.WriteLine($"Sender: {sender}");


        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}