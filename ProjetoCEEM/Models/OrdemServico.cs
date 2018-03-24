using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoCEEM.Models
{
    public class OrdemServico
    {
        [Key]
        public int OrdemServicoId { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }

        // Chaves Estrangeiras
        public int? UsuarioId { get; set; }
        public int? TecnicoId { get; set; }
        public int StatusOrdemServicoId { get; set; }
        public int? PreCadastroId { get; set; }

        // Classes Virtuais
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("TecnicoId")]
        public virtual Usuario Tecnico { get; set; }
        public virtual StatusOrdemServico StatusOrdemServico { get; set; }
        public virtual PreCadastro PreCadastro { get; set; }
    }
}