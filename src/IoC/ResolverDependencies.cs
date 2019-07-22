using Event;
using Microsoft.Extensions.DependencyInjection;
using Worker;

namespace IoC
{
    public class ResolverDependencies
    {
        public ServiceProvider Resolve()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IConsumer, Consumer>();
            serviceCollection.AddTransient<IMessageReceivedPersistHandler, MessageReceivedPersistHandler>();
            serviceCollection.AddTransient<IMessageReceivedSendEmailHandler, MessageReceivedSendEmailHandler>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var consumer = serviceProvider.GetService<IConsumer>();
            var handler1 = serviceProvider.GetService<IMessageReceivedPersistHandler>();
            var handler2 = serviceProvider.GetService<IMessageReceivedSendEmailHandler>();

            consumer.MessageReceived += handler1.PersistMessage;
            consumer.MessageReceived += handler2.SendEmail;

            //consumer.MessageReceived += new MessageReceivedPersistHandler().PersistMessage;
            //consumer.MessageReceived += new MessageReceivedSendEmailHandler().SendEmail;


            return serviceProvider;
        }
    }
}
