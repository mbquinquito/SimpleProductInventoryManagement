﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.CreateProductEntity
{
    public class CreateProductEntityCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
    
}
