using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Logica.Clientes;
using Aplicacion.Logica.Personas;
using Dominio.Modelos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    // https://localhost:<PORT>/api/Cliente
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : MiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<PersonaDto>>> Obtener()
        {
            return await Mediator.Send(new Consulta.ListaClientes());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonaDto>> ObtenerPorId(Guid id)

        {
            return await Mediator.Send(new ConsultaPorId.Consulta { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await Mediator.Send(data);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Editar(Guid id, Editar.Ejecuta data)
        {
            data.ClienteId = id;
            return await Mediator.Send(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Eliminar(Guid id)
        {
            return await Mediator.Send(new Eliminar.Ejecuta { ClienteId = id });
        }
    }
}