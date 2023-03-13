using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiProject.Data
{
    internal class Timer
    {
        public TimeOnly time = new();
        public bool isRunning;
        public string SetTimer() { // Metoden för att vissa timer på skärmen
            string timer = $"{time.Hour:00}:{time.Minute:00}:{time.Second:00}";
            return timer;
        }
        public async Task<string> EndSportTime(string result) { // Metoden för avsluta sporten
            if (isRunning) {
                isRunning = false;
                await Task.Delay(10);
            }
            return result;
        }
    }
}
