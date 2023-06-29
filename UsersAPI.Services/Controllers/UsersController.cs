using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Criar conta de usuário
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }

        /// <summary>
        /// Alterar dados de usuário
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        /// <summary>
        /// Excluir conta de usuário
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        /// <summary>
        /// Consultar os dados de usuário
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
