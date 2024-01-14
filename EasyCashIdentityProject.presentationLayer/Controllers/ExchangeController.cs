using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.presentationLayer.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            #region
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=TRY&q=1.0"),
                Headers =
            {
                { "X-RapidAPI-Key", "981b80089fmshd2f1936c0f0b907p187c55jsnbb5ed0d3c9d2" },
                { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
            },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ViewBag.UsdToTry = body;
            }
            #endregion

            #region
            var client1 = new HttpClient();
            var request1 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=TRY&q=1.0"),
                Headers =
            {
                { "X-RapidAPI-Key", "981b80089fmshd2f1936c0f0b907p187c55jsnbb5ed0d3c9d2" },
                { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
            },
            };
            using (var response1 = await client1.SendAsync(request1))
            {
                response1.EnsureSuccessStatusCode();
                var body1 = await response1.Content.ReadAsStringAsync();
                ViewBag.EurToTry = body1;
            }
            #endregion

            #region
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=SEK&to=TRY&q=1.0"),
                Headers =
            {
                { "X-RapidAPI-Key", "981b80089fmshd2f1936c0f0b907p187c55jsnbb5ed0d3c9d2" },
                { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
            },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ViewBag.SekToTry = body2;
            }
            #endregion

            #region
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=EUR&q=1.0"),
                Headers =
            {
                { "X-RapidAPI-Key", "981b80089fmshd2f1936c0f0b907p187c55jsnbb5ed0d3c9d2" },
                { "X-RapidAPI-Host", "currency-exchange.p.rapidapi.com" },
            },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ViewBag.UsdToEur = body3;
            }
            #endregion
            return View();
        }
    }
}
