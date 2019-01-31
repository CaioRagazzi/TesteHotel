using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    /// <summary>
    /// Classe responsável por padronizar o valor e a moeda do quarto que são retornadas pela API.
    /// </summary>
    public class SellingPricePerRoom
    {
        public string Currency { get; set; }
        public double Value { get; set; }
    }
    /// <summary>
    /// Classe responsável por padronizar o valor e a moeda total que são retornadas pela API.
    /// </summary>
    public class TotalSellingPrice
    {
        public string Currency { get; set; }
        public int Value { get; set; }
    }
    /// <summary>
    /// Classe responsável por padronizar as informações do quarto que são retornadas pela API.
    /// </summary>
    public class Room
    {
        public string BoardDescription { get; set; }
        public object CancellationPolicies { get; set; }
        public List<int> ChildAges { get; set; }
        public object CustomFields { get; set; }
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPrePayment { get; set; }
        public string MoreInformation { get; set; }
        public int NumAdults { get; set; }
        public bool PayDirectToHotel { get; set; }
        public int Quantity { get; set; }
        public string RoomDescription { get; set; }
        public SellingPricePerRoom SellingPricePerRoom { get; set; }
        public TotalSellingPrice TotalSellingPrice { get; set; }
    }
    /// <summary>
    /// Classe responsável por padronizar as informações do Hotel que são retornadas pela API.
    /// </summary>
    public class Hotel
    {
        public int HotelId { get; set; }
        public bool IsRecommended { get; set; }
        public List<Room> Rooms { get; set; }
    }
    /// <summary>
    /// Classe responsável por padronizar o recebimento de informações para a API.
    /// </summary>
    public class JsonResultModel
    {
        public object Error { get; set; }
        public string TimeSpan { get; set; }
        public string Token { get; set; }
        public double TotalTime { get; set; }
        public List<Hotel> Hotels { get; set; }
        public int TotalHotelResults { get; set; }
    }
}
