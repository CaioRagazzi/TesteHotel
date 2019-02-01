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
        [HttpGet("{idHotel}/{destination}")]
        public IActionResult Index(int idHotel, int destination)
        {

            HotelDetails hotel = new HotelDetails().GetHotelDetails(destination,idHotel);

            return View(hotel);
        }
    }
}