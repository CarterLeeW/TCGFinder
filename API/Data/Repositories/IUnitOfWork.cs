using System;

namespace API.Data.Repositories;

public interface IUnitOfWork
{
    IUserRepository UserRepository { get; }
    Task<bool> Complete();
    bool HasChanges();
}
