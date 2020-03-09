using System;
using MediatR;

namespace cqrs_Test.Application.UseCase.Customer.Command.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest<DeleteCustomerCommandDto>
    {
        public int Id { get; set; }

        public DeleteCustomerCommand(int id)
        {
            Id = id;
        }

    }
}
