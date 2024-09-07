using Demo_CQRS_Pattern.Commands;
using Demo_CQRS_Pattern.Notifications;
using MediatR;

namespace Demo_CQRS_Pattern.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore _store;
        private readonly IPublisher _publisher;

        public AddProductHandler(FakeDataStore store, IPublisher publisher)
        {
            _store = store;
            _publisher = publisher;
        }
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _store.AddProductAsync(request.product);

            var notification = new AddProductNotification(request.product);
            await _publisher.Publish(notification);
            
            return request.product;
        }
    }
}
