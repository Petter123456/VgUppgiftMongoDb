﻿using System;
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
            
            var s = new SeedDb();
            var q = new DbQueries();

            //Method to seed Db. Put in separate class for readability.
            s.SeedDatabase().Wait();

            //Methods for each query sending db.collection as parameter.
            q.ReturnAll(q.GetDBCollection());
            q.CategoryCafe(q.GetDBCollection());
            q.AggregateStars(q.GetDBCollection());
            q.UpdateName(q.GetDBCollection());
            q.IncrementStars(q.GetDBCollection());

            Console.ReadLine();
        }
    }
}



