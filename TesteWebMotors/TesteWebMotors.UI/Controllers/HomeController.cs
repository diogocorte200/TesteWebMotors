using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TesteWebMotors.Domain.Domain;
using TesteWebMotors.UI.Models;

namespace TesteWebMotors.UI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var httpResponse = await  this.apiClient.GetAsync("/api/AnuncioWebMotors/Listar");

            var content = await httpResponse.Content.ReadAsStringAsync();

            var models = JsonSerializer.Deserialize<List<AnuncionWebMotorsModel>>(content, new JsonSerializerOptions() { IgnoreNullValues = false, PropertyNamingPolicy = JsonNamingPolicy.CamelCase });


            return View(models);
        }

        public async Task<IActionResult> CriaAnuncio()
        {
            
            ViewBag.Marcas = new SelectList(await this.SelectMarcas(),"ID","Name",0);
            return View();
        }

        

        public ActionResult GetModels(int? val)
        {
            ViewBag.Modelos = this.SelectModelos(val.Value);

            return PartialView("Modelos");
        }

        public ActionResult GetVersoes(int? val)
        {
            ViewBag.Versoes = this.SelectVersoes(val.Value);

            return PartialView("Versoes");
        }

        [HttpPost]
        public async Task<IActionResult> Create( AnuncionWebMotorsModel anuncionWebMotorsModel)
        {
            var nameMarca = SelectMarcas().Result.Find(x => x.ID == Convert.ToInt32(anuncionWebMotorsModel.Marca)).Name;
            var nameModel = SelectModelos(Convert.ToInt32( anuncionWebMotorsModel.Marca)).Find(x => x.ID == Convert.ToInt32(anuncionWebMotorsModel.Modelo)).Name;
            var listaVersao = SelectVersoes(Convert.ToInt32(anuncionWebMotorsModel.Modelo));
            var nameVersao = listaVersao.Find(x => x.ID == Convert.ToInt32(anuncionWebMotorsModel.Versao)).Name;

            anuncionWebMotorsModel.Marca = nameMarca;
            anuncionWebMotorsModel.Modelo = nameModel;
            anuncionWebMotorsModel.Versao = nameVersao;

            StringContent content = new StringContent(JsonSerializer.Serialize(anuncionWebMotorsModel, typeof(AnuncionWebMotorsModel)), Encoding.UTF8, "application/json");
            await this.apiClient.PostAsync("/api/AnuncioWebMotors/Incluir", content);

            return RedirectToAction("Index");
            

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            
            using (var httpReq = new HttpRequestMessage(HttpMethod.Delete, $"/api/AnuncioWebMotors/Deletar?id={id}"))
            {
                using (var responseRest = await this.apiClient
                           .SendAsync(httpReq))
                {
                    responseRest.EnsureSuccessStatusCode();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
