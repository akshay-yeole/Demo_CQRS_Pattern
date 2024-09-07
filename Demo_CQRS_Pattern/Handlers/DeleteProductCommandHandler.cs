using Demo_CQRS_Pattern.Commands;
using MediatR;

namespace Demo_CQRS_Pattern.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly FakeDataStore _store;

        public DeleteProductCommandHandler(FakeDataStore store)
        {
            _store = store;
        }

        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _store.DeleteProductAsync(request.id);
            return;
        }
    }
}
