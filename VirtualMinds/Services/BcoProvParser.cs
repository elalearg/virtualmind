using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace VirtualMinds.Services
{
    public class BcoProvParser
    {
        private const string url = "http://www.bancoprovincia.com.ar/Principal/Dolar";

        public async Task<Models.Moneda> GetCotizacionDolar()
        {
            
            var result = await url.GetAsync().ReceiveJson<string[]>();
            var moneda   = new Models.Moneda(result);
            
            return moneda;
            

        }

    }
}