using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SParcialAP1.Entidades
{
  public  class Tarea
    {
        public Tarea()
        {
            TareaId = 0;
            TipoTarea = string.Empty;
            Requerimiento = string.Empty;
            Tiempo = 0;

        }

        [Key]
        public int TareaId { get; set; }
        public string TipoTarea { get; set; }
        public string Requerimiento { get; set; }
        public double Tiempo { get; set; }
    }
}
