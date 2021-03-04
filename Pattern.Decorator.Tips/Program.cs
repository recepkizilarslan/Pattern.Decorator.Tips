using System;
using Patterns.Decorator.Tips.Abstract;
using Patterns.Decorator.Tips.Core;
using Patterns.Decorator.Tips.Implementation;

namespace Patterns.Decorator.Tips
{
    class Program
    {
        private static INotificationSender _sender;

        public static void InitializeObject()
        {
            _sender = new ExceptionDecorator(
                new SuccessorSender(new SuccessorSender(new MailSender(), new TelegramSender()), new SmsSender()));

        }
        static void Main(string[] args)
        {
            InitializeObject();
            DoAnything();
            _sender.Send(new Message());
        }

        static void DoAnything()
        {
            Console.WriteLine("Do anything...");
        }

    }
}
