using System;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace VgUppgiftMongoDb
{
    public class SeedDb
    {

        public async Task MainAsync()
        {

            var client = new MongoClient();

            IMongoDatabase db = client.GetDatabase("labbb3");

            var collection = db.GetCollection<Restaurants>("restaurants");
            var newRestaurants = CreateNewRestaurants();
            var collectionCount = collection.Count(new BsonDocument());

            if (collectionCount > 0)
            {
                Console.WriteLine("Database has values");
            }
            else
            {
                await collection.InsertManyAsync(newRestaurants);

            }
        }

        public IEnumerable<Restaurants> CreateNewRestaurants()
        {
            var restaurant1 = new Restaurants
            {
                id = "5c39f9b5df831369c19b6bca",
                name = "Sun Bakery Trattoria",
                categories = new List<string>() { "Pizza", "Pasta", "Italian", "Coffee", "Sandwiches" },
                stars = 4,
            };

            var restaurant2 = new Restaurants
            {
                id = "5c39f9b5df831369c19b6bcb",
                name = "Blue Bagels Grill",
                categories = new List<string> { "Bagels", "Cookies", "Sandwiches" },
                stars = 3,
            };

            var restaurant3 = new Restaurants
            {
                id = "5c39f9b5df831369c19b6bcc",
                name = "Hot Bakery Cafe",
                categories = new List<string> { "Bakery", "Cafe", "Coffee", "Dessert" },
                stars = 4,
            };

            var restaurant4 = new Restaurants
            {
                id = "5c39f9b5df831369c19b6bcd",
                name = "XYZ Coffee Bar",
                categories = new List<string> { "Coffee", "Cafe", "Bakery", "Chocolates" },
                stars = 5,
            };

            var restaurant5 = new Restaurants
            {
                id = "5c39f9b5df831369c19b6bce",
                name = "456 Cookies Shop",
                categories = new List<string> { "Bakery", "Cookies", "Cake", "Coffee" },
                stars = 4,
            };

            var newRestaurants = new List<Restaurants> { restaurant1, restaurant2, restaurant3, restaurant4, restaurant5 };

            return newRestaurants;
        }
    }
}
}
