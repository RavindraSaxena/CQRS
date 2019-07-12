using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Notification
{
    public class UserLoggedIn: INotification
    {
        public string UserName { get; set; }
    }
}
