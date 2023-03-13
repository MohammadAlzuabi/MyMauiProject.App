namespace MyMauiProject.Views;

public partial class StartPage : ContentPage
{
	public StartPage() {
		InitializeComponent();
	}
    private async void OnSportPageClicked(object sender, EventArgs e) {
        await Navigation.PushAsync(new ShowAllSport());
    }

    private async void OnSavedSportFromDb(object sender, EventArgs e) {
        await Navigation.PushAsync(new StatisticPage());
    }
}