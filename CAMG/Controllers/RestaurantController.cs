using CAMG.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CAMG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Restaurant> Get()
        {
            var client = new MongoClient("mongodb+srv://admin:admin7@cluster0.x7m3lux.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("sample_restaurants");
            var collection = database.GetCollection<Restaurant>("restaurants");

            //var filter = new BsonDocument("depth", new BsonDocument("$gt", 1));
            //var specificItem = collection.Find(filter);

            return collection.AsQueryable().ToList();
        }

        [HttpGet("GetByKeyword")]
        public IEnumerable<Restaurant> GetByKeyword(string keyword)
        {
            var client = new MongoClient("mongodb+srv://admin:admin7@cluster0.x7m3lux.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("sample_restaurants");
            var collection = database.GetCollection<Restaurant>("restaurants");

            var filteredRestaurants = collection
                .AsQueryable()
                .ToList()
                .Where(
                    x => x.Address.Street.Contains(keyword) ||
                    x.Cuisine.Contains(keyword) ||
                    x.Borough.Contains(keyword) ||
                    x.Name.Contains(keyword))
                .ToList();

            //var filter = new BsonDocument("depth", new BsonDocument("$gt", 1));
            //var specificItem = collection.Find(filter);
            return filteredRestaurants;
        }
    }
}
