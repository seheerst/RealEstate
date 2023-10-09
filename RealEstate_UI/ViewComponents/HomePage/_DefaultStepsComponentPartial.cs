using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.PopulerCityDtos;
using RealEstate_UI.Dtos.StepDtos;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultStepsComponentPartial: ViewComponent

    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultStepsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7067/api/Step");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStepDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
