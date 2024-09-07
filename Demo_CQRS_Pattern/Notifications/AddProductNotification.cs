using MediatR;

namespace Demo_CQRS_Pattern.Notifications
{
    public record AddProductNotification(Product Product): INotification;

}
