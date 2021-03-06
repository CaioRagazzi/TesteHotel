﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    /// <summary>
    /// Classe reponsável por padronizar o hotel definido pelo arquivo disponibilizado.
    /// </summary>
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


        /// <summary>
        /// Método utilizado para criar uma lista com todos os detalhes do hotel baseado no ID Destination que for selecionado.
        /// </summary>
        /// <param name="destination">ID de destino</param>
        /// <returns>Retorna uma lista de HotelDetails</returns>
        public List<HotelDetails> GetAllHotels(int destination)
        {
            List<HotelDetails> hotelDetails = new List<HotelDetails>();
            if (destination == 1003944)
            {
                using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Util\\1003944_hotels_static_data.json"))
                {
                    hotelDetails = JsonConvert.DeserializeObject<List<HotelDetails>>(sr.ReadToEnd());
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Util\\1010106_hotels_static_data.json"))
                {
                    hotelDetails = JsonConvert.DeserializeObject<List<HotelDetails>>(sr.ReadToEnd());
                }
            }

            return hotelDetails;
        }
        /// <summary>
        /// Método responsável por listar o hotel que precisa ser detalhado.
        /// </summary>
        /// <param name="destination">ID do destino</param>
        /// <param name="hotelId">ID do hotel a ser pesquisado</param>
        /// <returns>Retorna apenas um hotelDetails</returns>
        public HotelDetails GetHotelDetails(int destination, int hotelId)
        {
            List<HotelDetails> hotelDetails = new List<HotelDetails>();
            if (destination == 1003944)
            {
                using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Util\\1003944_hotels_static_data.json"))
                {
                    hotelDetails = JsonConvert.DeserializeObject<List<HotelDetails>>(sr.ReadToEnd());
                }

                var result = (from hot in hotelDetails
                             where hot.id == hotelId
                             select hot).FirstOrDefault();

                return result;
            }
            else
            {
                using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Util\\1010106_hotels_static_data.json"))
                {
                    hotelDetails = JsonConvert.DeserializeObject<List<HotelDetails>>(sr.ReadToEnd());
                }

                var result = (from hot in hotelDetails
                             where hot.id == hotelId
                             select hot).FirstOrDefault();
                return result;
            }            
        }
    }
}
