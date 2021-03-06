﻿using System.Collections.Generic;

namespace POS.Areas.Address.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Division> Divisions { get; set; }
        public List<District> Districts { get; set; }
        public List<Village> Villages { get; set; }
        
        }
}