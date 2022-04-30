using KissLog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RH_DELIRIO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RH_DELIRIO.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IKLogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //_logger = logger;

            _logger = Logger.Factory.Get();
        }

        
        public IActionResult Index()
        {
            _logger.Debug("Realizando log do Index");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.Debug("Realizando log do Privacy");
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelErro = new ErrorViewModel();

            if (id == 500)
            {
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde ou contate a equipe de TI";
                modelErro.Titulo = "Ocorreu em erro!";
                modelErro.ErroCode = id;

            }
            else if (id==404)
            {
                modelErro.Mensagem = "A página que está procurando não existe!<br/> Em caso de dúvidas entre em contato com a equipe de TI";
                modelErro.Titulo = "Ops! Página não encontrada.";
                modelErro.ErroCode = id;
            }
            else if(id==403)
            {
                modelErro.Mensagem = "Você não tem permissão para fazer isso!";
                modelErro.Titulo = "Acesso Negado";
                modelErro.ErroCode = id;
            }
            else
            {
                return StatusCode(404);
            }

            
            {
                return View("Error");
            }
        }
    }
}

