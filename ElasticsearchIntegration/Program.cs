using ElasticsearchIntegration.Elastic;
using ElasticsearchIntegration.ElasticNest;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ElasticsearchIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var serviceProvider = new ServiceCollection();
            serviceProvider.AddTransient<IElasticNestClient, ElasticClientNest>();


            Console.WriteLine("Hello World!");
        }
    }
}
