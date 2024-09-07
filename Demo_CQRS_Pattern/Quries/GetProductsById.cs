using MediatR;

namespace Demo_CQRS_Pattern.Quries
{
     public record GetProductsById(int id) : IRequest<Product>;

}
