using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserEntity> GetAsync(Guid id);
        Task<IEnumerable<UserEntity>> GetAllAsync();
        Task<UserEntity> PostAsync(UserEntity userEntity);
        Task<UserEntity> PutAsync(UserEntity userEntity);
        Task<bool> DeleteAsync(Guid id);
    }
}
