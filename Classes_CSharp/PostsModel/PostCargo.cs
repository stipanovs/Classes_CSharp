﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoLogistic.PostsModel.SpecificationType;
using CargoLogistic.Users;

namespace CargoLogistic.PostsModel
{
    public class PostCargo : Post
    {
        public CargoSpecification Specification { get; set; }
       
        public PostCargo(DateTime dataFrom, DateTime dateTo, Locality locationFrom,
            Locality locationTo, double price, string additionalInformation, CargoSpecification specification = null, User user = null) 
            : base(dataFrom, dateTo, locationFrom, locationTo, price, additionalInformation, user)
        {
            Specification = specification;
        }
    }
}
