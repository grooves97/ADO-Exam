﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExam.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
