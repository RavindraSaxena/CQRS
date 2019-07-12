using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS.Notification;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CQRS.NotificationHandler
{
    public class UserLoggedInHandler : INotificationHandler<UserLoggedIn>
    {
        private readonly ILogger<UserLoggedInHandler> logger;

        public UserLoggedInHandler(ILogger<UserLoggedInHandler> logger)
        {
            this.logger = logger;
        }
        public Task Handle(UserLoggedIn notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("Inside UserLoggedInHandler1");
            return Task.CompletedTask;
        }
    }
}
