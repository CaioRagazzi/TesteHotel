using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Teste.Models;

namespace Teste.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Método responsável por consultar a API de hoteis e retornar uma lista já formatada e relacionada com os detalhes dos hoteis.
        /// </summary>
        /// <param name="criteria">Detalhes da busca de hoteis ex.: Destino, número de noites, data de checkin e etc.</param>
        /// <param name="credential">Usuário e senha para consultar a API.</param>
        /// <returns>Retornar uma Lista de HoteisFormatados</returns>
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
        /// <summary>
        /// Action principal.
        /// </summary>
        /// <param name="busca">Recebe exatamente todos os parâmetros que são realizados na busca.</param>
        /// <returns>Realiza o retorno para a view Index desse controller. Nela também são passadaws ViewBags para alimentar o dropdownlist e a table</returns>
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

                List<string> idades = new List<string>();
                if (busca.IdadeCriancas != null)
                {
                    idades = busca.IdadeCriancas.Split(';').ToList();
                }

                List<int> idadesInt;

                try
                {
                    idadesInt = idades.Select(int.Parse).ToList();
                }
                catch (Exception)
                {

                    throw new System.ArgumentException("Só são aceitos números e ; para as idades das crianças");
                }
                

                var searchRoom = new SearchRoom()
                {
                    ChildAges = idadesInt,
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