using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    /// <summary>
    /// Classe responsável por relacionar e definir o um padrão dos hoteis trazidos pela API e pelo arquivo disponibilizado
    /// </summary>
    public class HoteisFormatados
    {
        public List<Room> Rooms;
        public string NomeHotel;
        public string ChainName;
        public string CityNamePT;
        public string Endereco;
        public string WebSite;

        /// <summary>
        /// Relaciona a lista de Hoteis recebida pela API com a lista de detalhes de hotéis disponibilizada.
        /// </summary>
        /// <param name="hoteis">Lista de hotéis trazidas da API</param>
        /// <param name="destinationID">ID do destino</param>
        /// <returns>retorna apenas uma lista com todas as informações necessárias</returns>
        public List<HoteisFormatados> GetHoteisFormatados(List<Hotel> hoteis, int destinationID)
        {


            HotelDetails allHotels = new HotelDetails();
            
            var result = allHotels.GetAllHotels(destinationID);

            var alls = (from x in hoteis
                        join y in result on x.HotelId equals y.id
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
}
