using System.Collections.Generic;

namespace Teste.Models
{
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class SearchRoom
    {
        public int NumAdults { get; set; }
        public List<int> ChildAges { get; set; }
        public int Quantity { get; set; }
    }

    public class Criteria
    {
        public int DestinationId { get; set; }
        public int NumNights { get; set; }
        public string CheckinDate { get; set; }
        public string MainPaxCountryCodeNationality { get; set; }
        public List<SearchRoom> SearchRooms { get; set; }
    }

    public class JsonRequestModel
    {
        public Credential Credential { get; set; }
        public Criteria Criteria { get; set; }
    }
}
