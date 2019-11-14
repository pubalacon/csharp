using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongo01
{
    /// <summary>
    /// Class used to access Mongo DB.
    /// </summary>
    public class UsersRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<User> _usersCollection;

        public UsersRepository(string dbname, string collection)
        {
            _client = new MongoClient();
            _database = _client.GetDatabase(dbname);
            _usersCollection = _database.GetCollection<User>(collection);
        }

        public async Task InsertUser(User user)
        {
            await _usersCollection.InsertOneAsync(user);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _usersCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<List<User>> GetUsersByField(string fieldName, string fieldValue)
        {
            var filter = Builders<User>.Filter.Eq(fieldName, fieldValue);
            var result = await _usersCollection.Find(filter).ToListAsync();

            return result;
        }

        public async Task<List<User>> GetUsers(int startingFrom, int count)
        {
            var result = await _usersCollection.Find(new BsonDocument())
            .Skip(startingFrom)
            .Limit(count)
            .ToListAsync();

            return result;
        }

        public async Task<bool> UpdateUser(ObjectId id, string udateFieldName, string updateFieldValue)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            var update = Builders<User>.Update.Set(udateFieldName, updateFieldValue);

            var result = await _usersCollection.UpdateOneAsync(filter, update);

            return result.ModifiedCount != 0;
        }

        public async Task<bool> DeleteUserById(ObjectId id)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            var result = await _usersCollection.DeleteOneAsync(filter);
            return result.DeletedCount != 0;
        }

        public long UserExists(ObjectId id)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            return _usersCollection.CountDocuments(filter);
        }

        public async Task<long> DeleteAllUsers()
        {
            var filter = new BsonDocument();
            var result = await _usersCollection.DeleteManyAsync(filter);
            return result.DeletedCount;
        }

        public async Task CreateIndexOnCollection(IMongoCollection<BsonDocument> collection, string field)
        {
            
            //var keys = Builders<BsonDocument>.IndexKeys.Ascending(field);
            //await collection.Indexes.CreateOneAsync(keys);

            var keys = Builders<BsonDocument>.IndexKeys.Ascending(field);
            var indexModel = new CreateIndexModel<BsonDocument> (keys);
            await collection.Indexes.CreateOneAsync(indexModel);
        }

        public async Task CreateIndexOnNameField()
        {
            //var keys = Builders<User>.IndexKeys.Ascending(x => x.Name);
            //await _usersCollection.Indexes.CreateOneAsync(keys);

            var keys = Builders<User>.IndexKeys.Ascending(x => x.Name);
            var indexModel = new CreateIndexModel<User>(keys);
            await _usersCollection.Indexes.CreateOneAsync(indexModel);
        }
    }
}
