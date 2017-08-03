using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoLogistic.PostsModel.SpecificationType
{
    public enum TransportType
    {
        Truck = 1,
        Van,
        Minibus,
        Pickup
    }
    public class TransportSpecification : ISpecification
    {
        public TransportType TransportType;
        public double WeightCapacity { get; set; }
        public double VolumeCapacity { get; set; }

        public TransportSpecification(TransportType type, double weightCapacity, double voluleCapacity)
        {
            TransportType = type;
            WeightCapacity = weightCapacity;
            VolumeCapacity = voluleCapacity;
        }

    }
}
