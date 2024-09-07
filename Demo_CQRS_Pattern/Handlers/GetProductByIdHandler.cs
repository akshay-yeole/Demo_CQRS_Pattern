using Demo_CQRS_Pattern.Quries;
using MediatR;

namespace Demo_CQRS_Pattern.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductsById, Product>
    {
        private readonly FakeDataStore _fakeDataStore;
        
        public GetProductByIdHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public Task<Product> Handle(GetProductsById request, CancellationToken cancellationToken)
        {
            return _fakeDataStore.GetProductByIdAsync(request.id);
        }
    }
}
