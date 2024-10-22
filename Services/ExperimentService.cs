using Gvz.Laboratory.ExperimentService.Abstractions;

namespace Gvz.Laboratory.ExperimentService.Services
{
    public class ExperimentService
    {
        private readonly IExperimentRepository _experimentRepository;

        public ExperimentService(IExperimentRepository experimentRepository)
        {
            _experimentRepository = experimentRepository;
        }

        //public async Task<Guid> CreateExperimentAsync(Guid experimentId, Guid userId, Guid ResearchId, string name, string result)
        //{

        //}
    }
}
