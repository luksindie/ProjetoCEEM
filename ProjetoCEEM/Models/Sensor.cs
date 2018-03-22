using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCEEM.Models
{
    public class Sensor
    {
        [Key]
        public int SensorId { get; set; }

        public string Local { get; set; }

        // Chaves Estrangeiras
        public int EquipamentoId { get; set; }

        // Classes Virtuais
        public virtual Equipamento Equipamento { get; set; }
    }
}