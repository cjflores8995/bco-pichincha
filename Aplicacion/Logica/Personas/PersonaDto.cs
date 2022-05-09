using Aplicacion.Logica.Clientes;
using Dominio.Modelos;

namespace Aplicacion.Logica.Personas
{
    public class PersonaDto
    {
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string Identificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public ClienteDto Cliente {get; set;}
    }
}