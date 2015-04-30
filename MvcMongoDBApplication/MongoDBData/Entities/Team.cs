namespace MongoDBData.Entities
{
    using Classes;
    using Enumerables;
    using Interfaces;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    [BsonIgnoreExtraElements]
    public class Team : MongoEntity
    {
        [BsonRepresentation(BsonType.String)]
        public string Name { get; set; }

        public Conferencetype Conference { get; set; }

        public int GamesWon { get; set; }

        public int GamesLost { get; set; }

        public int ConferencePosition { get; set; }
       
    }
}
