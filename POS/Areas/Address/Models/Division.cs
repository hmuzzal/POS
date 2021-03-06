﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POS.Areas.Address.Models
{
    public class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<District> Districts { get; set; }
        public List<PoliceStation> PoliceStations { get; set; }
        public List<Village> Villages { get; set; }
    }
}