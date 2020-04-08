using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPark.Domain;
using IPark.Service.Data;
using IPark.Service.Interfaces;
using IPark.UI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IPark.UI.Controllers
{
    [LoginFilter]
    [Authorize]
    public class ClienteController : Controller
    {
        public readonly IClienteRepository repoCliente;

        public ClienteController(IClienteRepository repoCliente)
        {
            this.repoCliente = repoCliente;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar([FromBody]Cliente cliente)
        {
            try
            {
                repoCliente.Insert(cliente);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.GetBaseException());
            }
        }

        [HttpPost]
        public ActionResult Editar([FromBody]Cliente cliente)
        {
            try
            {
                repoCliente.Update(cliente);
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
                repoCliente.Delete(id);
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
                return Ok(repoCliente.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.GetBaseException());
            }
        }
    }
}