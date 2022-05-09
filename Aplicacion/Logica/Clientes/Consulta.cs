using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Aplicacion.Logica.Personas;
using AutoMapper;
using Dominio.Modelos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Aplicacion.Logica.Clientes
{
    public class Consulta
    {
        public class ListaClientes : IRequest<List<PersonaDto>> { }

        public class Manejador : IRequestHandler<ListaClientes, List<PersonaDto>>
        {
            private readonly BcoDbContext _context;
            private readonly IMapper _mapper;
            public Manejador(BcoDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<PersonaDto>> Handle(ListaClientes request, CancellationToken cancellationToken)
            {
                var clientes = await _context.Persona.Include(x => x.ClienteUnico).ToListAsync();

                var clientesDto = _mapper.Map<List<Persona>, List<PersonaDto>>(clientes);

                return clientesDto;
            }
        }


    }
}