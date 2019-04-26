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


        protected override void Seed(DataContext context)
        {
            countries = new List<Country>
            {
                new Country
                {
                    Name="Russia",
                    Cities= new List<City>
                    {
                        new City
                        {
                            Name = "Moscow",
                            Streets = new List<Street>
                            {
                                new Street
                                {
                                    Name = "Pavaletskaya"
                                }
                            }
                        }
                    }
                },

                new Country
                {
                    Name="Kazakhstan",
                    Cities= new List<City>
                    {
                        new City
                        {
                            Name = "Almaty",
                            Streets = new List<Street>
                            {
                                new Street
                                {
                                    Name = "Al-Farabi"
                                }
                            }
                        }
                    }
                }
            };



            context.Countries.AddRange(countries);
            base.Seed(context);
        }
    }
}
