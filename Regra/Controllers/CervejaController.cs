using Microsoft.AspNetCore.Mvc;
using Regra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regra.Controllers
{
    public class CervejaController : Controller
    {
        private ICervejaRepository _cervejaRepository;
        private ICategoriaRepository _categoriaRepository;

        public CervejaController(ICervejaRepository cervejaRepository, ICategoriaRepository categoriaRepository)
        {
            _cervejaRepository = cervejaRepository;
            _categoriaRepository = categoriaRepository;

        }

        public IActionResult List()
        {
            ViewBag.Cerveja = "Cervejas";
            ViewData["Categoria"] = "Categoria";

            var cervejas = _cervejaRepository.Cervejas;
            return View(cervejas);
        }
    }
}
