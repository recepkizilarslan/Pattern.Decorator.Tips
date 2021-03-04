using System;
using Patterns.Decorator.Tips.Abstract;
using Patterns.Decorator.Tips.Core;

namespace Patterns.Decorator.Tips
{
    public class ExceptionDecorator : INotificationSender
    {
        private readonly INotificationSender _decorated;

        public ExceptionDecorator(INotificationSender decorated)
        {
            _decorated = decorated;
        }

        public void Send(Message message)
        {
            try
            {
                _decorated.Send(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

}
