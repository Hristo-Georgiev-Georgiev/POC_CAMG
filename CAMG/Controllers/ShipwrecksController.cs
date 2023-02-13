using CAMG.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CAMG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipwrecksController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Shipwreck> Get()
        {
            var client = new MongoClient("mongodb+srv://admin:admin7@cluster0.x7m3lux.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("sample_geospatial");
            var collection = database.GetCollection<Shipwreck>("shipwrecks");

            //var filter = new BsonDocument("depth", new BsonDocument("$gt", 1));
            //var specificItem = collection.Find(filter);

            return collection.AsQueryable().ToList();
        }
    }
}