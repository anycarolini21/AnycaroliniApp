using Microsoft.Maui.Controls;

namespace CarolApp;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	

	private void StartButton_2(object sender, EventArgs args)
	{
      framesobre.isVisible= false;
	}
    private void Botão(object sender, EventArgs args)
    {
		if (Application.Current != null)
		 Application.Current.MainPage = new CarolApp();
	}

}
