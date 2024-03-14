using Microsoft.Maui.Controls;

namespace CarolApp;

public partial class AnyPage
{
    public AnyPage()
	{
		InitializeComponent();
    }
    private void StartButton_5(object sender, EventArgs args)
	{
	 Application.Current.MainPage = new MainPage();
	}
	

	private void StartButton_6(object sender, EventArgs args)
	{
	   Application.Current.MainPage = new MainPage();
	}

    private void Botãovoltar(object sender, EventArgs args)
    {
	 	Application.Current.MainPage = new MainPage();
	}
}