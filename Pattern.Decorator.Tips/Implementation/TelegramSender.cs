using System;
using Patterns.Decorator.Tips.Abstract;
using Patterns.Decorator.Tips.Core;

namespace Patterns.Decorator.Tips.Implementation
{
    public class TelegramSender : INotificationSender
    {
        public void Send(Message message)
        {

            Console.WriteLine("Message sent.");

        }
    }
}
