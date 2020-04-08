using System;
using IPark.Domain;
using IPark.Service.Interfaces;
using IPark.UI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IPark.UI.Controllers
{
    [LoginFilter]
    [Authorize]
    public class LocatarioController : Controller
    {
        public readonly ILocatarioRepository repoLocatario;

        public LocatarioController(ILocatarioRepository repoLocatario)
        {
            this.repoLocatario = repoLocatario;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar([FromBody]Locatario cliente)
        {
            try
            {
                repoLocatario.Insert(cliente);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.GetBaseException());
            }
        }

        [HttpPost]
        public ActionResult Editar([FromBody]Locatario cliente)
        {
            try
            {
                repoLocatario.Update(cliente);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.GetBaseException());
            }
        }

        [HttpPost]
        public ActionResult Remover([FromBody]int id)
        {
            try
            {
                repoLocatario.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.GetBaseException());
            }
        }

        [HttpGet]
        public ActionResult Listar()
        {
            try
            {
                return Ok(repoLocatario.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.GetBaseException());
            }
        }
    }
}