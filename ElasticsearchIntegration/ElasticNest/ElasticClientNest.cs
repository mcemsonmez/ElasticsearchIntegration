using ElasticsearchIntegration.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.ElasticNest
{
    public class ElasticClientNest : IElasticNestClient
    {
        public ElasticClient Build()
        {
            var uri = new Uri("localhost:9200");
            var settings = new ConnectionSettings(uri);
            settings.DefaultMappingFor<Car>(x => x.IndexName("cars").IdProperty(x => x.CarId));
            return new ElasticClient(settings);
        }
    }
}
