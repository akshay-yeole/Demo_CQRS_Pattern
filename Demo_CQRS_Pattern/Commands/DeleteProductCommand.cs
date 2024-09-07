using MediatR;

namespace Demo_CQRS_Pattern.Commands
{
    public record DeleteProductCommand(int id):IRequest;
}
