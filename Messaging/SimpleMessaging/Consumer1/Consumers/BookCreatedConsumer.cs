using MassTransit;
using Messages;

namespace Consumer1.Consumers
{
    public class BookCreatedEventConsumer : IConsumer<BookCreatedEvent>
    {
        private ILogger<BookCreatedEventConsumer> _logger;

        public BookCreatedEventConsumer(ILogger<BookCreatedEventConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<BookCreatedEvent> context)
        {
            var email = context.Message.Email;
            _logger.LogInformation($"{email} adresine e-posta gönderildi");
            return Task.CompletedTask;
        }
    }
}
