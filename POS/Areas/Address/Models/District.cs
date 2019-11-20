using System.Collections.Generic;

namespace POS.Areas.Address.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
    }
}