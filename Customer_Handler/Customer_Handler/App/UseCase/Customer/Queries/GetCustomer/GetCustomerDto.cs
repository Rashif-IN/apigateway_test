using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Application.UseCase.Customer.Models;
using cqrs_Test.Domain.Entities;

namespace cqrs_Test.Application.UseCase.Customer.Queries.GetCustomer
{
    public class GetCustomerDto : BaseDto
    {
       public Customers Data { get; set; }
    }
}
