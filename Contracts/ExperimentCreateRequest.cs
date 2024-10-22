namespace Gvz.Laboratory.ExperimentService.Contracts
{
    public record ExperimentCreateRequest(
        Guid ResearchId,
        string Name,
        string Result
        );
}
