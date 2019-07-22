using Event;
using System;
using System.Threading;
using System.Timers;

namespace Worker
{
    public class Consumer : IConsumer
    {
        public event Event<MessageReceivedEventArgs> MessageReceived;

        private System.Timers.Timer _timer;

        private static int _count = 1;

        public Consumer(IMessageReceivedPersistHandler messageReceivedPersistHandler,
                        IMessageReceivedSendEmailHandler messageReceivedSendEmailHandler)
        {
            _timer = new System.Timers.Timer(10);
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();
            MessageReceived += messageReceivedPersistHandler.PersistMessage;
            MessageReceived += messageReceivedSendEmailHandler.SendEmail;
        }

        public Consumer()
        {
            _timer = new System.Timers.Timer(10);
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _timer.Stop();
            Processing();
            _timer.Start();
        }

        public void Processing()
        {
            var msg = $"Message {_count} received.";
            
            if (!string.IsNullOrEmpty(msg))
                OnMessageReceived(new MessageReceivedEventArgs(msg, DateTime.Now));

            _count++;

            Thread.Sleep(1000);
        }

        private void OnMessageReceived(MessageReceivedEventArgs e) => MessageReceived?.Invoke(this, e);

    }

}
