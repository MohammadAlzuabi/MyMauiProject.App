using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyMauiProject.Models
{
    internal class Sport {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("calories_per_hour")]
        public int CaloriesPerHour { get; set; }

        [JsonPropertyName("duration_minutes")]
        public int Minute { get; set; }

        [JsonPropertyName("total_calories")]
        public int TotalCalorie { get; set; }
    }
}
