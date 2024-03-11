using Microsoft.Maui.Controls;

namespace CarolApp;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void StartButton_1(object sender, EventArgs args)
	{
      Application.Current.MainPage = new CarolPage();
	}
	

	private void StartButton_2(object sender, EventArgs args)
	{
      sobre.IsVisible= true;
	}

    private void Botãovoltar(object sender, EventArgs args)
    {
	 sobre.IsVisible= false;
	}

}
