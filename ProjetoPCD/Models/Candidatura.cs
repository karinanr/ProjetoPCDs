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
        public Empresa Empresa { get; set; }
        public Curso Curso { get; set; }
        public Vaga Vaga { get; set; }
        public Usuario Usuario { get; set; }
    }
}
