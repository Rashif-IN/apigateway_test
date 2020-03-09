using System;
using System.Threading;
using System.Threading.Tasks;
using cqrs_Test.Application.Interfaces;

using MediatR;

namespace cqrs_Test.Application.UseCase.Product.Command.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeleteProductCommandDto>
    {
        private readonly IContext konteks;

        public DeleteProductCommandHandler(IContext context)
        {
            konteks = context;
        }
       

        public async Task<DeleteProductCommandDto> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var data = await konteks.products.FindAsync(request.Id);
            if (data == null)
            {
               
                return null;
            }
            else
            {
                konteks.products.Remove(data);
                await konteks.SaveChangesAsync(cancellationToken);
              
                return new DeleteProductCommandDto
                {
                    Status = true,
                    Message = "Product sucessfully removed"
                };
            }
            //throw new NotImplementedException();
        }
    }
}
