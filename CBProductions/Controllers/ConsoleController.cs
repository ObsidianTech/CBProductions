﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBProductions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ConsoleController : Controller
    {
    }
}