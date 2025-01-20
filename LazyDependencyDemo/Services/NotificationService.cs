using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyDependencyDemo.Services
{
    public class NotificationService : INotificationService
    {
        public void SendNotification(int userId, string message)
        {
            Console.WriteLine($"Sending notification to User {userId}: {message}");
        }
    }
}
