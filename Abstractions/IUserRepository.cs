using Gvz.Laboratory.ExperimentService.Entities;

namespace Gvz.Laboratory.ExperimentService.Abstractions
{
    public interface IUserRepository
    {
        Task<UserEntity> GetUserByIdAsync(Guid id);
    }
}