using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Teste.Models;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Busca busca = new Busca();
            List<string> cidades = busca.GetCidades();

            ViewBag.Cities = new SelectList(cidades);
           
            return View();
        }

        [HttpPost]
        private async Task<List<Hotel>> CreateHotelAsync(Criteria criteria, Credential credential)
        {
            JsonResultModel hoteisRetorno = null;
            List<Hotel> hoteis = new List<Hotel>();

            JsonRequestModel hotels = new JsonRequestModel
            {
                Credential = credential,
                Criteria = criteria
            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://pp.cangooroo.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.PostAsJsonAsync("ws/rest/hotel.svc/Search", hotels);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync().Result;
                    hoteisRetorno = JsonConvert.DeserializeObject<JsonResultModel>(jsonResult);
                }

                foreach (var item in hoteisRetorno.Hotels)
                {
                    hoteis.Add(item);
                }

                return hoteis;
            }            
        }


        public async Task<IActionResult> GetHotels(Busca busca)
        {
            int destination;
            if (busca.Cities.Contains("MIAMI"))
            {
                destination = 1003944;
            }
            else
            {
                destination = 1010106;
            }

            var searchRoom = new SearchRoom()
            {
                ChildAges = new List<int> { busca.ChildAge },
                NumAdults = busca.QtdAdults,
                Quantity = busca.QtdRooms
            };

            var credential = new Credential()
            {
                Username = "candidato_t4w",
                Password = "candit@!2019"
            };

            var criteria = new Criteria()
            {
                DestinationId = destination,
                NumNights = busca.QtdNights,
                CheckinDate = busca.DateCheckIn.ToString("yyyy-MM-dd"),
                MainPaxCountryCodeNationality = "BR",
                SearchRooms = new List<SearchRoom>()
                {
                    searchRoom
                }
            };

            var hoteis = await CreateHotelAsync(criteria, credential);

            return View("List", hoteis);
        }

        public IActionResult HotelsDetails(int hotelId)
        {
            List<HotelDetails> hotelDetails= new List<HotelDetails>();
            using (StreamReader sr = new StreamReader(@"C:\Users\g0ysb\source\repos\Teste\Teste\Util\HOTELS.json"))
            {
                hotelDetails = JsonConvert.DeserializeObject<List<HotelDetails>>(sr.ReadToEnd());
            }

            var hotel = hotelDetails.Find(item => item.id == hotelId);

            return View(hotel);
        }
    }
}