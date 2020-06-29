using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class CarDAL
    {

        public HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"https://localhost:44344/");
            return client;
        }
        
        public async Task<List<Cars>> GetCars(string make, string model, int year, string color)
        {
           
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/carsapi/make/{make ?? "any"}/model/{model ?? "any"}/year/{year}/color/{color ?? "any"}");
            //install-package Microsoft.AspNet.WebAPI.Client
            var cars = await response.Content.ReadAsAsync<List<Cars>>();
            return cars;
        }

        public async Task<Cars> AddCar(Cars newCar)
        {
            //employee.id = 1;
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync($"api/carsapi", newCar);
            var carResult = await response.Content.ReadAsAsync<Cars>();
            return carResult;
        }

        public async void DeleteCar(int id)
        {
            var client = GetHttpClient();
            var response = await client.DeleteAsync($"api/carsapi/{id}");
        }

        public async void UpdateCar(Cars updatedCar)
        {
            var client = GetHttpClient();
            var response = await client.PutAsJsonAsync($"api/carsapi", updatedCar);
        }

        public async Task<Cars> GetCar(int id)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"api/carsapi/{id}");
            //install-package Microsoft.AspNet.WebAPI.Client
            var car = await response.Content.ReadAsAsync<Cars>();
            return car;
        }
    }
}
