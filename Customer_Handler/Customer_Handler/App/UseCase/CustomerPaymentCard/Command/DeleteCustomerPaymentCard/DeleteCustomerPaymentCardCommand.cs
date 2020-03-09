using System;
using MediatR;

namespace cqrs_Test.Application.UseCase.CustomerPaymentCard.Command.DeleteCustomerPaymentCard
{
    public class DeleteCustomerPaymentCardCommand : IRequest<DeleteCustomerPaymentCardCommandDto>
    {
        public int Id { get; set; }
        public DeleteCustomerPaymentCardCommand(int id)
        {
            Id = id;
        }
    }
    

}
