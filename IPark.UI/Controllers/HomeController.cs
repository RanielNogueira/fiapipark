using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IPark.UI.Models;
using IPark.Service.Interfaces;
using IPark.Domain;
using IPark.Service.Data;

namespace IPark.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteRepository repo;

        public HomeController(IClienteRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {

            //Cliente cli = new Cliente { Nome = "Raniel", Cpf = 03961082375, Email = "raniel.nogueira@live.com", Telefone = "11986376171" };

            //repo.Insert(cli);

            return View();
        }

        [HttpGet]
        public IActionResult GetInfo()
        {

            return Json(repo.GetAll());
        }
    }
}
