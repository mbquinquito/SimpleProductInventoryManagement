﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetAllProductEntities
{
    public class ProductEntityDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}
