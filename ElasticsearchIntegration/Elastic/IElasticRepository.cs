using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Elasticsearch.Net.Specification.AsyncSearchApi;


namespace ElasticsearchIntegration.Elastic
{
    interface IElasticRepository<T> where T : class
    {
        Task<T> SearchAsync(string index, PostData body, SearchRequestParameters requestParameters = null, CancellationToken ctx = default);
        Task<T> DocumentExistsAsync(string index, string id, DocumentExistsRequestParameters requestParameters = null, CancellationToken ctx = default);
        Task<T> GetAsync(string index, string id, GetRequestParameters requestParameters = null, CancellationToken ctx = default);
        Task<T> IndexAsync(string index, PostData body, IndexRequestParameters requestParameters = null, CancellationToken ctx = default);
        Task<T> CreateAsync(string index, string id, PostData body, CreateRequestParameters requestParameters = null, CancellationToken ctx = default);
        Task<T> UpdateAsync(string index, string id, PostData body, UpdateRequestParameters requestParameters = null, CancellationToken ctx = default);
        Task<T> DeleteAsync(string index, string id, DeleteRequestParameters requestParameters = null, CancellationToken ctx = default);
        Task<T> DeleteByQueryAsync(string index, PostData body, DeleteByQueryRequestParameters requestParameters = null, CancellationToken ctx = default);
    }
}
