using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace robodog.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly DogStorage _dogStorage;

        public DogController(DogStorage dogStorage)
        {
            _dogStorage = dogStorage;
        }
        
        // PUT api/<DogController>/<Action>
        [HttpPut]
        public IActionResult UpdateDog([FromBody] UpdateDog dog)
        {
            _dogStorage.UpdateDog(dog);
            return NoContent();
        }

        // PUT api/<DogController>/<Action>
        [HttpDelete]
        public IActionResult DeleteDog([FromBody] Dog dog)
        {
            _dogStorage.DeleteDog(dog);
            return NoContent();
        }
    }
}
