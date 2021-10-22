using BestProjects.Domain.Business;
using BestProjects.Domain.IBusiness;
using BestProjects.Domain.Models.EntityDomain;
using BestProjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BestProjects.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioBusiness _usuarioBusiness;

        public HomeController(IUsuarioBusiness usuarioBusiness)
        {
            _usuarioBusiness = usuarioBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("[controller]/[action]")]
        public async Task<JsonResult> CadastrarContato([FromBody] Usuario usuario)
        {
            var resultado = await _usuarioBusiness.CadastrarContato(usuario);
            return Json(new { erro = resultado.erro, mensagem = resultado.mensagem });
        }
    }
}
