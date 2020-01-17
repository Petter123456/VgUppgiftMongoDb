using System;
using Newtonsoft.Json; 
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VgUppgiftMongoDb
{
    class Program
    {
        static void Main(string[] args)
        {

            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");

            var db = mongoClient.GetDatabase("lab3");
            var collection = db.GetCollection<BsonDocument>("restaurant");
            
            
            //var newCustomers = new List<BsonDocument>();

            //var newCustomers = CreateNewCustomers();

            collection.InsertOne(new BsonDocument
            {
                {"id", "5c39f9b5df831369c19b6bca" },
                {"name", "Sun Bakery Trattoria"},
                {"stars", 4},
                {"categories", new BsonArray
                    {
                       {"Pizza" }, {"Pasta" }, {"Italian" }, {"Coffe" },{"Sandwitches" }
                    }
                }
            });

            collection.InsertOne(new BsonDocument
            {
                {"id", "5c39f9b5df831369c19b6bcb" },
                {"name", "Blue Bagels Grill"},
                {"stars", 3},
                {"categories", new BsonArray
                    {
                        {"Bagels" }, {"Cookies" }, {"Sandwiches" }
                    }
                }
            });

            collection.InsertOne(new BsonDocument
            {
                {"id", "5c39f9b5df831369c19b6bcc" },
                {"name", "Hot Bakery Cafe"},
                {"stars", 4},
                {"categories", new BsonArray
                    {
                        {"Bakery" },{"Cafe" },{"Coffee" },{"Dessert"}
                    }
                }
            });

            collection.InsertOne(new BsonDocument
            {
                {"id", "5c39f9b5df831369c19b6bcd" },
                {"name", "XYZ Coffee Bar"},
                {"stars", 5},
                {"categories", new BsonArray
                    {
                        {"Coffee" }, {"Cafe" }, {"Bakery" }, {"Chocolates"}
                    }
                }
            });

            collection.InsertOne(new BsonDocument
            {
                {"id", "5c39f9b5df831369c19b6bce" },
                {"name", "456 Cookies Shop"},
                {"stars", 4},
                {"categories", new BsonArray
                    {
                        {"Bakery" }, {"Cookies" }, {"Cake" }, {"Coffee"}
                    }
                }
            });


            //newCustomers.Add(customer1);
            //newCustomers.Add(customer2);
            //newCustomers.Add(customer3);
            //newCustomers.Add(customer4);
            //newCustomers.Add(customer5);


            //collection.InsertManyAsync(newCustomers);

        }

        // static async Task MainAsync()
        //{
        //    MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");

        //    var db = mongoClient.GetDatabase("labb3");
        //    var collection = db.GetCollection<BsonDocument>("restaurants");
        //    var newCustomers = CreateNewCustomers();

        //    await collection.InsertManyAsync(newCustomers); 

        //}

        //private static IEnumerable<BsonDocument> CreateNewCustomers()
        //{
        //    var customer1 = new BsonDocument
        //    {
        //        {"id", "5c39f9b5df831369c19b6bca" },
        //        { "name", "Sun Bakery Trattoria"},
        //        {"stars", 4},
        //        {"categories", new BsonArray
        //            {
        //               {"Pizza" }, {"Pasta" }, {"Italian" }, {"Coffe" },{"Sandwitches" } 
        //            }
        //        }
        //    };

        //    var customer2 = new BsonDocument
        //    {
        //        {"id", "5c39f9b5df831369c19b6bcb" },
        //        { "name", "Blue Bagels Grill"},
        //        {"stars", 3},
        //        {"categories", new BsonArray
        //            {
        //                {"Bagels" }, {"Cookies" }, {"Sandwiches" }
        //            }
        //        }
        //    };

        //    var customer3 = new BsonDocument
        //    {
        //        {"id", "5c39f9b5df831369c19b6bcc" },
        //        { "name", "Hot Bakery Cafe"},
        //        {"stars", 4},
        //        {"categories", new BsonArray
        //            {
        //                {"Bakery" },{"Cafe" },{"Coffee" },{"Dessert"}
        //            }
        //        }
        //    };

        //    var customer4 = new BsonDocument
        //    {
        //        {"id", "5c39f9b5df831369c19b6bcd" },
        //        { "name", "XYZ Coffee Bar"},
        //        {"stars", 5},
        //        {"categories", new BsonArray
        //            {
        //                {"Coffee" }, {"Cafe" }, {"Bakery" }, {"Chocolates"}
        //            }
        //        }
        //    };

        //    var customer5 = new BsonDocument
        //    {
        //        {"id", "5c39f9b5df831369c19b6bce" },
        //        { "name", "456 Cookies Shop"},
        //        {"stars", 4},
        //        {"categories", new BsonArray
        //            {
        //                {"Bakery" }, {"Cookies" }, {"Cake" }, {"Coffee"}
        //            }
        //        }
        //    };

        //    var newCustomers = new List<BsonDocument>();
        //    newCustomers.Add(customer1);
        //    newCustomers.Add(customer2);
        //    newCustomers.Add(customer3);
        //    newCustomers.Add(customer4);
        //    newCustomers.Add(customer5);

        //    return newCustomers;
        //}
    }
}



