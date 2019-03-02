using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBPVideoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CBPVideoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        //Action that will be calkled upon the initialization of the 
        [HttpGet]
        [Route("Init")]
        public ActionResult<string> Init()
        {
            return "Video API has been initialized successfully. Ready to receive requests.";
        }

        [HttpPost]
        public async Task<string> Post (Video video)
        {
            return "Upload Successful!";
        }
    }
}
