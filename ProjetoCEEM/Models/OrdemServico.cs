using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int StatusOrdemServicoId { get; set; }
        public int? PreCadastroId { get; set; }

        // Classes Virtuais
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Tecnico { get; set; }
        public virtual StatusOrdemServico StatusOrdemServico { get; set; }
        public virtual PreCadastro PreCadastro { get; set; }
    }
}