using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.Elastic
{
    public class ElasticLowLevelClient : IElasticLowLevelClient
    {
        public static string IndexName => "Test";

        public static string ElastisearchUrl => "localhost:9200";

        Elasticsearch.Net.ElasticLowLevelClient IElasticLowLevelClient.Build()
        {
            var node = new Uri("http://localhost:9200");
            var settings = new ConnectionConfiguration(node)
                .RequestTimeout(TimeSpan.FromMinutes(2));
            return new Elasticsearch.Net.ElasticLowLevelClient(settings);
        }
    }
}
