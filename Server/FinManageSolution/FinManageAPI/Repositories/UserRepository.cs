using FinManageAPI.Database.Model;
using FinManageAPI.Database.DTOs;
using FinManageAPI.Services;

using MongoDB.Driver;

namespace FinManageAPI.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<UserModel> _userCollection;
    private readonly UserService _userService;

    public UserRepository(IMongoDatabase mongoDB,
    UserService userService)
    {
        _userCollection = mongoDB.GetCollection<UserModel>("users");
        _userService = userService;
    }

    public async Task CreateNewUserAsync(CreateUserDTO newUserDTO)
    {
        UserModel newUser = new UserModel();

        newUser.Password = _userService.GenerateHashPassword(newUser.Password);
        await _userCollection.InsertOneAsync(newUser);
    }

    public async Task<UserModel> GetByIdAsync(string id)
    {
        UserModel user = await _userCollection.Find(item => item.Id == id).FirstOrDefaultAsync();
        return user;
    }
}