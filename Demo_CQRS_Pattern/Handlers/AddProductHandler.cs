using Demo_CQRS_Pattern.Commands;
using MediatR;

namespace Demo_CQRS_Pattern.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore _store;

        public AddProductHandler(FakeDataStore store)
        {
            _store = store;
        }
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _store.AddProductAsync(request.product);
            return request.product;
        }
    }
}
