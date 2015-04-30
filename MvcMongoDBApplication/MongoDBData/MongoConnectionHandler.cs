namespace MongoDBData
{
    using System.Configuration;
    using Classes;
    using Interfaces;
    using MongoDB.Driver;

    public class MongoConnectionHandler<T> where T : IMongoEntity
    {
        public IMongoCollection<T> MongoCollection { get; private set; }

        public MongoConnectionHandler()
        {
            var connection = ConfigurationManager.ConnectionStrings["DbRepository"].ConnectionString;

            //// Get a thread-safe client object by using a connection string
            var mongoClient = new MongoClient(connection);

            //// Get a reference to a server object from the Mongo client object
            var mongoDb = mongoClient.GetDatabase("Retsehc");

            MongoCollection = mongoDb.GetCollection<T>(typeof(T).Name.ToLower() + "s");
        }
    }
}
