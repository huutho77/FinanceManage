namespace FinManageAPI.Database.DTOs;

public class CreateUserDTO
{
    public string UserName { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
}