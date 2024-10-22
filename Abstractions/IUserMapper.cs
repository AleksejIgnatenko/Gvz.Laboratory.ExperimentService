using Gvz.Laboratory.ExperimentService.Dto;
using Gvz.Laboratory.ExperimentService.Entities;
using Mapster;

namespace Gvz.Laboratory.ExperimentService.Abstractions
{
    [Mapper]
    public interface IUserMapper
    {
        UserEntity? MapTo(UserDto user);
    }
}