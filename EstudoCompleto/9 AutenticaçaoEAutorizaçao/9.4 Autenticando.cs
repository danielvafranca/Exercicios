//Criar pasta LoginViewModel no ViewModel

using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe a senha")]
    public string Password { get; set; }


} // no accoun cvontroller

// using Blog.Data;
// using Blog.Extension;
// using Blog.Extensions;
// using Blog.Models;
// using Blog.Services;
// using Blog.ViewModels;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using SecureIdentity.Password;

// namespace Blog.Controllers;

// [ApiController]
// public class AccountController : ControllerBase
// {
//     [HttpPost("v1/accounts/")]
//     public async Task<IActionResult> Post(
//         [FromBody] RegisterViewModel model,
//         [FromServices] BlogDataContext context)
//     {
//         if (!ModelState.IsValid)
//             return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

//         var user = new User
//         {
//             Name = model.Name,
//             Email = model.Email,
//             Slug = model.Email.Replace("@", "-").Replace(".", "-")
//         };

//         //Gerando senha forte
//         var password = PasswordGenerator.Generate(25);
//         user.PasswordHash = PasswordHasher.Hash(password);

//         try
//         {
//             await context.Users.AddAsync(user);
//             await context.SaveChangesAsync();

//             return Ok(new ResultViewModel<dynamic>(new
//             {
//                 user = user.Email,
//                 password
//             }));
//         }
//         catch (DbUpdateException)
//         {
//             return StatusCode(400, new ResultViewModel<string>("ERR-15 - Este E-mail já está cadastrado"));
//         }
//         catch
//         {
//             return StatusCode(500, new ResultViewModel<string>("ERR-17 - Falha interna no servidor"));
//         }
//     }

    [HttpPost("v1/accounts/login")]
    public async Task<IActionResult> Login(
        [FromBody] LoginViewModel model,
        [FromServices] BlogDataContext context,
        [FromServices] TokenService tokenService)
    {
        if (!ModelState.IsValid)
            return BadRequest(new ResultViewModel<string>(ModelState.GetErrors()));

        var user = await context // buscando usuario
            .Users
            .AsNoTracking()
            .Include(x => x.Roles)
            .FirstOrDefaultAsync(x => x.Email == model.Email);// comparando e-mail

        if (user == null)
            return StatusCode(401, new ResultViewModel<string>("Usuário ou senha inválidos"));

        if (!PasswordHasher.Verify(user.PasswordHash, model.Password))
            return StatusCode(401, new ResultViewModel<string>("Usuário ou senha inválidos"));

        try
        {
            var token = tokenService.GenerateToken(user);
            return Ok(new ResultViewModel<string>(token, null));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<string>("05X04 - Falha interna no servidor"));
        }
    }
}