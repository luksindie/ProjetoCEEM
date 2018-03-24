using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoCEEM.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId {get;set;}

        public string Nome {get;set;}
        public string Login {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public DateTime DataCadastro {get;set;}
        public DateTime DataInativacao {get;set;}

        // Chaves Estrangeiras
        public int PerfilId {get;set;}
        public int StatusUsuarioId {get;set;}
        public int MotivoInativacaoId {get;set;}
        public int PreCadastroId {get;set;}

        // Classes Virtuais
        public virtual StatusUsuario StatusUsuario { get; set; }
        public virtual MotivoInativacao MotivoInativacao { get; set; }
        public virtual PreCadastro PreCadastro { get; set; }
        public virtual Perfil Perfil { get; set; }

        public bool EmailDisponivel(Context db)
        {
            return false;
        }

        public bool NomeUsuarioDisponivel(Context db)
        {
            return false;
        }
    }
}