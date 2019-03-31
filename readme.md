Sample MediatR
==============

Sample ASP.NET Core 3.0 web project which extracts from [identity Razor pages](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.0) all references 
to Microsoft.AspNetCore.Identity and move the code in some [MediatR](https://github.com/jbogard/MediatR) handlers.

For more details see [https://ovi.crisan.ca/2019/03/aspnet-core-identity-with-mediatr.html](https://ovi.crisan.ca/2019/03/aspnet-core-identity-with-mediatr.html).

Relevant code is in [Areas/Identity/MediatR](https://github.com/ovicrisan/SampleMediatR/tree/master/SampleMediatR/Areas/Identity/MediatR) folder, as well as updated 
Startup.cs and Login.cshtml.cs and Logout.cshtml.cs from [this folder](https://github.com/ovicrisan/SampleMediatR/tree/master/SampleMediatR/Areas/Identity/Pages/Account).
