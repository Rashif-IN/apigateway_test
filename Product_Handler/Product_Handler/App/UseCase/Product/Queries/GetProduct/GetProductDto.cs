using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;

namespace cqrs_Test.Application.UseCase.Product.Queries.GetProduct
{
    public class GetProductDto : BaseDto
    {
        public Products Data { get; set; }
    }
}
