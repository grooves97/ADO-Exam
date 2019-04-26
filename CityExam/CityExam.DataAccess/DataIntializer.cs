using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CityExam.Models;

namespace CityExam.DataAccess
{
    public class DataIntializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        private List<Country> countries;
        private List<City> cities;
        private List<Street> streets;

        protected override void Seed(DataContext context)
        {
            countries = new List<Country>
            {
                new Country
                {
                    Name="Russia"
                },

                new Country
                {
                    Name="Kazakhstan"
                }
            };

            cities = new List<City>
            {
                new City
                {
                    Name="Moscow"
                },

                new City
                {
                    Name="Almaty"
                }
            };

            streets = new List<Street>
            {
                new Street
                {
                    Name="Paveletskaya"
                },

                new Street
                {
                    Name="Al-Farabi"
                }
            };

            context.Countries.AddRange(countries);
            context.Cities.AddRange(cities);
            context.Streets.AddRange(streets);
            base.Seed(context);
        }
    }
}
