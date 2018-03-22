using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCEEM.Models
{
    public class PreCadastro
    {
        [Key]
        public int PreCadastroId { get; set; }

        public string NomeCadastro { get; set; }
        public DateTime DataCriacao { get; set; }
        public Guid CodigoPreCadastro { get; set; }
    }
}