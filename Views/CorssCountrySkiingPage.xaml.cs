using MyMauiProject.ViewModels;
using MyMauiProject.Data;

namespace MyMauiProject.Views;

public partial class CorssCountrySkiingPage : ContentPage
{
    Helper hp = new();
    ShowSportPageViewModel show = new();
    Data.Timer _timer = new();
    public CorssCountrySkiingPage() {
        InitializeComponent();
    }

    private async void GetCrossSnowSkiingDetails(object sender, EventArgs e) {
        Sportdetails.Text = await show.ShowSportDetails("Cross country skiing, moderate");
    }

    private async void GetCrossSkiiCalorier() {
        Result.Text = await hp.GetSportCalorie("Cross country skiing, moderate");
    }

    public async void OnStartStop(object sender, EventArgs e) {
        _timer.isRunning = !_timer.isRunning;
        startStopButton.Source = _timer.isRunning ? "pause.png" : "start.png";
        while (_timer.isRunning) {
            _timer.time = _timer.time.Add(TimeSpan.FromSeconds(1));
            SetTime();
            GetCrossSkiiCalorier();
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
    public void SetTime() {
        timeLabel.Text = _timer.SetTimer();
    }
    private async void OnClickedEndSport(object sender, EventArgs e) {
        Stop.Text = $"Din program har avslutat du brände {await _timer.EndSportTime(Result.Text)}";
        await Task.Delay(1000);
    }
    private async void OnClickedSaveToDb(object sender, EventArgs e) {
        await Task.Delay(500);
        hp.SaveToDb("Cross country skiing, moderate", Result.Text, timeLabel.Text);
        Stop.Text = await hp.WriteText();
    }

    private async void OnClickedBack(object sender, EventArgs e) {
        await Navigation.PopAsync();
    }
}