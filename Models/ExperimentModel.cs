namespace Gvz.Laboratory.ExperimentService.Models
{
    public class ExperimentModel
    {
        public Guid Id { get; set; }
        public UserModel User { get; set; } = new UserModel();
        public ResearchModel Research { get; set; } = new ResearchModel();
        public string Name { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
        public DateTime DateCreate { get; set; }
    }
}
