using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class MedicosController : Controller
{
    public IActionResult Index(int? especialidade)
    {
        var medicos = ClinicaEmMemoria.Medicos.AsEnumerable();

        if (especialidade.HasValue)
        {
            medicos = medicos.Where(m => m.EspecialidadeId == especialidade.Value);
        }

        var resultado = medicos
            .OrderBy(m => m.Nome)
            .ToList();

        ViewBag.Especialidades = ClinicaEmMemoria.Especialidades
            .OrderBy(e => e.Nome)
            .ToList();
        ViewBag.EspecialidadeSelecionada = especialidade;

        return View(resultado);
    }

    public IActionResult Details(int id)
    {
        var medico = ClinicaEmMemoria.Medicos
            .FirstOrDefault(m => m.Id == id);

        if (medico is null)
        {
            return NotFound();
        }

        return View(medico);
    }
}
