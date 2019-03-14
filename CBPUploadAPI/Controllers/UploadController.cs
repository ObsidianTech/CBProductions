using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Amazon.S3;
using Amazon.S3.Model;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CBPUploadAPI.Controllers
{
    [DisableRequestSizeLimit]
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private IHostingEnvironment _env { get; set; }

        public UploadController(IHostingEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        public async Task<string> Post(IFormFile test)
        {
            string uploadpath = Path.Combine(_env.WebRootPath, "vids");
            string filename = test.FileName;
            using (FileStream fs = new FileStream(Path.Combine(uploadpath, filename), FileMode.Create))
            {
                await test.CopyToAsync(fs);
            }
            return ("Upload Successful");
        }

        [HttpGet]
        [Route("init")]
        public string Init() => ("API successfully initialized. Ready to receive requests.");
    }
}