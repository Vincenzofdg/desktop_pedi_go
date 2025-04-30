using System.Diagnostics;

namespace PediGo.Components.Buttons;

public partial class CommandButton : ContentView
{
    public string Name { get; set; }
    public EventHandler OnClick { get; set; }

    public CommandButton(string buttonName, EventHandler btnClickAction)
	{
		InitializeComponent();
        this.Name = buttonName;
        this.OnClick = btnClickAction;

        CommandBtn.Text = Name;
        CommandBtn.Clicked += (s, e) => OnClick?.Invoke(this, e);
    }
}