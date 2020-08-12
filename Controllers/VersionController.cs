using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gwent_diff_backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VersionController : ControllerBase
    {
        // GET /Patch/CurrentVersionNum
        // returns a string containing the latest version number of gwent
        [HttpGet]
        public async Task<string> CurrentVersionNum()
        {
            // TODO: implement
            return "1.0.0";
        }

        // GET /Patch/PreviousVersionNum
        [HttpGet]
        public async Task<string> PreviousVersionNum()
        {
            // TODO: implement
            return "1.0.0";
        }

        // GET /Patch/AllVersionNums
        [HttpGet]
        public async Task<IEnumerable<string>> AllVersionNums()
        {
            // TODO: implement
            return new List<string>{"1.0.0"};
        }

    }
}