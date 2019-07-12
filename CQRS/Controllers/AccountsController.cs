using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Commands;
using CQRS.Notification;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AccountsController> logger;

        public AccountsController(IMediator mediator, ILogger<AccountsController> logger)
        {
            _mediator = mediator;
            this.logger = logger;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginCommand command)
        {
            logger.LogInformation("Before user validation.");
            var result = await _mediator.Send(command);
            logger.LogInformation("After user validation.");
            if (!result.IsSuccess)
            {

                logger.LogWarning("User authentication failed.");
                ModelState.AddModelError("UserName", "Invalid login attempt.");
                return BadRequest(ModelState);

            }
            await _mediator.Publish<UserLoggedIn>(new UserLoggedIn { UserName = result.UserName });
            return Ok();
        }
    }
}
