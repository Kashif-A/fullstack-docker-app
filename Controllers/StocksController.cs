using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.IO;

namespace asp_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();
        //private readonly String apiKey = "SED3CI8WMQOZXAYT";
        //private readonly String cache = "";

        //public async Task<String> getStocks(){
        public String getStocks(){
            //HttpResponseMessage response = await client.GetAsync("https://www.alphavantage.co/query?function=TIME_SERIES_WEEKLY&symbol=fgp&apikey=" + apiKey);
            //response.EnsureSuccessStatusCode();
            //string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
            //return responseBody;

            return fileToJson("./util/stockData.json");
        }
       private String fileToJson(String filePath) {
            try
            {
                using (StreamReader r = new StreamReader(filePath)) {
                    String parsedJsonFile = r.ReadToEnd();
                    return parsedJsonFile;
                }   
            }
            catch (FileNotFoundException Ex)
            {
                return Ex.ToString();
            }
            catch (AccessViolationException Ex)
            {
                return Ex.ToString();
            }
            catch (Exception Ex)
            {
                return Ex.ToString();
            }
        }
    }
}