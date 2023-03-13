using MongoDB.Driver;
using MyMauiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMauiProject.Data
{
    internal class Database {
        public static IMongoCollection<Statistic> GetMyDbCollection() {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://MohammadAlZ:Mm1122338@cluster0.xhkg8pf.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("CaloriesBurnedDb");
            var myCollection = database.GetCollection<Statistic>("MySportCollection");
            return myCollection;
        }
    }
}
