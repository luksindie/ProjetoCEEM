using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoCEEM.ViewModels
{
    [NotMapped]
    public class PreCadastroViewModel
    {
        [Required]
        public string NomeCadastro { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(9)]
        [MinLength(9)]
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Numero { get; set; }
    }
}