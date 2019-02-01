using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Teste.Models;

namespace Teste.Controllers
{
    public class HotelDetailController : Controller
    {
        /// <summary>
        /// Action responsável por mostrar os detalhes do hotel.
        /// </summary>
        /// <param name="idHotel">ID do hotel que foi clicado la lista</param>
        /// <param name="destination">Id do destino</param>
        /// <returns>Retornar para view que mostra detalhes do hotel</returns>
        [HttpGet("{idHotel}/{destination}")]
        public IActionResult Index(int idHotel, int destination)
        {

            HotelDetails hotel = new HotelDetails().GetHotelDetails(destination,idHotel);

            return View(hotel);
        }
    }
}