using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPCD.Models
{
    public class Candidatura
    {
        [Key]
        public int id_Candidatura { get; set; }
        public string NomeEmpresa { get; set; }
        public Empresa Empresa { get; set; }
        public string NomeCurso { get; set; }
        public Curso Curso { get; set; }
        public string NomeVaga { get; set; }
        public Vaga Vaga { get; set; }
        public string NomeUsuario { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataCandidatura { get; set; }
        
    }
}
