using System;

namespace Event
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public MessageReceivedEventArgs(string message, DateTime messageReceivedDate)
        {
            Message = message;
            MessageReceivedDate = messageReceivedDate;
        }

        public string Message { get; }
        public DateTime MessageReceivedDate { get; }
    }
}
