using TrainingPlanner.Application.DTOs;
using TrainingPlanner.Domain.Entities;

namespace TrainingPlanner.Application.Contracts
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(UserDTO dto);
    }
}