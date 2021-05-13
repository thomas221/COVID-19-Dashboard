using BlazorApp2.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BlazorApp2.Server.Controllers
{
    [ApiController]
    [Route("CovidDataTotalInfected")]
    public class CovidDataTotalInfectedController : ControllerBase
    {


        private readonly ILogger<CovidDataTotalInfectedController> logger;

        public CovidDataTotalInfectedController(ILogger<CovidDataTotalInfectedController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var returnString = "";
            using (WebClient wc = new WebClient())
            {
                returnString = wc.DownloadString("https://api.covid19api.com/summary");
            }

            dynamic json = JsonConvert.DeserializeObject(returnString);

            foreach (dynamic country in json.Countries)
            {
                if (country.Country == "Belgium")
                {
                    return country.TotalConfirmed;
                }
            }
            return json.Countries[0].Country;
        }
    }

    [ApiController]
    [Route("CovidDataTotalDeaths")]
    public class CovidDataTotalDeathsController : ControllerBase
    {
        

        private readonly ILogger<CovidDataTotalDeathsController> logger;

        public CovidDataTotalDeathsController(ILogger<CovidDataTotalDeathsController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var returnString = "";
            using (WebClient wc = new WebClient())
            {
                returnString = wc.DownloadString("https://api.covid19api.com/summary");
            }

            dynamic json = JsonConvert.DeserializeObject(returnString);

            foreach (dynamic country in json.Countries){
                if (country.Country == "Belgium")
                {
                    return country.TotalDeaths;
                }
            }
            return json.Countries[0].Country;
        }
    }
}
