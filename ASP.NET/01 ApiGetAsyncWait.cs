using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    [ApiController]
    public class CategoryController: ControllerBase
    {
        [HttpGet("v1/categories")]// Sempre em minusculo e no plural... ex [HttpGet("user-roles")] localhost:PORT/v1/categories
        public async Task<IActionResult> GetAsync([FromServices] BlogDataContext context)
        {// colocamos o await pois  esta pegando a lista de categorias e está retornando uma tarefa em cima de uma tarefa.
            var categories = await  context.Categories.ToListAsync();
            return Ok(categories);
        }

        //[HttpGet("v2/categories")]// Sempre em minusculo e no plural... ex [HttpGet("user-roles")]  localhost:PORT/v2/categories
        //public IActionResult Get2([FromServices] BlogDataContext context)
        //=> Ok(context.Categories.ToList());


    }