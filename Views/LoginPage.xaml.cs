using MyMauiProject.Models;
using MyMauiProject.Services;

namespace MyMauiProject.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage() { 
		InitializeComponent();
	}

    private async void LoginClicked(object sender, EventArgs e) {
        var loginUser = new LoginService();
        if (loginUser.Login()) {
            UserInfo.UserName = txtUserName.Text;
            UserInfo.Password = txtPassword.Text;
            if (UserInfo.UserName != null && UserInfo.Password != null) {
                await Navigation.PushAsync(new StartPage());
            } else {
                await DisplayAlert("Varning", "Fel inmatat", "Prova igen!!");
            }
        }
    }
}