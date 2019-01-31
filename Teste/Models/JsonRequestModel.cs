using System.Collections.Generic;

namespace Teste.Models
{
    /// <summary>
    /// Classe responsável por definir os usuário e senha de autenticação da API
    /// </summary>
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    /// <summary>
    /// Classe responsável por padronizar a lista SearchRoom que é retornada da API
    /// </summary>
    public class SearchRoom
    {
        public int NumAdults { get; set; }
        public List<int> ChildAges { get; set; }
        public int Quantity { get; set; }
    }
    /// <summary>
    /// Classe responsável por padronizar os critérios que são enviados para a API para realizar a busca
    /// </summary>
    public class Criteria
    {
        public int DestinationId { get; set; }
        public int NumNights { get; set; }
        public string CheckinDate { get; set; }
        public string MainPaxCountryCodeNationality { get; set; }
        public List<SearchRoom> SearchRooms { get; set; }
    }
    /// <summary>
    /// Classe responsável por padronizar o envio de informações para a API.
    /// </summary>
    public class JsonRequestModel
    {
        public Credential Credential { get; set; }
        public Criteria Criteria { get; set; }
    }
}
