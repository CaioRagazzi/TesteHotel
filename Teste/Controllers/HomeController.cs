using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        [HttpPost]
        private async Task<List<HoteisFormatados>> CreateHotelAsync(Criteria criteria, Credential credential)
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

                HotelDetails allHotels = new HotelDetails();

                var hotelDetails = allHotels.GetAllHotels(criteria.DestinationId);

                var alls = (from x in hoteis
                            join y in hotelDetails on x.HotelId equals y.id
                            select new { x.Rooms, y.name, y.chainName, y.cityNamePT, y.address, y.website }).ToList();

                List<HoteisFormatados> hoteisFormatados = new List<HoteisFormatados>();
                HoteisFormatados formatados;

                foreach (var item in alls)
                {
                    formatados = new HoteisFormatados()
                    {
                        Rooms = item.Rooms,
                        NomeHotel = item.name,
                        ChainName = item.chainName,
                        CityNamePT = item.cityNamePT,
                        Endereco = item.address,
                        WebSite = item.website
                    };

                    hoteisFormatados.Add(formatados);
                }

                return hoteisFormatados;
            }
        }


        public async Task<IActionResult> Index(Busca busca)
        {

            if (busca.Cities != null)
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

                List<string> cidades = busca.GetCidades();

                ViewBag.Cities = new SelectList(cidades);
                ViewBag.Hoteis = hoteis;

                return View();
            }
            else
            {
                Busca busca2 = new Busca();
                List<string> cidades = busca2.GetCidades();

                ViewBag.Cities = new SelectList(cidades);
                ViewBag.Hoteis = new List<HoteisFormatados>();

                return View();
            }
        }
    }
}