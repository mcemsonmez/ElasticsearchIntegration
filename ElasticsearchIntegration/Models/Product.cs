using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.Models
{
    [ElasticsearchType(RelationName = "products")]
    public class Product : IElasticsearchResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        // ???
        public IApiCallDetails ApiCall { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool TryGetServerErrorReason(out string reason)
        {
            reason = "No Reason";
            return false;
        }
    }
}
