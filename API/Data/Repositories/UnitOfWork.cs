using System;

namespace API.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public IUserRepository UserRepository => throw new NotImplementedException();

    public Task<bool> Complete()
    {
        throw new NotImplementedException();
    }

    public bool HasChanges()
    {
        throw new NotImplementedException();
    }
}
