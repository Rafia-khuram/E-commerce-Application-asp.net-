using ShoppingApplication.BOL;
using ShoppingApplication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class AddressBAL
    {
        public void AddCity(City city)
        {
            new AddressDAL().AddCity(city);
        }
        public City GetCity(int Id)
        {
            return new AddressDAL().GetCity(Id);
        }
        public void EditCity(City city)
        {
            new AddressDAL().EditCity(city);
        }
        public void DeleteCity(int Id)
        {
            new AddressDAL().DeleteCity(Id);
        }
        public List<City> GetCities()
        {
            return new AddressDAL().GetCities();
        }
        public void AddCountry(Country country)
        {
            new AddressDAL().AddCountry(country);
        }
        public Country GetCountry(int Id)
        {
            return new AddressDAL().GetCountry(Id);
        }
        public void EditCountry(Country country)
        {
            new AddressDAL().EditCountry(country);
        }
        public void DeleteCountry(int Id)
        {
            new AddressDAL().DeleteCountry(Id);
        }
        public List<Country> GetCountries()
        {
            return new AddressDAL().GetCountries();
        }
        public List<Address> GetAddresses()
        {
            return new AddressDAL().GetAddresses();
        }
    }
}
