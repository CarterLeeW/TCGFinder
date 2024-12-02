using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AccountController : BaseApiController
{
    [Authorize]
    [HttpPost("logout")]
    public async Task<ActionResult> Logout(SignInManager<IdentityUser> signInManager, [FromBody] object empty)
    {
        if (empty != null)
    {
        await signInManager.SignOutAsync(); // this is handled by Identity Framework
        return Ok();
    }
    return Unauthorized();
    }
}
