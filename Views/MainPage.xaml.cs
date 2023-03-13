using MyMauiProject.Views;

namespace MyMauiProject;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage() {
		InitializeComponent();
        Navigation.PushAsync(new LoginPage());
    }

    private async void GoClicked(object sender, EventArgs e) {
        await Navigation.PushAsync(new LoginPage());
    }
}

