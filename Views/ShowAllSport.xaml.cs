namespace MyMauiProject.Views;

public partial class ShowAllSport : ContentPage
{
	public ShowAllSport() {
		InitializeComponent();
	}
    private async void OnClickedToWaterSkiiPage(object sender, EventArgs e) {
        await Navigation.PushAsync(new WaterSkiingPage());
    }

    private async void OnClickedToSnowSkiiPage(object sender, EventArgs e) {
        await Navigation.PushAsync(new DownhillSnowSkiingPage());
    }

    private async void OnClickedToCrossCountryskiiPage(object sender, EventArgs e) {
        await Navigation.PushAsync(new CorssCountrySkiingPage());
    }

    private async void OnClickedBack(object sender, EventArgs e) {
        await Navigation.PopAsync();
    }
}