using Gvz.Laboratory.ExperimentService.Dto;
using Gvz.Laboratory.ExperimentService.Entities;
using Mapster;

namespace Gvz.Laboratory.ExperimentService.Infrastructure
{
    public class RegisterMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<UserDto, UserEntity>()
                .RequireDestinationMemberSource(true);
        }
    }
}
