using MyMauiProject.Data;
using MyMauiProject.ViewModels;

namespace MyMauiProject.Views;

public partial class WaterSkiingPage : ContentPage
{
    Helper hp = new();
    ShowSportPageViewModel show = new();
    Data.Timer _timer = new();
    public WaterSkiingPage() {
		InitializeComponent();
	}
    private async void GetWaterSkiingDetails(object sender, EventArgs e) {
        Sportdetails.Text = await show.ShowSportDetails("Skiing, water skiing");
    }

    private async void GetWaterSkiiCalorier() {
        Result.Text = await hp.GetSportCalorie("Skiing, water skiing");
    }

    public async void OnStartStop(object sender, EventArgs e) {
        _timer.isRunning = !_timer.isRunning;
        startStopButton.Source = _timer.isRunning ? "pause.png" : "start.png";
        while (_timer.isRunning) {
            _timer.time = _timer.time.Add(TimeSpan.FromSeconds(1));
            SetTime();
            GetWaterSkiiCalorier();
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
        hp.SaveToDb("Skiing, water skiing", Result.Text, timeLabel.Text);
        Stop.Text = await hp.WriteText();
    }
    private async void OnClickedBack(object sender, EventArgs e) {
        await Navigation.PopAsync();
    }
}