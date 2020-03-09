using System;
using MediatR;

namespace cqrs_Test.Application.UseCase.Product.Queries.GetProduct
{
    public class GetProductQuery : IRequest<GetProductDto>
    {
        public int Id { get; set; }
        public GetProductQuery(int id)
        {
            Id = id;
        }
    }
}
