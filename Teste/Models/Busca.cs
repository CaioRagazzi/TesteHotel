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
        public string IdadeCriancas { get; set; }

        /// <summary>
        /// Método responsável por retornar todas as cidades que podem ser pesquisadas para a busca de hotéis.
        /// </summary>
        /// <returns>Retorna uma lista de strings contendo as cidades.</returns>
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
