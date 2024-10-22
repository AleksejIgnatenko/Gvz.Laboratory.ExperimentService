using Gvz.Laboratory.ExperimentService.Abstractions;
using Gvz.Laboratory.ExperimentService.Dto;
using Gvz.Laboratory.ExperimentService.Entities;

namespace Gvz.Laboratory.ExperimentService.Infrastructure
{
    public class UserMapper : IUserMapper
    {
        public UserEntity? MapTo(UserDto user)
        {
            return user == null ? null : new UserEntity()
            {
                Id = user.Id,
                Surname = user.Surname,
                UserName = user.UserName,
                Patronymic = user.Patronymic
            };
        }
    }
}
