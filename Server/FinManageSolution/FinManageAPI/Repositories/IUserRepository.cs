using FinManageAPI.Database.Model;

namespace FinManageAPI.Repositories;

public interface IUserRepository
{
    Task<UserModel> GetByIdAsync(string id);
    Task CreateNewPeopleAsync(UserModel newUser);
}