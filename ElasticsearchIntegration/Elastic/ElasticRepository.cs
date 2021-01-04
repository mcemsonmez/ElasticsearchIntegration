using Elasticsearch.Net;
using ElasticsearchIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.Elastic
{
    public class ElasticRepository : IElasticRepository<Product>
    {
        Elasticsearch.Net.ElasticLowLevelClient _client;

        public ElasticRepository(IElasticLowLevelClient client)
        {
            _client = client.Build();
        }

        public async Task<Product> CreateAsync(string index, string id, PostData body, CreateRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.CreateAsync<Product>(index, id, body, requestParameters);
        }

        public async Task<Product> DeleteAsync(string index, string id, DeleteRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.DeleteAsync<Product>(index, id, requestParameters);
        }

        public async Task<Product> DeleteByQueryAsync(string index, PostData body, DeleteByQueryRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.DeleteByQueryAsync<Product>(index, body, requestParameters);
        }

        public async Task<Product> DocumentExistsAsync(string index, string id, DocumentExistsRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.DocumentExistsAsync<Product>(index, id, requestParameters);
        }

        public async Task<Product> GetAsync(string index, string id, GetRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.GetAsync<Product>(index, id, requestParameters);
        }

        public async Task<Product> IndexAsync(string index, PostData body, IndexRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.IndexAsync<Product>(index, body, requestParameters);
        }

        public async Task<Product> SearchAsync(string index, PostData body, SearchRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.SearchAsync<Product>(index, body, requestParameters);
        }

        public async Task<Product> UpdateAsync(string index, string id, PostData body, UpdateRequestParameters requestParameters = null, CancellationToken ctx = default)
        {
            return await _client.UpdateAsync<Product>(index, id, body, requestParameters);
        }
    }
}
