using FinManageAPI.Database.DTOs;
using FinManageAPI.Database.Model;

namespace FinManageAPI.Repositories;

public interface IUserRepository
{
    Task<UserModel> GetByIdAsync(string id);
    Task CreateNewUserAsync(CreateUserDTO newUserDTO);
}