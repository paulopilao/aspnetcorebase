using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBase.Models;
using AspNetCoreBase.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBase.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var model = _service.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pessoa pessoa)
        {
            _service.Add(pessoa);
            return RedirectToAction("Index");
        }
    }
}