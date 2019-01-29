using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Busca
    {
        [Display(Name = "Cidades")]
        public List<string> Cities { get; set; }
        [Display(Name = "Noites")]
        public int QtdNights { get; set; }
        [Display(Name = "Data Checkin")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime DateCheckIn { get; set; }
        [Display(Name = "Adultos")]
        public int QtdAdults { get; set; }
        [Display(Name = "Quartos")]
        public int QtdRooms { get; set; }
        [Display(Name = "Crianças")]
        public int ChildAge { get; set; }

        public List<string> GetCidades()
        {
            Cities = new List<string>()
            {
                "ORLANDO",
                "MIAMI"
            };

            return Cities;
        }
    }
}
