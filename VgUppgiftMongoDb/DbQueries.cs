using System;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace VgUppgiftMongoDb
{
   public class DbQueries
    {
        private static void ReturnAll(IMongoCollection<BsonDocument> collection)
        {
            //Skriv en metod som skriver ut(Console.Writeline) alla dokument i samlingen. 
            var allDocuments = collection.Find(new BsonDocument()).ToList();

            foreach (var restaurants in allDocuments)
            {
                Console.WriteLine(restaurants);
            }
        }

        private static void CategoryCafe(IMongoCollection<BsonDocument> collection)
        {
            //Skriv en metod som skriver ut namnet på alla dokument som har kategorin “Cafe” 
            var filterCategoryCafe = Builders<BsonDocument>.Filter.Eq("categories", "Cafe");
            //OBS! Exkludera id så att bara namn visas
            var projection = Builders<BsonDocument>.Projection.Exclude("_id");
            var findWithProjection = collection.Find(filterCategoryCafe).Project(projection);

            foreach (var restaurant in findWithProjection.ToEnumerable())
            {
                Console.WriteLine(restaurant);

            }
        }


        private static void AggregateStars(IMongoCollection<BsonDocument> collection)
        {
            //Skriv en metod som aggregerar en lista med alla restauranger som har 
            //4 eller fler “stars” och skriver ut endast “name” och “stars” 
            //OBS! Metoderna ska skriva ut via Console.Writeline resultatet, 
            //det vill säga, när jag kör ert program ska jag se resultatet från utskrifterna. 

            var filter = Builders<BsonDocument>.Filter.Gt("stars", 3);

            var result = collection.Aggregate()
                 .Match(filter)
                 .Project(Builders<BsonDocument>.Projection.Exclude("_id").Exclude("categories"));

            foreach (var item in result.ToEnumerable())
            {
                Console.WriteLine(item);
            }
        }



        private static void UpdateName(IMongoCollection<BsonDocument> collection)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("name", "456 Cookies Shop");
            var update = Builders<BsonDocument>.Update.Set("name", "123 Cookies Heaven");

            collection.UpdateOne(filter, update);

            //OBS! Skriv ut alla restauranger igen, så att jag kan se att namnet ändrats för denna restaurang när jag kör ert program. 
            ReturnAll(collection);
        }

        private static void IncrementStars(IMongoCollection<BsonDocument> collection)
        {
            //Skriv en metod som uppdaterar genom increment “stars” för den restaurang som har “name” “XYZ Coffee Bar” så att nya värdet på stars blir 6.
            //OBS! Ni ska använda increment . 
            var filter = Builders<BsonDocument>.Filter.Eq("name", "XYZ Coffee Bar");
            var update = Builders<BsonDocument>.Update.Inc("stars", 1);
            collection.UpdateOne(filter, update);

            //OBS! Skriv ut alla restauranger igen, så att jag kan se att “stars” blivit 6, för denna restaurang när jag kör ert program. 
            ReturnAll(collection);
        }

    }
}
