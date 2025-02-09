using MandrilApi.Helpers;
using MandrilApi.Models;
using MandrilApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MandrilApi.Controllers;

[ApiController] // esto es una anotacion para facilitarnos cosas tales como validar por nosotros que los datos de entrada sean correctos.
[Route("api/[controller]")] // para agregar una ruta endpoind especifica para acceder a los datos (se le pone controller pero es lo mismo que mandril.
public class MandrilController : ControllerBase // La clase MandrilController va a heredar de la clase ControllerBase para que nos agregue muchas funcionalidades tales como codigos de respuestas http y mas.
{
    [HttpGet] // Aqui se crea lo que viene siendo el metodo Get
    public ActionResult<IEnumerable<Mandril>> GetMandriles()
    {
        return Ok(MandrilDataStore.Current.Mandriles);
    }

    [HttpGet("{mandrilId}")] // Aqui se trae solo un mandril por id
    public ActionResult<Mandril> GetMandril(int mandrilId) // se le pone de parametro el mandrilId
    {
        var mandril = MandrilDataStore.Current.Mandriles.FirstOrDefault(x => x.Id == mandrilId);

        if (mandril == null)
            return NotFound(Mensajes.Mandril.NotFound);

        return Ok(mandril);
    }

    [HttpPost]
    public ActionResult<Mandril> PostMandril(MandrilInsert mandrilInsert)
    {
        var maxMandrilId = MandrilDataStore.Current.Mandriles.Max(x => x.Id);

        var mandrilNuevo = new Mandril()
        {
            Id = maxMandrilId + 1,
            Name = mandrilInsert.Name,
            Apellido = mandrilInsert.Apellido
        };

        MandrilDataStore.Current.Mandriles.Add(mandrilNuevo);

        return CreatedAtAction(nameof(GetMandril),
            new { mandrilId = mandrilNuevo.Id },
            mandrilNuevo
        );
    }

    [HttpPut("{mandrilId}")]
    public ActionResult<Mandril> PutMandril(int mandrilId, MandrilInsert mandrilInsert)
    {
        var mandril = MandrilDataStore.Current.Mandriles.FirstOrDefault(x => x.Id == mandrilId);

        if (mandril == null)
            return NotFound(Mensajes.Mandril.NotFound);

        mandril.Name = mandrilInsert.Name;
        mandril.Apellido = mandrilInsert.Apellido;

        return NoContent();
    }

    [HttpDelete("{mandrilId}")]
    public ActionResult<Mandril> DeleteMandril(int mandrilId)
    {
        var mandril = MandrilDataStore.Current.Mandriles.FirstOrDefault(x => x.Id == mandrilId);

        if (mandril == null)
            return NotFound(Mensajes.Mandril.NotFound);

        MandrilDataStore.Current.Mandriles.Remove(mandril);

        return NoContent();
    }
}