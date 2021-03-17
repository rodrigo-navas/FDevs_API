using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.Services.User
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _repository;

        public UserService(IRepository<UserEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserEntity> GetAsync(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            return await _repository.SelectAsync();
        }

        public async Task<UserEntity> PostAsync(UserEntity userEntity)
        {
            return await _repository.InsertAsync(userEntity);
        }

        public async Task<UserEntity> PutAsync(UserEntity userEntity)
        {
            return await _repository.UpdateAsync(userEntity);
        }
    }
}
