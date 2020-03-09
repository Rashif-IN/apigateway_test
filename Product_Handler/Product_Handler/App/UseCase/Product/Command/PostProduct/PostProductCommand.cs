using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;
using MediatR;

namespace cqrs_Test.Application.UseCase.Product.Command.PostProduct
{
    public class PostProductCommand : RequestData<Products>, IRequest<PostProductCommandDto>
    {
    }
   
}
