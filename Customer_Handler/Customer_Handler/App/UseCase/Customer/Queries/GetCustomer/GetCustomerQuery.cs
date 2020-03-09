using System;
using MediatR;

namespace cqrs_Test.Application.UseCase.Customer.Queries.GetCustomer
{
    public class GetCustomerQuery : IRequest<GetCustomerDto>
    {
        public int Id { get; set; }

        public GetCustomerQuery(int id)
        {
            Id = id;
        }
    }
}
