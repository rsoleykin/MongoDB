namespace MongoDBData.Classes
{
    using System;
    using Interfaces;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class MongoEntity : IMongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
