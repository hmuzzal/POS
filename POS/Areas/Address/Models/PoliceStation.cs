using System.Collections.Generic;

namespace POS.Areas.Address.Models
{
    public class PoliceStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
    }
}