﻿using System;

//MongoDB.Driver
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization;

namespace AppTest
{
    public class ProfileIdGenerator : IIdGenerator
    {
        public object GenerateId(object container, object document)
        {
            return "Test-" + Guid.NewGuid().ToString();
        }

        public bool IsEmpty(object id)
        {
            return id == null || String.IsNullOrEmpty(id.ToString());
        }
    }

    public class Students
    {
        [BsonId(IdGenerator = typeof(ProfileIdGenerator))]
        public string ProfileId { get; set; }

        //[BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        //public string ProfileId { get; set; }

        //[BsonId]
        //public ObjectId ProfileId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Age { get; set; }
    }

    public class Program
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public static Students GetStudent()
        {
            Console.WriteLine("Please enter student first name : ");
            string FNm = Console.ReadLine();

            Console.WriteLine("Please enter student last name : ");
            string LNm = Console.ReadLine();

            Console.WriteLine("Please enter student age : ");
            string StudentAge = Console.ReadLine();

            Console.WriteLine("Please enter city name : ");
            string StudentCity = Console.ReadLine();

            Students student = new Students()
            {
                FirstName = FNm,
                LastName = LNm,
                Age = StudentAge,
                City = StudentCity,
            };

            return student;
        }

        public void CRUDwithMongoDb()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("School");
            var _collection = _database.GetCollection<Students>("StudentDetails");

            Console.WriteLine
                ("Press select your option from the following\n1 - Insert\n2 - Update One Document\n3 - Delete\n4 - Read All\n");
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "1":
                    //Insert
                    _collection.InsertOne(GetStudent());
                    break;

                case "2":
                    //Update
                    var obj1 = GetStudent();

                    _collection.FindOneAndUpdate<Students>
                        (Builders<Students>.Filter.Eq("FirstName", obj1.FirstName),
                            Builders<Students>.Update.Set("LastName", obj1.LastName).Set("City", obj1.City).Set("Age", obj1.Age));
                    break;

                case "3":
                    //Find and Delete
                    Console.WriteLine("Please Enter the first name to delete the record(so called document) : ");
                    var deletefirstName = Console.ReadLine();
                    _collection.DeleteOne(s => s.FirstName == deletefirstName);

                    break;

                case "4":
                    //Read all existing document
                    var all = _collection.Find(new BsonDocument());
                    Console.WriteLine();

                    foreach (var i in all.ToEnumerable())
                    {
                        Console.WriteLine(i.ProfileId + "  " + i.FirstName + "\t" + i.LastName + "\t" + i.Age + "\t" + i.City);
                    }

                    break;

                default:
                    Console.WriteLine("Please choose a correct option");
                    break;
            }

            //To continue with Program
            Console.WriteLine("\n--------------------------------------------------------------\nPress Y for continue...\n");
            string userChoice = Console.ReadLine();

            if (userChoice == "Y" || userChoice == "y")
            {
                this.CRUDwithMongoDb();
            }
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            p.CRUDwithMongoDb();


            //Hold the screen by logic
            Console.WriteLine("Press any key to trminated the program");
            Console.ReadKey();
        }
    }
}