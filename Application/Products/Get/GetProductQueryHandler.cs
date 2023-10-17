using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Get
{
    public sealed class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductResponse>
    {
        public Task<ProductResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
