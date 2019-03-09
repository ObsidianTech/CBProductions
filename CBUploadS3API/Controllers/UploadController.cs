using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBUploadS3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpGet]
        public async Task<string> Init()
        {
            return ("API had been initialized successfully, ready to accept requests.");
        }

        [HttpPost]
        public async Task<string> VideoUpload(IFormFile file)
        {
            return ("Video Uploaded Successfully!");
        }
    }
}
