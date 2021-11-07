using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P_2E_1.Services;
using P_2E_1.Domain;

namespace P_2E_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {

        [HttpGet]
        public IActionResult CalR(Resistencia rstc)

        {
            var rser = new ResistenciaService();
            var res = rser.CalR(rstc.band1, rstc.band2, rstc.band3, rstc.band4);
            return Ok(res);
        }
    }
}
