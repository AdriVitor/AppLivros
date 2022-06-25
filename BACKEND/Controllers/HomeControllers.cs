using BACKEND.Data;
using BACKEND.Models;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers{

[ApiController]
public class HomeControllers : ControllerBase{
    
    [HttpGet("/")]
    public List<Livros> GetLivros([FromServices] AppDbContext context){
        return context.LivrosModels.ToList();
    }

    [HttpGet("/livros/{id:int}")]
    public ActionResult<Livros> GetIdLivro([FromServices] AppDbContext context,
                                           [FromRoute] int id){
        var model = context.LivrosModels.FirstOrDefault(x => x.Id == id);
        if(model != null){
            return model;
        }else{
            return NotFound(new{message = $"Produto com o Id {id} não encontrado"});
        }
    }   
}
}