using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPCD.Models
{
    public class Vaga
    {
        [Key]
        public int id_Vaga { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Descricao { get; set; }
        public string NomeEmpresa { get; set; } 
        public Empresa Empresa { get; set; }
        public string Benefícios { get; set; }
        public string CargaHoraria { get; set; }
    }
}
