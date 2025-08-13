using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.DeleteProductEntity
{
    public class DeleteProductEntityCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
