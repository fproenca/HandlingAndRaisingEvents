using System;
using Event;
using IoC;
using Worker;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var c = new Consumer();

            //var mrph = new MessageReceivedPersistHandler();
            //var mrse = new MessageReceivedSendEmailHandler();

            //c.MessageReceived += mrph.PersistMessage;
            //c.MessageReceived += mrse.SendEmail;

            //Console.ReadKey();

            new ResolverDependencies().Resolve();

            //var c = new Consumer(new MessageReceivedPersistHandler(), new MessageReceivedSendEmailHandler());

            Console.ReadKey();
        }
    }
}
