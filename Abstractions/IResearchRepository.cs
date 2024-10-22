using Gvz.Laboratory.ExperimentService.Entities;

namespace Gvz.Laboratory.ExperimentService.Abstractions
{
    public interface IResearchRepository
    {
        Task<ResearchEntity> GetResearcheByIdAsync(Guid id);
    }
}