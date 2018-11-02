using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using VirtualMinds.Models;

namespace VirtualMinds.Controllers
{
    public class CotizacionController : ApiController
    {
        

        public async  Task<IHttpActionResult> Get(TipoMoneda id)
        {
            try
            {
                if (TipoMoneda.Dolar == id)
                {
                    var BcoService = new Services.BcoProvParser();
                    var monedaRetorno = await BcoService.GetCotizacionDolar();

                    return Ok(monedaRetorno);
                }
                else
                    return Unauthorized();
                }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
