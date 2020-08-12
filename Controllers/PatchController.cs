using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gwent_diff_backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PatchController: ControllerBase
    {
        
        // GET /Patch/Summary?ver=5.5.5
        [HttpGet]
        public async Task Summary([FromQuery] string versionNumber)
        {
            Console.WriteLine($"Version Number passed: {versionNumber}");
        }

    }
}