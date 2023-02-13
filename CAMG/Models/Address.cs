using MongoDB.Bson.Serialization.Attributes;

namespace CAMG.Models
{
    [BsonNoId]
    [BsonIgnoreExtraElements]
    public class Address
    {
        [BsonElement("building")]
        public string Building { get; set; }
        [BsonElement("coord")]
        public double[] Coordinates { get; set; }
        [BsonElement("street")]
        public string Street { get; set; }
        [BsonElement("zipcode")]
        public string Zipcode { get; set; }
    }
}
