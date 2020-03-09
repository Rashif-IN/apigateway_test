using System;
using System.Collections.Generic;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;

namespace cqrs_Test.Application.UseCase.Product.Queries.GetProducts
{
    public class GetProductsDto : BaseDto
    {
        public List<Products> Data { get; set; }
    }
}
