using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Aggregate.WebMotors;

namespace TesteWebMotors.UI.Controllers
{
    [EnableCors()]
    public class BaseController : Controller
    {
        public HttpClient apiClient { get; set; }

        public BaseController()
        {
            if(apiClient == null)
            {
                apiClient = new HttpClient
                {
                    BaseAddress = new Uri($"http://localhost:49915/")
                };
            }
            
        }

        public async Task<List<Marca>> SelectMarcas()
        {
            var httpResponse = await this.apiClient.GetAsync("/api/WebMotorsClient/ListarMarcas");

            var content = await httpResponse.Content.ReadAsStringAsync();

            var models = JsonSerializer.Deserialize<List<Marca>>(content, new JsonSerializerOptions() { IgnoreNullValues = false, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            return models;
        }

        
        public List<Modelo> SelectModelos(int id)
        {
            var httpResponse = this.apiClient.GetAsync("/api/WebMotorsClient/ListarModelos?id=" + id).Result;

            var content = httpResponse.Content.ReadAsStringAsync().Result;

            var models = JsonSerializer.Deserialize<List<Modelo>>(content, new JsonSerializerOptions() { IgnoreNullValues = false, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            return models;

        }
        public List<Versao> SelectVersoes(int id)
        {
            var httpResponse = this.apiClient.GetAsync("/api/WebMotorsClient/ListarVersoes?id=" + id).Result;

            var content = httpResponse.Content.ReadAsStringAsync().Result;

            var models = JsonSerializer.Deserialize<List<Versao>>(content, new JsonSerializerOptions() { IgnoreNullValues = false, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            return models;

        }


    }
}
