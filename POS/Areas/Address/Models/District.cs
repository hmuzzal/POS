using System.Collections.Generic;

namespace POS.Areas.Address.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }
        public List<PoliceStation> PoliceStations { get; set; }
        public List<Village> Villages { get; set; }
    }
}