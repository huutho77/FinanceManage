namespace FinManageAPI.Services;

public interface IUserService
{
    string GenerateHashPassword(string password);
}