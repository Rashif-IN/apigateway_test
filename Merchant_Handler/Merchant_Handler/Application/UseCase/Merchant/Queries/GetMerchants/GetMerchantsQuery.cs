using System;
using cqrs_Test.Application.Models.Query;
using MediatR;

namespace cqrs_Test.Application.UseCase.Merchant.Queries.GetMerchants
{
    public class GetMerchantsQuery : IRequest<GetMerchantsDto>
    {
    }
}
