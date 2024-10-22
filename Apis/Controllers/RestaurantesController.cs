using Apis.Modelo;
using Apis.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantesController : ControllerBase
    {
        [HttpGet]
        [Route("InformacionRestaurante")]
        public ActionResult DevuelveRestaurante(int id)
        {
            try
            {
                RestauranteRepository repo = new RestauranteRepository();
                var restaurantes = repo.DevuelveRestaurantes();

                if (restaurantes.Any(x => x.Id == id))
                {

                    var info_restaurante = restaurantes.Find(x => x.Id == id);
                    return Ok(info_restaurante);

                }
                else
                {
                    return NotFound();
                }
            }catch(Exception e)
            {

                return BadRequest();
            }
        }


        [HttpGet]
        [Route("ListadoREstaurante")]
        public List<Restaurante> DevuelveListadoRestaurante()
        {
            RestauranteRepository repo = new RestauranteRepository();
            return repo.DevuelveRestaurantes();

        }
    }
}
