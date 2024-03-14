using Microsoft.Maui.Controls;

namespace CarolApp;

public partial class FabPage
{
    public FabPage()
	{
		InitializeComponent();
	}
	private void StartButton_3(object sender, EventArgs args)
	{
	 
	}
	

	private void StartButton_4(object sender, EventArgs args)
	{
	 
	}

    private void Botãovoltar(object sender, EventArgs args)
    {
	 	Application.Current.MainPage = new MainPage();
	}
}