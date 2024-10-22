namespace Gvz.Laboratory.ExperimentService.Models
{
    public class ResearchModel
    {
        public Guid Id { get; }
        public List<ExperimentModel> Experiments { get; } = new List<ExperimentModel>();
        public string Name { get; } = string.Empty;
        public string ProductName { get; } = string.Empty;
        public string Conclusion { get; } = string.Empty;
    }
}
