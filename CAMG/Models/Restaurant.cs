using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Net;

namespace CAMG.Models
{
    [BsonNoId]
    [BsonIgnoreExtraElements]
    public class Restaurant
    {
        [BsonId]
        public ObjectId RestaurantId { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }

        [BsonElement("borough")]
        public string Borough { get; set; }

        [BsonElement("cuisine")]
        public string Cuisine { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }
}
