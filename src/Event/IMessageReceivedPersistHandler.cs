namespace Event
{
    public interface IMessageReceivedPersistHandler : IEventHandler
    {
        void PersistMessage(object sender, MessageReceivedEventArgs e);
    }
}