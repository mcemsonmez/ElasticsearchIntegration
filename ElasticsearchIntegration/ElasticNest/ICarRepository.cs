using ElasticsearchIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.ElasticNest
{
    public interface ICarRepository : IElasticRepository<Car>
    {
    }
}
