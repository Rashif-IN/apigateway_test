using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;
using MediatR;

namespace cqrs_Test.Application.UseCase.Customer.Command.PostCustomer
{
    public class PostCustomerCommand : RequestData<Customers> , IRequest<PostCustomerCommandDto>
    {
        
        
    }
    
}
