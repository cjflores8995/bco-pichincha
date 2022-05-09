using Aplicacion.Logica.Clientes;
using Aplicacion.Logica.Cuentas;
using Aplicacion.Logica.Movimientos;
using Aplicacion.Logica.Personas;
using AutoMapper;
using Dominio.Modelos;

namespace Aplicacion
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Persona, PersonaDto>().ForMember(x => x.Cliente, y => y.MapFrom(y => y.ClienteUnico));
            CreateMap<Cliente, ClienteDto>();
            CreateMap<Cuenta, CuentaDto>();
            CreateMap<Movimiento, MovimientoDto>();
        }
    }
}