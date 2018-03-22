using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCEEM.Models
{
    public class Contato
    {
        [Key]
        public int ContatoId { get; set; }

        public string Descricao { get; set; }

        // Chaves Estrangeiras
        public int? PreCadastroId { get; set; }
        public int? UsuarioId { get; set; }
        public int TipoContatoId { get; set; }

        // Classes Virtuais
        public virtual PreCadastro PreCadastro { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual TipoContato TipoContato { get; set; }
    }
}