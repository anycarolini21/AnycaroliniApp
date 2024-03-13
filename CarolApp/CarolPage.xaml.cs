using Microsoft.Maui.Controls;

namespace CarolApp;

public partial class CarolPage
{
    public CarolPage()
	{
		InitializeComponent();
	}
	private void StartButton_3(object sender, EventArgs args)
	{
	
	}
	

	private void StartButton_4(object sender, EventArgs args)
	{
	   Application.Current.MainPage = new MainPage();
	}

    private void Botãovoltar(object sender, EventArgs args)
    {
	 	Application.Current.MainPage = new MainPage();
	}
}
