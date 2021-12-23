using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPCD.Models
{
    public class Empresa
    {
        [Key]
        public int id_Empresa { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string RamoDeAtividade { get; set; }
        public Boolean Parceira { get; set; }
    }
}
