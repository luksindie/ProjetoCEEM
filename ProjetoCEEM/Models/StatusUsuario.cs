using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCEEM.Models
{
    public class StatusUsuario
    {
        [Key]
        public int StatusUsuarioId { get; set; }

        public string Descricao { get; set; }
    }
}