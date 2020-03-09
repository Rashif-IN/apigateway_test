using System;
using MediatR;

namespace cqrs_Test.Application.UseCase.Product.Command.DeleteProduct
{
    public class DeleteProductCommand : IRequest<DeleteProductCommandDto>
    {
        public int Id { get; set; }

        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
    
}
