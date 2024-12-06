using System;
using API.Data.Repositories;
using API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Authorize]
public class UserController(
    IUserRepository userRepository
) : BaseApiController
{
    [HttpGet("{handle}")]
    public async Task<ActionResult<MemberDto>> GetUser(string handle)
    {
        var user = await userRepository.GetMemberAsync(handle);

        if (user == null) return NotFound();
        return user;
    }
}
