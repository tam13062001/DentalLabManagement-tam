﻿using DentalLabManagement.BusinessTier.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DentalLabManagement.BusinessTier.Payload.Product
{
    public class UpdateProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public int CategoryId { get; set; }
        public ProductStatus Status { get; set; }
        public string? Image { get; set; }

        public void TrimString()
        {
            Name = Name.Trim();
            Description = Description.Trim();    
            Image = Image?.Trim();

        }
    }
    
}
