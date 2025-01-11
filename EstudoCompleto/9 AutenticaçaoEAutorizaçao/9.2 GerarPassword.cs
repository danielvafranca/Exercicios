// //No AccountController


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

           var password = PasswordGenerator.Generate(25);
           user.PasswordHash = PasswordHasher.Hash(password);

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
//             return StatusCode(400, new ResultViewModel<string>("05X99 - Este E-mail já está cadastrado"));
//         }
//         catch
//         {
//             return StatusCode(500, new ResultViewModel<string>("05X04 - Falha interna no servidor"));
//         }
//     }
// // Na pasta viewModel/REGISTREViewModel

// using System.ComponentModel.DataAnnotations;

// namespace Blog.ViewModels
// {
//     public class RegisterViewModel
//     {
//         [Required(ErrorMessage = "O Nome é Obrigatório")]
//         public string Name { get; set; }

//         [Required(ErrorMessage = "O E-mail é Obrigatório")]
//         [EmailAddress(ErrorMessage =" O E-mail é Invalido")]
//         public string Email { get; set; }
//     }
// }
// //