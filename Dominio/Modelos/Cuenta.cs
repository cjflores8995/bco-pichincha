using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Modelos
{
    [Index(nameof(NumeroCuenta), IsUnique=true)]
    public class Cuenta
    {
        public Guid CuentaId { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string NumeroCuenta { get; set; }

        [StringLength(15, MinimumLength = 5)]
        [Required]
        public string TipoCuenta { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SaldoInicial { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 6)]
        public bool Estado { get; set; }
        
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Movimiento> MovimientosLista { get; set; }

    }
}