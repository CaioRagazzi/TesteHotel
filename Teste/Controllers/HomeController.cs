using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Teste.Models;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {

        [HttpPost]
        private async Task<List<HoteisFormatados>> CreateHotelAsync(Criteria criteria, Credential credential)
        {
            JsonResultModel hoteisRetorno = null;

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
            }

            List<Hotel> hoteis = new List<Hotel>();

            foreach (var item in hoteisRetorno.Hotels)
            {
                hoteis.Add(item);
            }

            List<HoteisFormatados> hoteisFormatados = new HoteisFormatados().GetHoteisFormatados(hoteis, criteria.DestinationId);

            return hoteisFormatados;

        }

        public async Task<IActionResult> Index(Busca busca)
        {

            if (busca.Cidades != null)
            {
                int destination;
                if (busca.Cidades.Contains("MIAMI"))
                {
                    destination = 1003944;
                }
                else
                {
                    destination = 1010106;
                }

                var searchRoom = new SearchRoom()
                {
                    ChildAges = new List<int> { busca.IdadeCriancas },
                    NumAdults = busca.QtdAdultos,
                    Quantity = busca.QtdQuartos
                };

                var credential = new Credential()
                {
                    Username = "candidato_t4w",
                    Password = "candit@!2019"
                };

                var criteria = new Criteria()
                {
                    DestinationId = destination,
                    NumNights = busca.QtdNoites,
                    CheckinDate = busca.DataCheckIn.ToString("yyyy-MM-dd"),
                    MainPaxCountryCodeNationality = "BR",
                    SearchRooms = new List<SearchRoom>()
                {
                    searchRoom
                }
                };

                var hoteis = await CreateHotelAsync(criteria, credential);

                List<string> cidades = busca.GetCidades();

                ViewBag.Cidades = new SelectList(cidades);
                ViewBag.Hoteis = hoteis;

                return View();
            }
            else
            {
                Busca busca2 = new Busca();
                List<string> cidades = busca2.GetCidades();

                ViewBag.Cidades = new SelectList(cidades);
                ViewBag.Hoteis = new List<HoteisFormatados>();

                return View();
            }
        }
    }
}