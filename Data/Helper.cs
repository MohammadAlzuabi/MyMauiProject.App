using MyMauiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiProject.Data
{
    internal class Helper
    {
        private double _count = 0;
        private double _calorie = 0;
        private double _result = 0;
        private double _secound = 60;

        public async Task<string> GetSportCalorie(string sportName)
        {  // Metoden för att räkna ut kalorier per secounden beroende på sporten 
            var allSport = await ViewModels.SportPageViewModel.GetSportAsync();
            foreach (var sport in allSport.Where(x => x.Name == sportName))
            {
                if (sport != null)
                {
                    try
                    {
                        _calorie = _count += (sport.CaloriesPerHour / sport.Minute);
                        _result = +_calorie / _secound;
                        sportName = $"{Math.Round(_result, 2)} kalorier".ToString();
                    }
                    catch (Exception ex)
                    {
                        sportName = ex.Message;
                    }
                }
            }
            return sportName;
        }
        public async void SaveToDb(string sportName, string calorieResult, string timer)
        { // Metoden för att spara till databasen
            Statistic statiskt = new Statistic();
            var sport = await ViewModels.SportPageViewModel.GetSportAsync();
            foreach (var c in sport.Where(x => x.Name == sportName))
            {
                statiskt = new() { Date = DateTime.Today, SportName = c.Name, Calorier = calorieResult, Timer = timer };
                await Database.GetMyDbCollection().InsertOneAsync(statiskt);
            }
        }

        public async Task<string> WriteText()
        {
            await Task.Delay(30);
            string text = $"Värderna har sparat";
            return text;
        }
    }
}
