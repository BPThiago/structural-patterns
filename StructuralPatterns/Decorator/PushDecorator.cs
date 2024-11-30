using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    internal class PushDecorator : INotification
    {
        private INotification notification;

        public PushDecorator(INotification notification)
        {
            this.notification = notification;
        }

        public void Send(string message)
        {
            string decoratedMessage = DecorateMessage(message);
            notification.Send(decoratedMessage);
        }

        private string DecorateMessage(String message)
        {
            return $"Push: {message}";
        }
    }
}
