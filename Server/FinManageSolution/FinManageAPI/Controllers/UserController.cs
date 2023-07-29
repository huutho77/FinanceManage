using Microsoft.AspNetCore.Mvc;

using FinManageAPI.Repositories;
using FinManageAPI.Database.Model;
using FinManageAPI.Database.DTOs;

namespace FinManageAPI.Controllers;

[ApiController]
[Route("api/users/")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserRepository _iUserRepository;

    public UserController(ILogger<UserController> logger, IUserRepository iUserRepository)
    {
        _logger = logger;
        _iUserRepository = iUserRepository;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(string id)
    {
        UserModel user = await _iUserRepository.GetByIdAsync(id);
        return Ok(user);
    }

    [HttpPost("create-new-user")]
    public async Task<IActionResult> CreateUser(CreateUserDTO newUserDTO)
    {
        await _iUserRepository.CreateNewUserAsync(newUserDTO);
        return Ok();
    }
}