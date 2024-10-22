using Gvz.Laboratory.ExperimentService.Models;

namespace Gvz.Laboratory.ExperimentService.Abstractions
{
    public interface IExperimentRepository
    {
        Task<Guid> CreateExperimentAsync(ExperimentModel experimentModel);
    }
}