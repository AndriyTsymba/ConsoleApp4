using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  


        public class City
        {
            private string name;
            private string country;
            private int population;
            private string phoneCode;
            private List<string> districts;
            public City()
            {
                districts = new List<string>();
            }
            public City(string name, string country, int population, string phoneCode, List<string> districts)
            {
                this.name = name;
                this.country = country;
                this.population = population;
                this.phoneCode = phoneCode;
                this.districts = districts;
            }
            public void SetName(string name)
            {
                this.name = name;
            }

            public void SetCountry(string country)
            {
                this.country = country;
            }

            public void SetPopulation(int population)
            {
                this.population = population;
            }

            public void SetPhoneCode(string phoneCode)
            {
                this.phoneCode = phoneCode;
            }

            public void SetDistricts(List<string> districts)
            {
                this.districts = districts;
            }
            public string GetName()
            {
                return name;
            }

            public string GetCountry()
            {
                return country;
            }

            public int GetPopulation()
            {
                return population;
            }

            public string GetPhoneCode()
            {
                return phoneCode;
            }

            public List<string> GetDistricts()
            {
                return districts;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Назва міста: {name}");
                Console.WriteLine($"Країна: {country}");
                Console.WriteLine($"Кількість жителів: {population}");
                Console.WriteLine($"Телефонний код: {phoneCode}");
                Console.WriteLine("Райони міста: " + string.Join(", ", districts));
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                City city = new City();

                city.SetName("Вінниця ");
                city.SetCountry("Україна");
                city.SetPopulation(348000);
                city.SetPhoneCode("044");
                city.SetDistricts(new List<string> { "Шевченківський", "Поділля", "Замостя" });
                city.DisplayInfo();
            }
        }
    }