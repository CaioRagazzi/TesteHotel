using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        static HttpClient client = new HttpClient();


        public IActionResult Index()
        {
            List<string> cities = new List<string>()
            {
                "MIAMI",
                "ORLANDO"
            };

            ViewBag.Cities = cities;

            return View();
        }

        static async Task<JsonResultModel> GetHotelAsync(string path, Credential credential, Criteria criteria)
        {
            JsonResultModel hoteis = null;

            JsonRequestModel hotels = new JsonRequestModel
            {
                Credential = credential,
                Criteria = criteria
            };

            client.BaseAddress = new Uri("https://pp.cangooroo.net/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync("ws/rest/hotel.svc/Search", hotels);
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync().Result;
                hoteis = JsonConvert.DeserializeObject<JsonResultModel>(jsonResult);
            }

            return hoteis;
        }

        private static async Task<JsonResultModel> CreateHotel()
        {
            var searchRoom = new SearchRoom()
            {
                ChildAges = new List<int> { 1 },
                NumAdults = 1,
                Quantity = 1
            };

            var credential = new Credential()
            {
                Username = "candidato_t4w",
                Password = "candit@!2019"
            };

            var criteria = new Criteria()
            {
                DestinationId = 1003944,
                NumNights = 2,
                CheckinDate = "2019-02-10",
                MainPaxCountryCodeNationality = "BR",
                SearchRooms = new List<SearchRoom>()
                {
                    searchRoom
                }
            };

            JsonResultModel hoteis = await GetHotelAsync("https://pp.cangooroo.net/ws/rest/hotel.svc/Search", credential, criteria);

            return hoteis;
        }
    }
}
