using System;
using Patterns.Decorator.Tips.Abstract;
using Patterns.Decorator.Tips.Core;

namespace Patterns.Decorator.Tips.Implementation
{
    public class SmsSender : INotificationSender
    {
        public void Send(Message message)
        {

            Console.WriteLine("Text message sent");

        }
    }
}
