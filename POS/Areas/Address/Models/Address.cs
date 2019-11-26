using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Areas.Address.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name ="Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [Display(Name ="District")]
        public int DistrictId   { get; set; }
        public District District { get; set; }
        [Display(Name ="Police Station")]
        public int PsId { get; set; }
        public PoliceStation PoliceStation { get; set; }
        public Village Village { get; set; }

    }
}