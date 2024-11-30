using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    internal class EmailDecorator : INotification
    {
        private INotification notification;

        public EmailDecorator(INotification notification)
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
            return $"Email: {message}";
        }

    }
}
