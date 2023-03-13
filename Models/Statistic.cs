using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiProject.Models
{
    internal class Statistic {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string SportName { get; set; }
        public string Calorier { get; set; }
        public string Timer { get; set; }
    }
}
