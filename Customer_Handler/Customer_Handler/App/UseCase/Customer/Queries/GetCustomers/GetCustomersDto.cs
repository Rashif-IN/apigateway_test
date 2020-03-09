using System;
using System.Collections.Generic;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;

namespace cqrs_Test.Application.UseCase.Customer.Queries.GetCustomers
{
    public class GetCustomersDto : BaseDto
    {
        public List<Customers> Data { get; set; }
    }
}
