using Patterns.Decorator.Tips.Core;

namespace Patterns.Decorator.Tips.Abstract
{
    public interface INotificationSender
    {
        public void Send(Message message);
    }
}
