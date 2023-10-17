﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public class Product
    {
        public Product(ProductId id, string name,  string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public ProductId Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string? Description { get; private set; }
    }
}
