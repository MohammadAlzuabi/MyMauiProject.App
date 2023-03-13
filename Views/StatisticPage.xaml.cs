using MongoDB.Driver;
using MyMauiProject.Data;
using MyMauiProject.Models;

namespace MyMauiProject.Views;

public partial class StatisticPage : ContentPage
{
	public StatisticPage() {
		InitializeComponent();
	}
    private async void OnClickedShowAllSavedInfo(object sender, EventArgs e) {
        List<Statistic> statistic = await Database.GetMyDbCollection().AsQueryable().ToListAsync();
        await Task.Delay(1000);
        foreach (Statistic s in statistic) {
            Fetched.Text += $"Datum: {s.Date.ToString("yyyy/MM/dd")}\nSportNamn: {s.SportName}\n{s.Calorier}\nTid: {s.Timer}\n=========================\n ";
        }
    }

    private async void OnClickedBack(object sender, EventArgs e) {
        await Navigation.PopAsync();
    }
}