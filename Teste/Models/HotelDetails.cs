using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class HotelDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public string chainName { get; set; }
        public int chainId { get; set; }
        public double category { get; set; }
        public string urlThumb { get; set; }
        public string cityNamePT { get; set; }
        public string cityNameEN { get; set; }
        public string cityNameES { get; set; }
        public int cityId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double taRating { get; set; }
        public int taNumReviews { get; set; }
        public double percentRecommended { get; set; }
        public List<object> localizations { get; set; }
        public string address { get; set; }
        public string website { get; set; }

        public List<HotelDetails> GetAllHotels()
        {
            List<HotelDetails> hotelDetails = new List<HotelDetails>();
            using (StreamReader sr = new StreamReader(@"C:\Users\g0ysb\source\repos\Teste\Teste\Util\HOTELS.json"))
            {
                hotelDetails = JsonConvert.DeserializeObject<List<HotelDetails>>(sr.ReadToEnd());
            }

            return hotelDetails;
        }
    }
}
