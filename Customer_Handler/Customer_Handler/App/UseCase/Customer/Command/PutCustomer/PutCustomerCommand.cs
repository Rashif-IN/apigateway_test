using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;
using MediatR;

namespace cqrs_Test.Application.UseCase.Customer.Command.PutCustomer
{
    public class PutCustomerCommand : RequestData<Customers> ,IRequest<PutCustomerCommandDto>
    {
       
    }
    
}
