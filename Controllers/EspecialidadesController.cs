using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
    public IActionResult Index()
    {
        var quantidadePorEspecialidade = ClinicaEmMemoria.Medicos
            .GroupBy(m => m.EspecialidadeId)
            .ToDictionary(g => g.Key, g => g.Count());

        ViewBag.QuantidadePorEspecialidade = quantidadePorEspecialidade;

        var especialidades = ClinicaEmMemoria.Especialidades
            .OrderBy(e => e.Nome)
            .ToList();

        return View(especialidades);
    }
}
