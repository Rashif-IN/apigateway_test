using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;
using MediatR;

namespace cqrs_Test.Application.UseCase.CustomerPaymentCard.Command.PostCustomerPaymentCard
{
    public class PostCustomerPaymentCardCommand : RequestData<CustomerPaymentCards> , IRequest<PostCustomerPaymentCardCommandDto>
    {
     
    }
    
}
