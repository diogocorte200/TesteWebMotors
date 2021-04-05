using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Aggregate;
using TesteWebMotors.Domain.Aggregate.WebMotors;

namespace TesteWebMotors.Client
{
    public class WebMotorsClient : IWebMotorsClient
    {
        private readonly ILogger<WebMotorsClient> _logger;
        private readonly HttpClient _httpClient;
        const string URI_WEBMOTORS = "http://desafioonline.webmotors.com.br/api/OnlineChallenge/";
        public WebMotorsClient(ILogger<WebMotorsClient> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Marca>> ObterMarcas()
        {
            try
            {
                var strUri = URI_WEBMOTORS + "Make";

                var result = await _httpClient.GetAsync(strUri);


                if (result.IsSuccessStatusCode)
                {
                    var resultJson = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Marca>>(resultJson);
                }
                else
                {
                    _logger.LogInformation($"Error :{result.StatusCode} Msg:{result.Content}");
                    return default;
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Exc {error.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<Modelo>> ObterModelos(int id)
        {
            try
            {
                var strUri = URI_WEBMOTORS + $"Model?MakeID={id}";

                var result = await _httpClient.GetAsync(strUri);


                if (result.IsSuccessStatusCode)
                {
                    var resultJson = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Modelo>>(resultJson);
                }
                else
                {
                    _logger.LogInformation($"Error :{result.StatusCode} Msg:{result.Content}");
                    return default;
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Exc {error.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<Versao>> ObterVersoes(int id)
        {
            try
            {
                var strUri = URI_WEBMOTORS + $"Version?ModelID={id}";

                var result = await _httpClient.GetAsync(strUri);


                if (result.IsSuccessStatusCode)
                {
                    var resultJson = await result.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Versao>>(resultJson);
                }
                else
                {
                    _logger.LogInformation($"Error :{result.StatusCode} Msg:{result.Content}");
                    return default;
                }

            }
            catch (Exception error)
            {
                _logger.LogError(error, $"Exc {error.Message}");
                throw;
            }
        }
    }
}
