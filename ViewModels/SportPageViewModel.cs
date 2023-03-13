using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyMauiProject.ViewModels
{
    internal class SportPageViewModel {
        public static async Task<List<Models.Sport>> GetSportAsync() {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.api-ninjas.com/");
            client.DefaultRequestHeaders.Add("X-Api-Key", "UZ8FDce3GlAAzzNyxhSJ1w==3dwUJw6pRAL3xvDa");
            List<Models.Sport> sport = null;
            HttpResponseMessage response = await client.GetAsync("v1/caloriesburned?activity=ski");
            if (response.IsSuccessStatusCode) {
                string responseString = await response.Content.ReadAsStringAsync();
                sport = JsonSerializer.Deserialize<List<Models.Sport>>(responseString);
            }
            return sport;
        }
    }
}
