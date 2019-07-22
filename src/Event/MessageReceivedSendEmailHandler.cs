using System;

namespace Event
{
    public class MessageReceivedSendEmailHandler : IMessageReceivedSendEmailHandler
    {
        public void SendEmail(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine($"Message sent by E-mail !! {e.Message}, {e.MessageReceivedDate}");
        }
    }
}
