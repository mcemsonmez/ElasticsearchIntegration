using ElasticsearchIntegration.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.ElasticNest
{
    public class CarRepository : ICarRepository
    {
        public const string indexName = "cars";
        ElasticClient _client;

        public CarRepository(IElasticNestClient client)
        {
            _client = client.Build();
        }
        public bool Delete(Guid id)
        {
            var result = _client.Delete(new DeleteRequest(indexName, id));
            return result.Result == Result.Deleted;
        }

        public Car Get(Guid id)
        {
            return _client.Get<Car>(new GetRequest(indexName, id)).Source;
        }

        public bool Insert(Car entity)
        {
            var result = _client.Create(new CreateRequest<Car>(entity, indexName));
            return result.Result == Result.Created;
        }

        public IEnumerable<Car> GetAll()
        {
            return _client.Search<Car>(s => s.MatchAll()).Hits.Select(x => x.Source).AsEnumerable();
        }

        public IEnumerable<Car> Search(string query)
        {
            return _client.Search<Car>(s => s.QueryOnQueryString(query)).Hits.Select(x => x.Source).AsEnumerable();
        }

        // ???
        public bool Update(Guid Id, Car entity)
        {
            var result = Get(Id);
            result = entity;
            var request = new Nest.UpdateRequest<Car, Car>(result, indexName, Id);
            var updateResult = _client.Update(request);
            return updateResult.Result == Result.Updated;
        }
    }
}
