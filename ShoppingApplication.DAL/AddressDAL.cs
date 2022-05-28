using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class AddressDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public void AddCity(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
        }
        public City GetCity(int Id)
        {
            return db.Cities.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditCity(City city)
        {
            var DbCity = db.Cities.Where(x => x.Id == city.Id).FirstOrDefault();
            if (DbCity != null)
            {
                if (!String.IsNullOrEmpty(city.Name))
                {
                    DbCity.Name = city.Name;
                }
                if (!String.IsNullOrEmpty(city.CountryId.ToString()))
                {
                    DbCity.CountryId = city.CountryId;
                }
            }
            db.SaveChanges();
        }
        public void DeleteCity(int Id)
        {
            db.Cities.Remove(db.Cities.Find(Id));
            db.SaveChanges();
        }
        public List<City> GetCities()
        {
            return db.Cities.ToList();
        }
        public void AddCountry(Country country)
        {
            db.Countries.Add(country);
            db.SaveChanges();
        }
        public Country GetCountry(int Id)
        {
            return db.Countries.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditCountry(Country country)
        {
            var DbCountry = db.Countries.Where(x => x.Id == country.Id).FirstOrDefault();
            if (DbCountry != null)
            {
                if (!String.IsNullOrEmpty(country.Name))
                {
                    DbCountry.Name = country.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteCountry(int Id)
        {
            db.Countries.Remove(db.Countries.Find(Id));
            db.SaveChanges();
        }
        public List<Country> GetCountries()
        {
            return db.Countries.ToList();
        }
        public List<Address> GetAddresses()
        {
            return db.Addresses.ToList();
        }
    }
}
