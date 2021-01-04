using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticsearchIntegration.Models
{
    [ElasticsearchType(IdProperty = "CarId", RelationName= "cars")]
    public class Car
    {
        public Guid CarId { get; set; }
        public Guid TestId { get; set; }
        [PropertyName(name:"Make", Ignore =true)]
        public string Make { get; set; }
        [PropertyName(name: "CarType", Ignore = true)]
        public CarType CarType { get; set; }
        [PropertyName(name: "DoorCount", Ignore = true)]
        public int DoorCount { get; set; }
        [PropertyName(name: "BagCount", Ignore = true)]
        public int BagCount { get; set; }
        [PropertyName(name: "HasAirCondition", Ignore = true)]
        public bool HasAirCondition { get; set; }
        [PropertyName(name: "TransmissionType", Ignore = true)]
        public TransmissionType TransmissionType { get; set; }
        [PropertyName(name: "RentalPricePerDay", Ignore = true)]
        public decimal RentalPricePerDay { get; set; }
        [PropertyName(name: "Currency", Ignore = true)]
        public string Currency { get; set; }
    }

    public enum CarType
    {
        Car,
        Bus
    }

    public enum TransmissionType
    {
        Manual, 
        Automatic
    }
}
