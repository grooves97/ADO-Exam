using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityExam.Models
{
    public class Country : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
