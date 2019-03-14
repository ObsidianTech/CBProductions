using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBPUploadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamController : ControllerBase
    {
        private IHostingEnvironment _env { get; set; }

        public StreamController(IHostingEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var filepath = Path.Combine(_env.WebRootPath, "vids", "Ponder.mp3");
            return File(System.IO.File.OpenRead(filepath), "audio/mp3");

        }
    }
}