using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Text;


namespace SParcialAP1.Entidades
{
    public class ProyectoDetalle
    {
       
        public ProyectoDetalle()
        {
            Id = 0;
            ProyectoId = 0;
            TareaId = 0;
            TipoTarea = string.Empty;
            Requerimiento = string.Empty;
            Tiempo = 0;
        }


        [Key]
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public int TareaId { get; set; }

        public string TipoTarea { get; set; }
        public string Requerimiento { get; set; }
        public double  Tiempo { get; set; }

        public virtual Proyecto proyecto { get; set; }
        public virtual Tarea tarea { get; set; }
 
    }
}
