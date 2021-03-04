using Patterns.Decorator.Tips.Abstract;
using Patterns.Decorator.Tips.Core;

namespace Patterns.Decorator.Tips
{
    public class MultipleSender : INotificationSender
    {
        private readonly int _count;
        private readonly INotificationSender _sender;

        public MultipleSender(int count, INotificationSender sender)
        {
            _count = count;
            _sender = sender;
        }

        public void Send(Message message)
        {
            for (var i = 0; i < _count; i++)
            {
                _sender.Send(message);
            }
        }

    }
}
