using MassTransit;
using Messages;

namespace Consumer2.Consumers
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
            _logger.LogInformation($"{context.Message.CheckInDate.ToLongDateString()} tarihi için {context.Message.Duration} günlük rezervasyon talebi geldi");
            return Task.CompletedTask;
        }
    }
}
