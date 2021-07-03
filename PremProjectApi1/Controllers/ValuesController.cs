using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremProjectApi1.Controllers
{
    [Route("api/Name")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public String NewItem()
        {
            return "My Name is Khan";
        }
        }
}
