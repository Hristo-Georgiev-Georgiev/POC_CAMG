using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
//using MongoDB.Bson.Serialization.Attributes;

namespace CAMG.Models
{
    [BsonIgnoreExtraElements]
    public class Shipwreck
    {
        [BsonId]
        public ObjectId ShipWreckId { get; set; }

        public string VesselTerms { get; set; }

        [BsonElement("feature_type")]
        public string Feature { get; set; }

        public string Chart { get; set; }

        [BsonElement("latdec")]
        public double Latitude { get; set; }

        [BsonElement("longdec")]
        public double Longitude { get; set; }

        //public string GpQuality { get; set; }

        //public int Depth { get; set; }

        //public string SoundingType { get; set; }

        //public string History { get; set; }

        //public string Quasou { get; set; }

        //public string WaterLevel { get; set; }

        //public double[] Coordinates { get; set; }

        //[BsonExtraElements]
        //public object[] Bucket { get; set; }
    }
}
