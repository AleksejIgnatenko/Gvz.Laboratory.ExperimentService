namespace Gvz.Laboratory.ExperimentService.Entities
{
    public class ResearchEntity
    {
        public Guid Id { get; set; }
        public List<ExperimentEntity> Experiments { get; set; } = new List<ExperimentEntity>();
        public string Name { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string Conclusion { get; set; } = string.Empty;
    }
}
