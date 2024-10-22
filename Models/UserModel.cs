namespace Gvz.Laboratory.ExperimentService.Models
{
    public class UserModel
    {
        public Guid Id { get; }
        public List<ExperimentModel> Experiments { get; } = new List<ExperimentModel>();
        public string Surname { get; } = string.Empty;
        public string UserName { get; } = string.Empty;
        public string Patronymic { get; } = string.Empty;
    }
}
