﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExam.Models
{
    public class Street : Entity
    {
        public string Name { get; set; }

        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
        public Guid CityId { get; set; }
        public virtual City City { get; set; }
    }
}