using Gvz.Laboratory.ExperimentService.Abstractions;
using Gvz.Laboratory.ExperimentService.Entities;
using Gvz.Laboratory.ExperimentService.Models;

namespace Gvz.Laboratory.ExperimentService.Repositories
{
    public class ExperimentRepository : IExperimentRepository
    {
        private readonly GvzLaboratoryExperimentServiceDbContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IResearchRepository _researchRepository;

        public ExperimentRepository(GvzLaboratoryExperimentServiceDbContext context, IUserRepository userRepository = null, IResearchRepository researchRepository = null)
        {
            _context = context;
            _userRepository = userRepository;
            _researchRepository = researchRepository;
        }

        public async Task<Guid> CreateExperimentAsync(ExperimentModel experimentModel)
        {
            ExperimentEntity experimentEntity = new ExperimentEntity
            {
                Id = experimentModel.Id,
                User = await _userRepository.GetUserByIdAsync(experimentModel.User.Id),
                Researche = await _researchRepository.GetResearcheByIdAsync(experimentModel.Research.Id),
                Name = experimentModel.Name,
                Result = experimentModel.Result,
                DateCreate = DateTime.UtcNow,
            };

            await _context.Experiments.AddAsync(experimentEntity);
            await _context.SaveChangesAsync();

            return experimentEntity.Id;
        }
    }
}
