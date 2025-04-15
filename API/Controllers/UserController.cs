using API.Data.Repositories;
using API.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController(IUnitOfWork unitOfWork) : BaseApiController
    {
        [HttpGet("{handle}")] // /api/users/{username}
        public async Task<ActionResult<MemberDto>> GetUserByHandle(string handle)
        {
            var user = await unitOfWork.UserRepository.GetMemberAsync(handle);

            return Ok(user);
        }
    }
}
