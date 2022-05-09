using System;
using System.Collections.Generic;
using Aplicacion.Logica.Cuentas;
using Dominio.Modelos;

namespace Aplicacion.Logica.Clientes
{
    public class ClienteDto
    {
        public Guid ClienteId { get; set; }
        public string Password { get; set; }
        public bool Estado { get; set; }
    }
}