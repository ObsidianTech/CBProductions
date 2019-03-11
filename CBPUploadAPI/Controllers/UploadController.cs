using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Amazon.S3;
using Amazon.S3.Model;
using System.IO;

namespace CBPUploadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private static string accessKey = "AKIAJRRS7I4QQIUOBOCQ";
        private static string secretKey = "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";
        private static string bucketName = "nurenbucket";
        private AmazonS3Client s3Client;

        public UploadController()
        {
            s3Client = new AmazonS3Client(accessKey, secretKey, Amazon.RegionEndpoint.USEast2);
        }

        [HttpPost]
        public async Task<string> Post(IFormFile test)
        {
            
            return ("Upload Successful");
        }

        [HttpGet]
        [Route("init")]
        public string Init() => ("API successfully initialized. Ready to receive requests.");
    }
}