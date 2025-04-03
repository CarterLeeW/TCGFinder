using API.Data.Repositories;
using API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpGet("{handle}")] // /api/users/{username}
        public async Task<ActionResult<MemberDto>> GetUserByHandle(string handle)
        {
            var user = await UserRepository
        }
    }
}
