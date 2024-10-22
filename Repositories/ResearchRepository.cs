using Gvz.Laboratory.ExperimentService.Abstractions;
using Gvz.Laboratory.ExperimentService.Entities;
using Gvz.Laboratory.ExperimentService.Exceptions;

namespace Gvz.Laboratory.ExperimentService.Repositories
{
    public class ResearchRepository : IResearchRepository
    {
        private readonly GvzLaboratoryExperimentServiceDbContext _context;

        public ResearchRepository(GvzLaboratoryExperimentServiceDbContext context)
        {
            _context = context;
        }

        public async Task<ResearchEntity> GetResearcheByIdAsync(Guid id)
        {
            var researchEntity = await _context.Researches.FindAsync(id) ?? throw new RepositoryException("Исследование не найдено");
            return researchEntity;
        }
    }
}
