using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.Elastic
{
    public interface IElasticLowLevelClient
    {
        Elasticsearch.Net.ElasticLowLevelClient Build();
    }
}
