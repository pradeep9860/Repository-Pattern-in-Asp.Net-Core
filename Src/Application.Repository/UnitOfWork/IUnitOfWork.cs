using Application.Repository.EntityFramework;
using System;

namespace Application 
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationDbContext Context { get; }
        void Commit();
    }
}
