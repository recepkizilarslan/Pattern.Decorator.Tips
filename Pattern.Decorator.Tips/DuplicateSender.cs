using System.Collections.Generic;
using Patterns.Decorator.Tips.Abstract;
using Patterns.Decorator.Tips.Core;

namespace Patterns.Decorator.Tips
{
    public class DuplicateSender : INotificationSender
    {
        private readonly IList<INotificationSender> _senders;
        public DuplicateSender(IList<INotificationSender> senders)
        {

            _senders = senders;
        }

        public void Send(Message message)
        {
            foreach (var send in _senders)
            {
                send.Send(message);
            }
        }
    }
}
