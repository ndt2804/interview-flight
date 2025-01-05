using System.ComponentModel.DataAnnotations;

namespace testflights.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public DateTime DepartureTime { get; set; }

        public string OriginAirport { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string DestinationAirport{ get; set; }
    }
}
