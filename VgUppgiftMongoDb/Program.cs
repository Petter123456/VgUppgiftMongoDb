using System;
using Newtonsoft.Json; 
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace VgUppgiftMongoDb
{
    class Program
    {

        static void Main(string[] args)
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            var db = mongoClient.GetDatabase("labbb3");
            var collection = db.GetCollection<BsonDocument>("restaurants");

            MainAsync().Wait();
           // ReturnAll(collection);
           // CategoryCafe(collection);
           // AggregateStars(collection);
           // UpdateName(collection);
           // IncrementStars(collection); 

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        //private static void ReturnAll(IMongoCollection<BsonDocument> collection)
        //{
        //    //Skriv en metod som skriver ut(Console.Writeline) alla dokument i samlingen. 
        //    var allDocuments = collection.Find(new BsonDocument()).ToList();

        //    foreach (var restaurants in allDocuments)
        //    {
        //        Console.WriteLine(restaurants);
        //    }
        //}

        //private static void CategoryCafe(IMongoCollection<BsonDocument> collection)
        //{
        //    //Skriv en metod som skriver ut namnet på alla dokument som har kategorin “Cafe” 
        //    var filterCategoryCafe = Builders<BsonDocument>.Filter.Eq("categories", "Cafe");
        //    //OBS! Exkludera id så att bara namn visas
        //    var projection = Builders<BsonDocument>.Projection.Exclude("_id");
        //    var findWithProjection = collection.Find(filterCategoryCafe).Project(projection);

        //    foreach (var restaurant in findWithProjection.ToEnumerable())
        //    {
        //        Console.WriteLine(restaurant);

        //    }
        //}


        //private static void AggregateStars(IMongoCollection<BsonDocument> collection)
        //{
        //    //Skriv en metod som aggregerar en lista med alla restauranger som har 
        //    //4 eller fler “stars” och skriver ut endast “name” och “stars” 
        //    //OBS! Metoderna ska skriva ut via Console.Writeline resultatet, 
        //    //det vill säga, när jag kör ert program ska jag se resultatet från utskrifterna. 

        //    var filter = Builders<BsonDocument>.Filter.Gt("stars", 3);

        //    var result = collection.Aggregate()
        //         .Match(filter)
        //         .Project(Builders<BsonDocument>.Projection.Exclude("_id").Exclude("categories"));

        //    foreach (var item in result.ToEnumerable())
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

      

        //private static void UpdateName(IMongoCollection<BsonDocument> collection)
        //{ 
        //    var filter = Builders<BsonDocument>.Filter.Eq("name", "456 Cookies Shop");
        //    var update = Builders<BsonDocument>.Update.Set("name", "123 Cookies Heaven");

        //    collection.UpdateOne(filter, update);

        //    //OBS! Skriv ut alla restauranger igen, så att jag kan se att namnet ändrats för denna restaurang när jag kör ert program. 
        //    ReturnAll(collection); 
        //}

        //private static void IncrementStars(IMongoCollection<BsonDocument> collection)
        //{
        //    //Skriv en metod som uppdaterar genom increment “stars” för den restaurang som har “name” “XYZ Coffee Bar” så att nya värdet på stars blir 6.
        //    //OBS! Ni ska använda increment . 
        //    var filter = Builders<BsonDocument>.Filter.Eq("name", "XYZ Coffee Bar");
        //    var update = Builders<BsonDocument>.Update.Inc("stars", 1);
        //    collection.UpdateOne(filter, update);

        //    //OBS! Skriv ut alla restauranger igen, så att jag kan se att “stars” blivit 6, för denna restaurang när jag kör ert program. 
        //    ReturnAll(collection); 
        //}

    

    //    static async Task MainAsync()
    //    {

    //        var client = new MongoClient();

    //        IMongoDatabase db = client.GetDatabase("labbb3");

    //        var collection = db.GetCollection<Restaurants>("restaurants");
    //        var newRestaurants = CreateNewRestaurants();
    //        var collectionCount = collection.Count(new BsonDocument());

    //        if (collectionCount > 0)
    //        {
    //            Console.WriteLine("Database has values");
    //        }
    //        else
    //        {
    //            await collection.InsertManyAsync(newRestaurants);

    //        }
    //    }

    //    private static IEnumerable<Restaurants> CreateNewRestaurants()
    //    {
    //        var restaurant1 = new Restaurants
    //        {
    //            id = "5c39f9b5df831369c19b6bca",
    //            name = "Sun Bakery Trattoria",
    //            categories = new List<string>() { "Pizza", "Pasta", "Italian", "Coffee", "Sandwiches" },
    //            stars = 4,
    //        };

    //        var restaurant2 = new Restaurants
    //        {
    //            id = "5c39f9b5df831369c19b6bcb",
    //            name = "Blue Bagels Grill",
    //            categories = new List<string> { "Bagels", "Cookies", "Sandwiches" },
    //            stars = 3,
    //        };

    //        var restaurant3 = new Restaurants
    //        {
    //            id = "5c39f9b5df831369c19b6bcc",
    //            name = "Hot Bakery Cafe",
    //            categories = new List<string> { "Bakery","Cafe","Coffee","Dessert"},
    //            stars = 4,
    //        };

    //        var restaurant4 = new Restaurants
    //        {
    //            id = "5c39f9b5df831369c19b6bcd",
    //            name = "XYZ Coffee Bar",
    //            categories = new List<string> { "Coffee", "Cafe", "Bakery", "Chocolates" },
    //            stars = 5,
    //        };

    //        var restaurant5 = new Restaurants
    //        {
    //            id = "5c39f9b5df831369c19b6bce",
    //            name = "456 Cookies Shop",
    //            categories = new List<string> { "Bakery", "Cookies", "Cake", "Coffee" },
    //            stars = 4,
    //        };

    //        var newRestaurants = new List<Restaurants> { restaurant1, restaurant2, restaurant3, restaurant4, restaurant5 };

    //        return newRestaurants;
    //    }
    //}

}



