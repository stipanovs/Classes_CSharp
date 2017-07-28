using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes_CSharp.PostsModel.SpecificationType;
using Microsoft.Scripting.Interpreter;

namespace Classes_CSharp.PostsModel
{
    
    public class CargoSpecification : ISpecification
    {
        public string Description { get; set; }
        public double Weght { get; set; }
        public double Volume { get; set; }

        public CargoSpecification(string description, double weight = 0.00, double volume = 0.00)
        {
            Description = description;
            Weght = weight;
            Volume = volume;
        }
    }
}
