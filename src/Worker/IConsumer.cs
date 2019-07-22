using Event;

namespace Worker
{
    public interface IConsumer
    {
        event Event<MessageReceivedEventArgs> MessageReceived;

        void Processing();
    }
}