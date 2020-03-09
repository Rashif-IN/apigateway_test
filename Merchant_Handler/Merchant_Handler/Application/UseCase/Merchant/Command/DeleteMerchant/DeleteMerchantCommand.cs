using System;
using MediatR;

namespace cqrs_Test.Application.UseCase.Merchant.Command.DeleteMerchant
{
    public class DeleteMerchantCommand : IRequest<DeleteMerchantCommandDto>
    {
        public int Id { get; set; }
        public DeleteMerchantCommand(int id)
        {
            Id = id;
        }
    }
    
}
