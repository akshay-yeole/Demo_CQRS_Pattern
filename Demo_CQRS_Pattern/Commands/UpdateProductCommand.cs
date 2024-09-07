using MediatR;

namespace Demo_CQRS_Pattern.Commands
{
    public record UpdateProductCommand(int id, string productName) : IRequest; 
}
