using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiProject.ViewModels
{
    internal class ShowSportPageViewModel {
        public async Task<string> ShowSportDetails(string name) { // Metoden för att vissa sport detaljer 
            var allSport = await ViewModels.SportPageViewModel.GetSportAsync();
            foreach (var sport in allSport.Where(x => x.Name == name).ToList()) {
                name = "Sportnamn: {" + sport.Name + "}" + "\nBeräkning förbrända kalorier [" + sport.TotalCalorie + "] i [" + sport.Minute + "] minuter".ToString();
            }
            return name;
        }
    }
}
