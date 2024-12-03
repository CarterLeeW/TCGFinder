using System;
using API.DTOs;
using API.Models;

namespace API.Data.Repositories;

public interface IUserRepository
{
    void Update(AppUser user);
    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser?> GetUserByIdAsync(int id);
    Task<MemberDto?> GetMemberAsync(string handle);
}
