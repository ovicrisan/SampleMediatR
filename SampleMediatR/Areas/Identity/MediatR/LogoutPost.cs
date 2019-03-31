using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SampleMediatR.Areas.Identity.MediatR
{
    public class LogoutPost : IRequest
    {
    }

    public class LogoutPostHandler : IRequestHandler<LogoutPost, Unit>
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public LogoutPostHandler(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(LogoutPost request, CancellationToken cancellationToken)
        {
            await _signInManager.SignOutAsync();
            return Unit.Value;
        }
    }

}
