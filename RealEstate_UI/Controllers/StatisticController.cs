using Microsoft.AspNetCore.Mvc;

namespace RealEstate_UI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region Statistic1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7067/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.ActiveCategoryCount = jsonData;
            #endregion

            #region Statistic2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7067/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData2;
            #endregion

            #region Statistic3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7067/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData3;
            #endregion

            #region Statistic5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:7067/api/Statistics/AvgProductPriceByRent");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.AvgProductPriceByRent = jsonData5;
            #endregion

            #region Statistic6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:7067/api/Statistics/AvgProductPriceBySale");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.AvgProductPriceBySale = jsonData6;
            #endregion

            #region Statistic7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:7067/api/Statistics/AvgRoomCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.AvgRoomCount = jsonData7;
            #endregion

            #region Statistic8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:7067/api/Statistics/CategoryCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData8;
            #endregion

            #region Statistic9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:7067/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.CategoryNameByMaxProductCount = jsonData9;
            #endregion

            #region Statistic10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:7067/api/Statistics/CityNameByMaxProduct");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.CityNameByMaxProduct = jsonData10;
            #endregion

            #region Statistic11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:7067/api/Statistics/DifferentCityCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData11;
            #endregion

            #region Statistic12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:7067/api/Statistics/DifferentCityCount");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData12;
            #endregion

            #region Statistic13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client12.GetAsync("https://localhost:7067/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData13 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData13;
            #endregion

            #region Statistic14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:7067/api/Statistics/LastProductPrice");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.LastProductPrice = jsonData14;
            #endregion

            #region Statistic15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:7067/api/Statistics/NewestBuildingYear");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.NewestBuildingYear = jsonData15;
            #endregion

            #region Statistic16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:7067/api/Statistics/OldestBuildingYear");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.OldestBuildingYear = jsonData16;
            #endregion

            #region Statistic17
            var client17 = _httpClientFactory.CreateClient();
            var responseMessage17 = await client17.GetAsync("https://localhost:7067/api/Statistics/PassiveCategoryCount");
            var jsonData17 = await responseMessage17.Content.ReadAsStringAsync();
            ViewBag.PassiveCategoryCount = jsonData17;
            #endregion

            #region Statistic18
            var client18 = _httpClientFactory.CreateClient();
            var responseMessage18 = await client18.GetAsync("https://localhost:7067/api/Statistics/ProductCount");
            var jsonData18 = await responseMessage18.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData18;
            #endregion
            return View();
        }
    }
}
