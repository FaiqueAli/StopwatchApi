using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StopWatchAPI.Data;
using StopWatchAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StopWatchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StopwatchController : ControllerBase
    {
        private readonly IStopwatch _repository;

        public StopwatchController(IStopwatch repository)
        {
            _repository = repository;
        }

        [HttpGet("Start")]
        public ActionResult<StopwatchModel> GetInstance()
        {
            var _stopwatch= _repository.StartTimer();
            return Ok(_stopwatch);
        }
        [HttpGet("Stop")]
        public ActionResult<StopwatchModel> StopInstance()
        {
            var _stopwatch = _repository.StopTimer();
            return Ok(_stopwatch);
        }
        //this is test commit
    }
}
