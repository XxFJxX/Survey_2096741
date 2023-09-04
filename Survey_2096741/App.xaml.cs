namespace Survey_2096741;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new SurveysView());
	}
}
