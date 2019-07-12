using CQRS.Notification;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.NotificationHandler
{
    public class UserLoggedInHandler2 : INotificationHandler<UserLoggedIn>
    {
        private readonly ILogger<UserLoggedInHandler2> logger;

        public UserLoggedInHandler2(ILogger<UserLoggedInHandler2> logger)
        {
            this.logger = logger;
        }
        public Task Handle(UserLoggedIn notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("Inside UserLoggedInHandler2");
            return Task.CompletedTask;
        }
    }
}
