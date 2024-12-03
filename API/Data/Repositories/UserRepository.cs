using System;
using API.DTOs;
using API.Models;

namespace API.Data.Repositories;

public class UserRepository : IUserRepository
{
    public Task<MemberDto?> GetMemberAsync(string handle)
    {
        throw new NotImplementedException();
    }

    public Task<AppUser?> GetUserByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AppUser>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAllAsync()
    {
        throw new NotImplementedException();
    }

    public void Update(AppUser user)
    {
        throw new NotImplementedException();
    }
}
