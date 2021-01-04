using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.ElasticNest
{
    public interface IElasticRepository<T>
    {
        bool Insert(T entity);
        T Get(Guid id);
        bool Delete(Guid id);
        bool Update(Guid Id, T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(string query);
    }
}
