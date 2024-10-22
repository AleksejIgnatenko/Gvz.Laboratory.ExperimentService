using Gvz.Laboratory.ExperimentService.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gvz.Laboratory.ExperimentService
{
    public class GvzLaboratoryExperimentServiceDbContext : DbContext
    {
        public DbSet<ExperimentEntity> Experiments { get; set; }
        public DbSet<ResearchEntity> Researches { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public GvzLaboratoryExperimentServiceDbContext(DbContextOptions<GvzLaboratoryExperimentServiceDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
