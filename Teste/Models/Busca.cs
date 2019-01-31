using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    /// <summary>
    /// Classe responsável por definir um padrão de entrada de dados na aplicação.
    /// </summary>
    public class Busca
    {
        [Display(Name = "Cidades")]
        public List<string> Cidades { get; set; }
        [Display(Name = "Noites")]
        [Range(1,31)]
        public int QtdNoites { get; set; }
        [Display(Name = "Data Checkin")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime DataCheckIn { get; set; }
        [Display(Name = "Adultos")]
        public int QtdAdultos { get; set; }
        [Display(Name = "Quartos")]
        public int QtdQuartos { get; set; }
        [Display(Name = "Crianças")]
        [RegularExpression(@"[^1-9\;]+", ErrorMessage = "UPRN must be numeric")]
        public string IdadeCriancas { get; set; }

        public List<string> GetCidades()
        {
            Cidades = new List<string>()
            {
                "ORLANDO",
                "MIAMI"
            };

            return Cidades;
        }
    }
}
