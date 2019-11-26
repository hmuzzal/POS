using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace POS.Areas.Address.Models
{
    public class Village
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int PsId { get; set; }
        public PoliceStation PoliceStation { get; set; }
        
    }
}