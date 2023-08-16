using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PsiicApi.Interfaces;
using PsiicApi.Model;
using PsiicApi.ViewModel;

namespace PsiicApi.Controllers
{
    [ApiController]
    [Route("api/v1/usuarios")]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        // GET: UsuarioController
        [HttpPost]
        public IActionResult Add(UsuarioViewModel usuarioViewModel)
        {
            var usuario = new Usuario(usuarioViewModel.Nome, usuarioViewModel.NomeUsuario);

            _usuarioRepositorio.Add(usuario);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = _usuarioRepositorio.GetAll();

            return Ok(usuarios);
        }

    }
}
