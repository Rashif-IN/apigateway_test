using System;
using System.Collections.Generic;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;

namespace cqrs_Test.Application.UseCase.Merchant.Queries.GetMerchants
{
    public class GetMerchantsDto : BaseDto
    {
        public List<Merchants> Data { get; set; }
    }
}
