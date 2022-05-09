using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Modelos
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Password { get; set; }
        
        [StringLength(6, MinimumLength = 8)]
        public bool Estado { get; set; }
        public Guid PersonaId { get; set; }
        public Persona Persona { get; set; }
        ICollection<Cuenta> CuentasLista { get; set; }
    }
}