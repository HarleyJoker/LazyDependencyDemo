using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyDependencyDemo.Services
{
    public class UserService : IUserService
    {
        private readonly Lazy<INotificationService> _notificationService;

        public UserService(Lazy<INotificationService> notificationService)
        {
            _notificationService = notificationService;
        }

        public void GetUserAndNotify(int userId)
        {
            Console.WriteLine($"Retrieving user {userId}...");

            // Simulate retrieving user info
            string userName = "John Doe";

            Console.WriteLine($"User {userId} retrieved: {userName}");

            // Lazily send notification
            _notificationService.Value.SendNotification(userId, $"Hello {userName}, welcome back!");
        }
    }
}
