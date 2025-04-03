using System;
using API.DTOs;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repositories;

public class UserRepository(ApplicationDbContext context, IMapper mapper) : IUserRepository
{
    public async Task<MemberDto?> GetMemberAsync(string handle)
    {
        return await context.Users
            .Where(x => x.Handle == handle)
            .SingleOrDefaultAsync();
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
