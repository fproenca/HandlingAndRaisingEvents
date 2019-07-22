namespace Event
{
    public interface IMessageReceivedSendEmailHandler : IEventHandler
    {
        void SendEmail(object sender, MessageReceivedEventArgs e);
    }
}