using System;
using System.Threading;
using System.Threading.Tasks;
using cqrs_Test.Application.Interfaces;
using cqrs_Test.Application.UseCase.Product.Queries.GetProduct;

using MediatR;
using Microsoft.EntityFrameworkCore;

namespace cqrs_Test.Application.UseCase.Product.Queries.GetProducts
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, GetProductsDto>
    {
        private readonly IContext konteks;

        public GetProductsQueryHandler(IContext context)
        {
            konteks = context;
        }
        public async Task<GetProductsDto> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {

            var result = await konteks.products.ToListAsync();

            return new GetProductsDto
            {
                Status = true,
                Message = "Product successfully retrieved",
                Data = result
            };

        }
    }
}
