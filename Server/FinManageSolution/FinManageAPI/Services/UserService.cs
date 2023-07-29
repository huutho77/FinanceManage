using FinManageAPI.Database.Model;

namespace FinManageAPI.Services;

public class UserService : IUserService
{
    public string GenerateHashPassword(string password)
    {
        string hashPassword = "";
        if (string.IsNullOrEmpty(password)) { hashPassword = ""; }

        hashPassword = BCrypt.Net.BCrypt.HashPassword(password);
        return hashPassword;
    }
}