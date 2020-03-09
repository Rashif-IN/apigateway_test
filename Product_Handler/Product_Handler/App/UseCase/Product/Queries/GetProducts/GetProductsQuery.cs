using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Application.UseCase.Merchant.Queries.GetMerchant;
using MediatR;

namespace cqrs_Test.Application.UseCase.Product.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<GetProductsDto>
    {
        
    }
}
