using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    public class Movimiento
    {
        public Guid MovimientoId {get; set;}
        public DateTime Fecha {get; set;}
        public string TipoMovimiento {get; set;}
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor {get; set;}
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Saldo {get; set;}
        public Guid CuentaId {get; set;}
        public Cuenta Cuenta {get; set;}
    }
}