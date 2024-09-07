using MediatR;

namespace Demo_CQRS_Pattern.Commands
{
    public record AddProductCommand(Product product) : IRequest<Product>; 
}
