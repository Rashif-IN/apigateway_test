using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;

namespace cqrs_Test.Application.UseCase.Merchant.Queries.GetMerchant
{
    public class GetMerchantDto : BaseDto
    {
        public Merchants Data { get; set; }
    }
}
