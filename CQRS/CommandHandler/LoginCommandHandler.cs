using CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.CommandHandler
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResult>
    {
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly ILogger _logger;

        //public LoginCommandHandler(SignInManager<ApplicationUser> signInManager, ILogger logger)
        //{
        //    _signInManager = signInManager;
        //    _logger = logger;
        //}

        public async Task<LoginCommandResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            //var result = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, request.RememberMe, lockoutOnFailure: false);
            //if (result.Succeeded)
            //{
            //    _logger.LogInformation("User logged in.");
            //    return new LoginCommandResult() { IsSuccess = true };
            //}
            //if (result.RequiresTwoFactor)
            //{
            //    return new LoginCommandResult() { Need2FA = true };
            //}
            //if (result.IsLockedOut)
            //{
            //    _logger.LogWarning("User account locked out.");
            //    return new LoginCommandResult() { IsLockout = true };
            //}
            //else
            //{
            //    return new LoginCommandResult() { IsSuccess = false };
            //}
            return new LoginCommandResult();
        }
    }
}
