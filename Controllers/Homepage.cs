using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp_app.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class HomepageController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult HomePage(){
            return View();
        }

        private async Task<String> getJSON(){
            HttpResponseMessage response = await client.GetAsync("https://localhost:5001/api/stocks");
            response.EnsureSuccessStatusCode();
            String responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}