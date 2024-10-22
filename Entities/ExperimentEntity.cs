namespace Gvz.Laboratory.ExperimentService.Entities
{
    public class ExperimentEntity
    {
        public Guid Id { get; set; }
        public UserEntity User { get; set; } = new UserEntity();
        public ResearchEntity Researche { get; set; } = new ResearchEntity();
        public string Name { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
        public DateTime DateCreate { get; set; }
    }
}
