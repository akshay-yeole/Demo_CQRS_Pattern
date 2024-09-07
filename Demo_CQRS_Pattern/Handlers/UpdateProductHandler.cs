using Demo_CQRS_Pattern.Commands;
using MediatR;

namespace Demo_CQRS_Pattern.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly FakeDataStore _store;

        public UpdateProductHandler(FakeDataStore store)
        {
            _store = store;
        }
        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            await _store.UpdateProductAsync(request.id, request.productName);
            return;
        }
    }
}
