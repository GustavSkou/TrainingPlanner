using System;
using System.Collections.Generic;
using System.Text;
using TrainingPlanner.Domain.Entities;

namespace TrainingPlanner.Infrastructure.Contracts
{
    public interface IUserRepository
    {
        Task<User> AddAsync(User user);
        Task<bool> DoesEmailExists(string mail);
    }
}
