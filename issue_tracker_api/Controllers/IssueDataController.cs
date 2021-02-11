using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace issue_tracker_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IssueDataController : ControllerBase
    {
        private static readonly string[] IssueTitle = new[]
        {
            "Phone not Working",
            "Website Down",
            "Server room overheating",
            "I want pizza"
        };

        private static readonly string[] IssueDescription = new[]
        {
            "Our Phone system hasn't been working for days now. We have no dial tone. Tried to reboot. Nothing.",
            "Enough said, our website is down; Get it back up!",
            "Server room overheating! SEND HELP! NOW!!!!!",
            "I want pizza. A large cheese one form that really good hole in the wall! You're paying, right?"
        };

        private readonly ILogger<IssueDataController> _logger;

        public IssueDataController(ILogger<IssueDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IssueData>> GetAll()
        {
            return new []
            {
                IssueTitle,
                IssueDescription
            }
        }



        //public IEnumerable<IssueData> Get()
        //{
        //    return (Index => new IssueData
        //    {
        //        Data = DateTime.Now.AddDays(index),
        //        IssueTitle,
        //        IssueDescription
        //    });
        //}

        //{
          
        //    return Enumerable.Range(1, 5).Select(index => new IssueData
        //    {
        //        // TODO: IssueID = int
        //        Date = DateTime.Now.AddDays(index),
        //        IssueTitle = IssueTitle
        //        IssueDescription = IssueDescription
        //    })
        //    .ToArray();
        //}
    }
}
