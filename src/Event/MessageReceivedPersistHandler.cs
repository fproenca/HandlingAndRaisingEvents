using System;

namespace Event
{
    public class MessageReceivedPersistHandler : IMessageReceivedPersistHandler
    {
        public void PersistMessage(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine($"Message persisted !! {e.Message}, {e.MessageReceivedDate}");
        }
    }
}
