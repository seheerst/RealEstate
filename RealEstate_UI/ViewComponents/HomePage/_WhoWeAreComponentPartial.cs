using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.AboutDtos;
using RealEstate_UI.Dtos.ServiceDtos;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _WhoWeAreComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _WhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7067/api/AboutDetail");
            var responseMessage2 = await client.GetAsync("https://localhost:7067/api/AboutServices");

            if (responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var jsonData2= await responseMessage2.Content.ReadAsStringAsync();

                var value = JsonConvert.DeserializeObject<List<ResultAboutDetailDto>>(jsonData);
                var value2 = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData2);

                ViewBag.Title = value.Select(x=>x.Title).FirstOrDefault();
                ViewBag.SubTitle = value.Select(x=>x.SubTitle).FirstOrDefault();
                ViewBag.Description1 = value.Select(x=>x.Description1).FirstOrDefault();
                ViewBag.Description2 = value.Select(x=>x.Description2).FirstOrDefault();
                return View(value2);
            }

            return View();
        }
    }
}
