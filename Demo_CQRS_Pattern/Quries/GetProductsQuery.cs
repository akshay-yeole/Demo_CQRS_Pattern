using MediatR;

namespace Demo_CQRS_Pattern.Quries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
