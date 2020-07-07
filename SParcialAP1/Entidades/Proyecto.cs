using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SParcialAP1.Entidades
{
        public class Proyecto
        {

            public Proyecto()
        {
            ProyectoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            TiempoTotal = 0;
            ProyectoDetalle = new List<ProyectoDetalle>();
        }

            [Key]
            public int ProyectoId { get; set; }
            public DateTime Fecha { get; set; } 
            public string Descripcion { get; set; }
            public double TiempoTotal { get; set; }

            [ForeignKey("ProyectoId")]
            public virtual List<ProyectoDetalle> ProyectoDetalle { get; set; }
        }
}
