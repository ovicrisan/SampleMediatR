using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Identity;

namespace SampleMediatR.Areas.Identity.MediatR
{
    public class LoginPost : IRequest<SignInResult>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class LoginPostHandler : IRequestHandler<LoginPost, SignInResult>
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginPostHandler(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public Task<SignInResult> Handle(LoginPost request, CancellationToken cancellationToken)
        {
            return _signInManager.PasswordSignInAsync(request.Email, request.Password, request.RememberMe, lockoutOnFailure: true);
        }
    }
}
