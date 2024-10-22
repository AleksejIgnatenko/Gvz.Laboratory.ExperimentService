using Gvz.Laboratory.ExperimentService.Abstractions;
using Gvz.Laboratory.ExperimentService.Entities;
using Gvz.Laboratory.ExperimentService.Exceptions;

namespace Gvz.Laboratory.ExperimentService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly GvzLaboratoryExperimentServiceDbContext _context;

        public UserRepository(GvzLaboratoryExperimentServiceDbContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> GetUserByIdAsync(Guid id)
        {
            var userEntity = await _context.Users.FindAsync(id) ?? throw new RepositoryException("Пользователь не найден");
            return userEntity;
        }
    }
}
