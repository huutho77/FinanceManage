using FinManageAPI.Database.Model;

using MongoDB.Driver;

namespace FinManageAPI.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IMongoCollection<UserModel> _userCollection;

    public UserRepository(IMongoDatabase mongoDB)
    {
        _userCollection = mongoDB.GetCollection<UserModel>("users");
    }

    public async Task CreateNewPeopleAsync(UserModel newUser)
    {
        await _userCollection.InsertOneAsync(newUser);
    }

    public async Task<UserModel> GetByIdAsync(string id)
    {
        UserModel user = await _userCollection.Find(item => item.Id == id).FirstOrDefaultAsync();
        return user;
    }
}