using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SampleMediatR.Areas.Identity.MediatR
{
    public class LoginGet: IRequest<IEnumerable<AuthenticationScheme>>
    {
    }

    public class LoginGetHandler : IRequestHandler<LoginGet, IEnumerable<AuthenticationScheme>>
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginGetHandler(SignInManager<IdentityUser> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public IHttpContextAccessor HttpContextAccessor { get; }

        public async Task<IEnumerable<AuthenticationScheme>> Handle(LoginGet request, CancellationToken cancellationToken)
        {
            await _httpContextAccessor.HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            return await _signInManager.GetExternalAuthenticationSchemesAsync();
        }
    }
}
