using System;
using Patterns.Decorator.Tips.Abstract;
using Patterns.Decorator.Tips.Core;

namespace Patterns.Decorator.Tips
{
    public class SuccessorSender : INotificationSender
    {
        private readonly INotificationSender _first;
        private readonly INotificationSender _second;

        public SuccessorSender(INotificationSender first, INotificationSender second)
        {
            _first = first;
            _second = second;
        }

        public void Send(Message message)
        {
            try
            {
                _first.Send(message);
            }
            catch (Exception e)
            {
                _second.Send(message);
            }
        }
    }
}
