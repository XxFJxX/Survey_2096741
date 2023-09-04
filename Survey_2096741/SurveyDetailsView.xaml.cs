namespace Survey_2096741;

public partial class SurveyDetailsView : ContentPage
{
    private readonly string[] teams =
    {
"Alianza Lima",
 "América",
"Boca Juniors",
"Caracas FC",
"Colo-Colo",
"Peñarol",
"Real Madrid",
"Saprissa"
    };

    public SurveyDetailsView()
	{
		InitializeComponent();
	}

    private async void FavoriteTeamButton_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTEamTitle, null, null, teams); if (!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }
    }

    private async void OkButton_Clicked(object sender, EventArgs e)
    {
        //Evaluamos si los datos están completos
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }
        //Creamos el nuevo objeto de tipo survey
        var newSurvey = new Survey()
        {
            Name = NameEntry.Text,
            Birthdate = Birthdatepicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text

        };
        //Publicamos el mensaje con el objeto de encuesta como argumento
        MessagingCenter.Send((ContentPage)this,
        Messages.NewSurveyComplete, newSurvey);

        //Removemos la página de la pila de navegación para regresar inmediatamente
        await Navigation.PopAsync();
    }
}