using Demo_CQRS_Pattern.Notifications;
using MediatR;

namespace Demo_CQRS_Pattern.Handlers
{
    public class AddProductNotificationHandler : INotificationHandler<AddProductNotification>
    {
        private readonly FakeDataStore _store;

        public AddProductNotificationHandler(FakeDataStore store)
        {
            _store = store;
        }
        public async Task Handle(AddProductNotification notification, CancellationToken cancellationToken)
        {
            var product =await _store.GetProductByIdAsync(notification.Product.Id);
            Console.WriteLine($"Product is added :: {product.Name}");
            await Task.CompletedTask;
        }
    }
}
