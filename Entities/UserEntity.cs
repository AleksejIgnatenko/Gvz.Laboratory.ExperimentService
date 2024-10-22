namespace Gvz.Laboratory.ExperimentService.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public List<ExperimentEntity> Experiments { get; set; } = new List<ExperimentEntity>();
        public string Surname { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Patronymic { get; set; } = string.Empty;
    }
}
